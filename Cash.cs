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
using System.Text.RegularExpressions;

namespace FutureScan
{
    public partial class Cash : Form
    {
        public String connection = "Data Source=DESKTOP-CUSJP6K;Initial Catalog=Rediolgy;Integrated Security=True";
        SqlConnection con;
       public int p;
        string name, age, phone;
        Thread thread;
        public static String  moveName,move_Price,move_Cash,move_Discount,move_rest,move_Exam;
        public String date;
        public Cash()
        {
            con = new SqlConnection(connection);
            InitializeComponent();
            ShowType();
            //showReferingDoctor();
            txt_date.Text = DateTime.Now.ToString("yyyy/MM/dd");
            date=txt_date.Text;
           
            
        }

    

        private void Save(object sender, EventArgs e)
        {
            if (txt_name.Text == " " || txt_age.Text == "" || txt_phone.Text==""||txt_phone.MaxLength==11)
            {
                MessageBox.Show("Please Enter Empty Box");
                txt_name.Focus();
            }
            
             
            else
            {
                
              
                String quary = "insert into TB_Patient values(@name,@Age,@Phone_Number,@cash,@discount,@patient_exam,@rest,@date_time,@address,@referring_doctor)";
                SqlCommand cmd = new SqlCommand(quary, con);

                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@Age", txt_age.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", txt_phone.Text);

                cmd.Parameters.AddWithValue("@cash", txt_cash.Text);
                cmd.Parameters.AddWithValue("@discount", txt_discount.Text);
                cmd.Parameters.AddWithValue("@patient_exam", combo_examination.Text);
                cmd.Parameters.AddWithValue("@rest", txt_rest.Text);
                cmd.Parameters.AddWithValue("@date_time", txt_date.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@referring_doctor", txt_doc.Text);


                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Done");
                    this.name = txt_name.Text;
                    this.age = txt_age.Text;
                    this.phone = txt_phone.Text;
                    moveName = txt_name.Text;
                    move_Cash = txt_cash.Text;
                    move_Discount=txt_discount.Text;
                    move_Price=txt_price_scan.Text;
                    move_rest = txt_rest.Text;
                    move_Exam = combo_examination.Text;

                    txt_cash.Text = "";
                    txt_discount.Text = "";
                    combo_examination.Text = "";
                    combo_type.Text = "";
                    txt_price_scan.Text = "";
                    txt_rest.Text = "";
                    txt_name.Text = "";
                    txt_phone.Text = "";
                    txt_age.Text = "";
                    txt_address.Text = "";
                    txt_doc.Text = "";
                    

                }
                else
                {
                    MessageBox.Show("False");

                }
                con.Close();
            }
        }

