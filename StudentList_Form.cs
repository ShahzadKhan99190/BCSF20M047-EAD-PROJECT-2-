using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Interests_Sys_Project
{
    public partial class StudentList_Form : Form
    {

        int pageNumber = 1;
        IPagedList<Student> list;


        public StudentList_Form()
        {
            InitializeComponent();
        }

        public async Task<PagedList<Student>> GetPagedListAsync(int pageNumber = 1, int pageSize = 10)
        {
            return await Task.Factory.StartNew(() =>
            {
                Using(NorthWindEntities db = new NorthWindEntities())
                {
                    return DBConcurrencyException.Student.OrderBy(pageNumber => p.ID).ToPagedList(pageNumber, pageSize)
                }
            });
        }
        private void StudentList_Form_Load(object sender, EventArgs e)
        {
            list = await GetPagedListAsync();
            btnPrevios.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            dataGridView.DataSource = list.ToList();
            lblPageNumber.Text = string.Format("page {0}/{1}", pageNumber, list.pageCount);
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await GetPagedListAsync(--pageNumber);
                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dataGridView.DataSource = list.ToList();
                lblPageNumber.Text = string.Format("page {0}/{1}", pageNumber, list.pageCount);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await GetPagedListAsync(++pageNumber);
                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dataGridView.DataSource = list.ToList();
                lblPageNumber.Text = string.Format("page {0}/{1}", pageNumber, list.pageCount);
            }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            var add_std_form = new Form1();
            add_std_form.Show();
        }

        private void Dashboard_Btn_Click(object sender, EventArgs e)
        {
            var Dashb_form = new Dashboard_form();
            Dashb_form.Show();
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            var Id = ID_textbox.Text.ToString();
            var add_std_form = new Form1(Id);
            add_std_form.Show();
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            var Id = ID_textbox.Text.ToString();

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\EAD_PROJECT\\Student_Interests_Sys_Project\\Student_Interests_Sys_Project\\MyDataBase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM STUDENT WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
