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
    public partial class Number_Patients : Form
    {
        public String connection = "Data Source=DESKTOP-CUSJP6K;Initial Catalog=Rediolgy;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapter;
        Thread thread;
        public Number_Patients()
        {
            con = new SqlConnection(connection);
            InitializeComponent();
            ShowData();
            dateTimePicker1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowData()
        {
            dateTimePicker1.Text = DateTime.Now.ToString("yyyy-MM-dd");


            //if (combo_date.Text== DateTime.Now.ToString("yyyy/MM/dd"))
            //{
            con.Open();
                String quary = "select name,age,patient_exam,cash,discount,rest ,referring_doctor ,Phone_Number from TB_Patient where  name !='' and patient_exam!=''and date_time= '" + dateTimePicker1.Text+"'";
                SqlCommand cmd = new SqlCommand(quary, con);
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt.Clear();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            /*}
            else
            {
                MessageBox.Show("e");
            }*/

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            try
            {
                
                l_sum.Text = "0";
            
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    l_sum.Text = Convert.ToString(double.Parse(l_sum.Text) + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                }
            
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

           
        }

        

        private void Number_Patients_Load(object sender, EventArgs e)
        {

        }
        private void OpenForm(object obj)
        {
            Application.Run(new Cash());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Close();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String quary = "select name,age,patient_exam,cash,discount,rest ,referring_doctor,phone_number from TB_Patient where name !='' and patient_exam!='' and date_time between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'";
            SqlCommand cmd = new SqlCommand(quary, con);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void passData(object sender, DataGridViewCellEventArgs e)
        {
            Cash c = new Cash();
            c.txt_name.Text=this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            c.txt_age.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            c.combo_examination.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            c.txt_cash.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
           // c.txt_discount.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            c.txt_rest.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            c.txt_doc.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            c.txt_phone.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            
           

            c.ShowDialog();
            this.Close();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
