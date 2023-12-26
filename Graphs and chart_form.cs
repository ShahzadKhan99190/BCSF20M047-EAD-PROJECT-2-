using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Interests_Sys_Project
{
    public partial class Graphs_and_chart_form : Form
    {
        public Graphs_and_chart_form()
        {
            InitializeComponent();
        }

        private void Chart1_Gender(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(Gender) FROM STUDENT GROUP BY CITY ORDER BY COUNT(ROLL_NUM)", conn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "STUDENT");

                chart1.DataSource = ds.Tables["STUDENT"];
                chart1.Series["Series1"].XValueMember = "GENDER";

                chart1.Series["Series1"].IsValueShownAsLabel = true;

                chart1.ChartAreas[0].AxisX.Interval = 1;

                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
                chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        private void Graphs_and_chart_form_Load(object sender, EventArgs e)
        {
        }
    }
}