        private void ShowType()
        {
            con.Open();
            string Quary = "select Type from TB_Type";
            SqlCommand command = new SqlCommand(Quary, con);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                combo_type.Items.Add(sqlDataReader["Type"].ToString());
            }
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_type.SelectedIndex == 0)
            {
                con.Open();
                String quary = "select m.price from TB_MRI m  where m.name=@name";

                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.Parameters.AddWithValue("@name", combo_examination.SelectedItem.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string price = dr["price"].ToString();
                    txt_price_scan.Text = price;
                }
                con.Close();
            }if(combo_type.SelectedIndex == 1)
            {
                con.Open();
                String quary = "select x.price from  TB_XRAY x where x.name=@name";

                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.Parameters.AddWithValue("@name", combo_examination.SelectedItem.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string price = dr["price"].ToString();
                    txt_price_scan.Text = price;
                }
                con.Close();
            }if(combo_type.SelectedIndex == 2)
            {
                con.Open();
                String quary = "select u.price from TB_US u where u.name=@name";

                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.Parameters.AddWithValue("@name", combo_examination.SelectedItem.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string price = dr["price"].ToString();
                    txt_price_scan.Text = price;
                }
                con.Close();
            }


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

       /* private void showReferingDoctor()
        {
            con.Open();
            String quary = "select referring_doctor from Tb_Patient";
            SqlCommand command = new SqlCommand(quary, con);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txt_doc.Items.Add(dr["referring_doctor"].ToString());
            }
            con.Close();
        }*/
        private void combo_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

       
        /*
        private void validatePhone()
        {
               phoneNumpattern = new Regex(@"\+[0-9]{3}\s+[0-9]{3}\s+[0-9]{5}\s+[0-9]{3}");
            if (phoneNumpattern.IsMatch(txt_phone.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
        }*/

        private void txt_discount_TextChanged_1(object sender, EventArgs e)
        {
            int discount, res;
            string price = txt_price_scan.Text;
            string dis = txt_discount.Text;
            if (dis.Equals(""))
            {

                txt_rest.Text = txt_price_scan.Text;
            }
            else
            {
                discount = 0;
                p = Int32.Parse(price);
                discount = Int32.Parse(dis);
                res = p - discount;
                txt_rest.Text = res.ToString();
            }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            Regex validator = new Regex("(3|4|5|6|7|8|9){1}[0-9]{9}");
            string match = validator.Match(txt_phone.Text).Value.ToString();
            if (match.Length == 10)
            {
                label1.Text = "Valid";
            }
            else
            {
                label1.Text = "Invalid";
            }
        }

        private void combo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_type.SelectedIndex == 0)
            {

                con.Open();
                combo_examination.Items.Clear();
                string Quary = "select name from TB_MRI";
                SqlCommand command = new SqlCommand(Quary, con);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    combo_examination.Items.Add(sqlDataReader["name"].ToString());
                }

                con.Close();
            } if(combo_type.SelectedIndex == 1)
            {
                con.Open();
                combo_examination.Items.Clear();
                string Quary = "select name from TB_XRay";
                SqlCommand command = new SqlCommand(Quary, con);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    combo_examination.Items.Add(sqlDataReader["name"].ToString());
                }
                con.Close();
            }if(combo_type.SelectedIndex == 2)
            {
                con.Open();
                combo_examination.Items.Clear();

                string Quary = "select name from TB_US";
                SqlCommand command = new SqlCommand(Quary, con);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    combo_examination.Items.Add(sqlDataReader["name"].ToString());
                }
                con.Close();
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            

                int discount , res,p;
                string price = txt_price_scan.Text;
                string dis = txt_discount.Text;
            if (dis.Equals(""))
            {
                
                txt_rest.Text = txt_price_scan.Text;
            }
            else {
                discount = 0;
                p = Convert.ToInt32(price);
                discount = Int32.Parse(dis);
                res = p - discount;
                txt_rest.Text = res.ToString();
            }
                
            
        }

        private void btn_Invoice(object sender, EventArgs e)
        {

            this.Close();
            thread = new Thread(OpenAnthorForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void txt_cash_TextChanged(object sender, EventArgs e)
        {
            int c , res,p,discount;
            String cash = txt_cash.Text;
            String price = txt_price_scan.Text;
            String dis=txt_discount.Text;
            
            if (cash.Equals(" "))
            {
                txt_rest.Text = (int.Parse(price) - int.Parse(dis)).ToString();
            }
            if (cash.Equals("") || dis.Equals("")||price.Equals(""))
            {
                txt_rest.Text = txt_price_scan.Text;
                
                
                try
                {
                    dis = "0";
                    c = Int32.Parse(cash);
                    p = Int32.Parse(price);
                    discount = Int32.Parse(dis);

                    res = p - c - discount;
                    txt_rest.Text = res.ToString();


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {

                c = Int32.Parse(cash);
                p = Int32.Parse(price);
                discount = Int32.Parse(dis);
                res = p - c - discount;
                txt_rest.Text = res.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_name.Text = this.name;
            txt_age.Text = this.age;
            txt_phone.Text = this.phone;
            con.Open();

            String quary = "insert into TB_Patient values(@name,@Age,@Phone_Number,@cash,@discount,@patient_exam,@rest,@date_time,@address,@referring_doctor)";
            SqlCommand cmd = new SqlCommand(quary, con);

            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@Age", txt_age.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", txt_phone.Text);
            cmd.Parameters.AddWithValue("@cash", txt_cash.Text);
            cmd.Parameters.AddWithValue("@discount", txt_discount.Text);
            cmd.Parameters.AddWithValue("@patient_exam",combo_examination.Text);
            cmd.Parameters.AddWithValue("@rest", txt_rest.Text);
            cmd.Parameters.AddWithValue("@date_time", txt_date.Text);
           cmd.Parameters.AddWithValue("@address", txt_address.Text);
            cmd.Parameters.AddWithValue("@referring_doctor", txt_doc.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {

              

            }
            else
            {
               

            }
            con.Close();

        }
        private void OpenAnthorForm(object obj)
        {
            Application.Run(new invoice());
        }
        private void OpenForm(object obj)
        {
            Application.Run(new Number_Patients());
        }
    }
    }
/*Save s = new Save();
        s.Show();*/
