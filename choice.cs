using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace FutureScan
{
    public partial class choice : Form
    {
        Thread thread;
        public choice()
        {
            InitializeComponent();
        }

        private void choice_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void OpenForm(object obj)
        {
            Application.Run(new Edit_Patients());
        }
        private void OpenAnatherForm(object obj)
        {
            Application.Run(new EditEmployee());
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenAnatherForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
