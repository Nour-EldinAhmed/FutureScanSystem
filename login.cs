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
    public partial class login : Form
    {
        public String connection= "Data Source=DESKTOP-CUSJP6K;Initial Catalog=Rediolgy;Integrated Security=True; MultipleActiveResultSets=true";
        SqlConnection con;
        Thread thread;
        public login()
        {
            con=new SqlConnection(connection);
            InitializeComponent();
            txt_password.PasswordChar = '*';
            txt_password.MaxLength = 20;
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txt_username.Text == " " || txt_password.Text == "")
            {
                MessageBox.Show("Please Enter User Name and Password");
                txt_username.Focus();
            }

            else
            {
                
                String q = "select userName,passWord from TB_EMP where userName=@userName and password=@password";
                SqlCommand cmdd = new SqlCommand(q, con);

                cmdd.Parameters.AddWithValue("@userName", txt_username.Text);
                cmdd.Parameters.AddWithValue("@password", txt_password.Text);
                SqlDataReader reader;
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                
                reader=cmdd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Exist");
                    this.Close();
                    thread = new Thread(OpenAnthorForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    reader.Close();
                    con.Close();
                }
                else
                {



                    String quary = "insert into TB_EMP values(@userName,@password)";
                    SqlCommand cmd = new SqlCommand(quary, con);

                    cmd.Parameters.AddWithValue("@userName", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Done");
                        this.Close();
                        thread = new Thread(OpenAnthorForm);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();

                        


                    }
                    else
                    {
                        MessageBox.Show("False");

                    }
                    reader.Close();
                    con.Close();
                }
            }

        }

        private void OpenAnthorForm(object obj)
        {
            Application.Run(new Pationt_choice());
        }

        private void OpenForm(object obj)
        {
            Application.Run(new Admin());
        }


        private void txt_Password_change(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "PassWord";
                txt_password.ForeColor = Color.Black;
            }
        }

        private void txt_usernameChange(object sender, EventArgs e)
        {

            if (txt_username.Text == "User Name")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
