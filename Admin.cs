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
    public partial class Admin : Form
    {
        public String connection = "Data Source=DESKTOP-CUSJP6K;Initial Catalog=Rediolgy;Integrated Security=True";
        SqlConnection con;
        Thread thread;

        public Admin()
        {
            con = new SqlConnection(connection);
            InitializeComponent();
            txt_adminpassword.PasswordChar = '*';
            txt_adminpassword.MaxLength = 20;
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();


        }

        private void OpenForm(object obj)
        {
            Application.Run(new login());
        }
        private void OpenAnatherForm(object obj)
        {
            Application.Run(new choice());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_adminname.Text == " " || txt_adminpassword.Text == "")
            {
                MessageBox.Show("Please Enter User Name and Password");
                txt_adminname.Focus();
            }

            else
            {

                String q = "select userName,passWord from TB_Admin where userName=@userName and password=@password";
                SqlCommand cmdd = new SqlCommand(q, con);

                cmdd.Parameters.AddWithValue("@userName", txt_adminname.Text);
                cmdd.Parameters.AddWithValue("@password", txt_adminpassword.Text);
                SqlDataReader reader;
                con.Open();
                reader = cmdd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Exist");
                    this.Close();
                    thread = new Thread(OpenAnatherForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    con.Close();
                }
                else
                {



                    String quary = "insert into TB_Admin values(@userName,@password)";
                    SqlCommand cmd = new SqlCommand(quary, con);

                    cmd.Parameters.AddWithValue("@userName", txt_adminname.Text);
                    cmd.Parameters.AddWithValue("@password", txt_adminpassword.Text);
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        // MessageBox.Show("Done");
                        this.Close();
                        thread = new Thread(OpenAnatherForm);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();



                    }
                    else
                    {
                        MessageBox.Show("False");

                    }
                    con.Close();



                }

            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
