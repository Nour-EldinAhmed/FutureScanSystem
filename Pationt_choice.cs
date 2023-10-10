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
    public partial class Pationt_choice : Form
    {
        Thread thread;
        public Pationt_choice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenAnthorForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenAnthorForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }
        private void OpenAnthorForm(object obj)
        {
            Application.Run(new Cash());
        }
        private void OpenForm(object obj)
        {
            Application.Run(new Company());
        }
    }
}
