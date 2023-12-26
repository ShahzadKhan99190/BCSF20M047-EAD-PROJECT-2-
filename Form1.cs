using System.Drawing;
using System.Windows.Forms;

namespace Student_Interests_Sys_Project
{
    public partial class Form1 : Form
    {
        public string ID = string.Empty;
        public Form1(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var stdlist_form = new StudentList_Form();

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\EAD_PROJECT\\Student_Interests_Sys_Project\\Student_Interests_Sys_Project\\MyDataBase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO STUDENT(NAME, ROLL_NUM, EMAIL, GENDER, DATE_OF_BIRTH, CITY, INTEREST, DEPT, DEGREE, SUBJECT, START_DATE, END_DATE) VALUES (@NAME, @ROLL_NUM, @EMAIL, @GENDER, @DATE_OF_BIRTH, @CITY, @INTEREST, @DEPT, @DEGREE, @SUBJECT, @START_DATE, @END_DATE)", con);
            cmd.Parameters.AddWithValue("@NAME", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@ROLL_NUM", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@EMAIL", textBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@GENDER", textBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@DATE_OF_BIRTH", dateTimePicker1.Text.ToString());
            cmd.Parameters.AddWithValue("CITY", comboBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@INTEREST", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@DEPT", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@DEGREE", comboBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@SUBJECT", textBox5.Text.ToString());
            cmd.Parameters.AddWithValue("@START_DATE", dateTimePicker2.Text.ToString());
            cmd.Parameters.AddWithValue("@END_DATE", dateTimePicker2.Text.ToString());

            cmd.ExecuteNonQuery();
            con.Close();

            stdlist_form.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\EAD_PROJECT\\Student_Interests_Sys_Project\\Student_Interests_Sys_Project\\MyDataBase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE STUDENT SET NAME = @NAME, ROLL_NUM = @ROLL_NUM,  EMAIL = @EMAIL, GENDER = @GENDER, DATE_OF_BIRTH = @DATE_OF_BIRTH, CITY = @CITY, INTEREST = @INTEREST, DEPT = @DEPT, DEGREE = @DEGREE, SUBJECT = @SUBJECT, START_DATE = @START_DATE, END_DATE = @END_DATE WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@NAME", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@ROLL_NUM", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@EMAIL", textBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@GENDER", textBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@DATE_OF_BIRTH", dateTimePicker1.Text.ToString());
            cmd.Parameters.AddWithValue("CITY", comboBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@INTEREST", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@DEPT", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@DEGREE", comboBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@SUBJECT", textBox5.Text.ToString());
            cmd.Parameters.AddWithValue("@START_DATE", dateTimePicker2.Text.ToString());
            cmd.Parameters.AddWithValue("@END_DATE", dateTimePicker2.Text.ToString());

            cmd.ExecuteNonQuery();
            con.Close();
        }

            private void Std_List_Btn(object sender, EventArgs e)
        {
            var stdlist_form = new StudentList_Form();
            stdlist_form.Show();
        }

        private void Dashboard_Btn(object sender, EventArgs e)
        {
            var Dashb_form = new Dashboard_form();
            Dashb_form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
        private void label1_Click(object sender, EventArgs e)
        {}
        private void label8_Click(object sender, EventArgs e)
        {}
        private void label9_Click(object sender, EventArgs e)
        {}

    }
}