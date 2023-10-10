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
    public partial class EditEmployee : Form
    {
        public String connection = "Data Source=DESKTOP-CUSJP6K;Initial Catalog=Rediolgy;Integrated Security=True";
        SqlConnection con;
        Thread thread;
        SqlDataAdapter adapter;
        DataTable dt;
        public EditEmployee()
        {
            con = new SqlConnection(connection);
            InitializeComponent();
            con.Open();
            ShowData();
            con.Close();
        }

          
       

        private void ShowData()
        {
            string Quary = "select * from TB_EMP";
            adapter = new SqlDataAdapter(Quary,con);
            dt=new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;  
        }

       

        private void EditEmp(object sender, EventArgs e)
        {
           if(dataGridView1.CurrentRow!=null)
            {
                dataGridView1.CurrentRow.Cells["userName"].Value = txt_nameemp.Text;
                dataGridView1.CurrentRow.Cells["passWord"].Value = txt_passemp.Text;

            }
        }

        private void add_emp_Click(object sender, EventArgs e)
        {

            if (txt_nameemp.Text == " " || txt_passemp.Text == "")
            {
                MessageBox.Show("Please Enter User Name and Password");
                txt_nameemp.Focus();
            }

            else
            {
                    String quary = "insert into TB_EMP values(@userName,@password)";
                    SqlCommand cmd = new SqlCommand(quary, con);

                    cmd.Parameters.AddWithValue("@userName", txt_nameemp.Text);
                    cmd.Parameters.AddWithValue("@password", txt_passemp.Text);
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
        private void OpenAnthorForm(object obj)
        {
            Application.Run(new Pationt_choice());
        }

        private void data_grid(object sender, EventArgs e)
        {
            if(dataGridView1!=null)
            {
                txt_id.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                txt_nameemp.Text = dataGridView1.CurrentRow.Cells["userName"].Value.ToString();
                txt_passemp.Text = dataGridView1.CurrentRow.Cells["passWord"].Value.ToString();

            }
        }

        private void updata_emp_Click(object sender, EventArgs e)
        {
            con.Open();
            string id=txt_id.Text;
            string username = txt_nameemp.Text;
            string password=txt_passemp.Text;
            string quary = "update TB_EMP set userName ='"+username+"' , password='" + password + "' where ID='" + id + "'";
            SqlCommand cmd=new SqlCommand(quary,con);
            cmd.ExecuteNonQuery();
            dataGridView1.CurrentRow.Cells["userName"].Value = txt_nameemp.Text;
            dataGridView1.CurrentRow.Cells["passWord"].Value = txt_passemp.Text;
            ShowData();

            con.Close();
           
        }

        private void delete_emp_Click(object sender, EventArgs e)
        {
            con.Open();
            string quary = "delete from TB_EMP where id=@ID";
            SqlCommand command = new SqlCommand(quary, con);
            command.Parameters.AddWithValue("@ID",int.Parse(txt_id.Text));
            command.ExecuteNonQuery();
            ShowData();
            con.Close();
            
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
        private void OpenForm(object obj)
        {
            Application.Run(new choice());
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }

}
/*DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
            if(MessageBox.Show(String.Format("Do You Want to Delete ?", dataGridViewRow.Cells["ID"].Value), "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string quary = "delete from TB_EMP where id=@ID";
                SqlCommand command=new SqlCommand(quary,con);
                command.Parameters.AddWithValue("@ID",dataGridViewRow.Cells["ID"].Value);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
            ShowData();*/
