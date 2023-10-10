using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace FutureScan
{
    public partial class Edit_Patients : Form
    {
        public String connection = "Data Source=DESKTOP-CUSJP6K;Initial Catalog=Rediolgy;Integrated Security=True";
        SqlConnection con;
        Thread thread;
        SqlDataAdapter adapter;
        DataTable dt;

        public Edit_Patients()
        {
            con = new SqlConnection(connection);
            InitializeComponent();
            con.Open();
            ShowData();
            con.Close();
        }
        private void ShowData()
        {
            String Quary = "select * from TB_Patient where  name !='' and patient_exam!='' ";
            adapter = new SqlDataAdapter(Quary, con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Edit_Patients_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Data_Grid(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                txt_name.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                txt_age.Text = dataGridView1.CurrentRow.Cells["age"].Value.ToString();
                txt_cash.Text = dataGridView1.CurrentRow.Cells["cash"].Value.ToString();
                txt_discount.Text = dataGridView1.CurrentRow.Cells["discount"].Value.ToString();
                txt_phone.Text = dataGridView1.CurrentRow.Cells["Phone_Number"].Value.ToString();
                txt_exam.Text = dataGridView1.CurrentRow.Cells["patient_exam"].Value.ToString();
                txt_id.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();


            }
        }

        private void add_emp_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == " " || txt_age.Text == "" || txt_discount.Text == "" || txt_cash.Text == "" || txt_phone.Text == "" || txt_exam.Text == "") 
            {
                MessageBox.Show("Please Enter User Name and Password");
                txt_name.Focus();
            }

            else
            {
                String quary = "insert into TB_Patient values(@name,@age,@phone_number,@cash,@discount,@patient_exam,@address,@referring_doctor)";
                SqlCommand cmd = new SqlCommand(quary, con);

                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@age", txt_age.Text);
                cmd.Parameters.AddWithValue("@phone_number", txt_phone.Text);
                cmd.Parameters.AddWithValue("@cash", txt_cash.Text);
                cmd.Parameters.AddWithValue("@discount", txt_discount.Text);
                cmd.Parameters.AddWithValue("@patient_exam", txt_exam.Text);
                cmd.Parameters.AddWithValue("@address", txt_discount.Text);
                cmd.Parameters.AddWithValue("@referring_doctor", txt_exam.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    ShowData();
                    MessageBox.Show("Done");

                }
                else
                {
                    MessageBox.Show("False");

                }
                con.Close();
            }
        }

        private void updata_emp_Click(object sender, EventArgs e)
        {
            con.Open();
            string name = txt_name.Text;
            string age = txt_age.Text;
            string phone = txt_phone.Text;
            string exam = txt_exam.Text;
            string cash = txt_cash.Text;
            string discount = txt_discount.Text;
            string id=txt_id.Text;
            string quary = "update TB_patient set name ='" + name + "' , age='" + age + "'  phone_number ='" + phone + "'  cash ='" + cash + "'  discount ='" + discount + "'  patient_exam ='" + exam + "' where ID='" + id + "'";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.ExecuteNonQuery();
            dataGridView1.CurrentRow.Cells["name"].Value = txt_name.Text;
            dataGridView1.CurrentRow.Cells["age"].Value = txt_age.Text;
            dataGridView1.CurrentRow.Cells["phone_number"].Value = txt_phone.Text;
            dataGridView1.CurrentRow.Cells["cash"].Value = txt_cash.Text;
            dataGridView1.CurrentRow.Cells["discount"].Value = txt_discount.Text;
            dataGridView1.CurrentRow.Cells["patient_exam"].Value = txt_exam.Text;
            ShowData();

            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void OpenForm(object obj)
        {
            Application.Run(new choice());
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void delete_emp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
