using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureScan
{
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
        }

        private void invoice_Load(object sender, EventArgs e)
        {
            txt_date.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txt_name.Text = Cash.moveName;
            txt_exam.Text = Cash.move_Exam;
            txt_dis.Text = Cash.move_Discount;
            text_cash.Text = Cash.move_Cash;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void key_press_date(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mouse_click(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                txt_date.ContextMenu = new ContextMenu();
            }else if(e.Button == MouseButtons.Left)
            {
                txt_date.ContextMenu= new ContextMenu();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 55;
            float m = 85;
            Font f=new Font("Arial",22,FontStyle.Bold);
            String text_date="التاريخ: "+ txt_date.Text;
            String text_name = "الفاتورة" ;
            String txt_examination = " : الفحص " + txt_exam.Text;
            String txt_Name= txt_name.Text+ "  : الاسم" ;

            SizeF s_exam=e.Graphics.MeasureString(txt_examination,f);
            SizeF s_name = e.Graphics.MeasureString(txt_Name, f);
            SizeF size_date = e.Graphics.MeasureString(text_date,f);
            SizeF size = e.Graphics.MeasureString(text_name,f);

            e.Graphics.DrawImage(Properties.Resources.future, margin, margin, 200, 200);
            e.Graphics.DrawString(text_name, f, Brushes.Red, (e.PageBounds.Width - size.Width) / 2, margin);
            e.Graphics.DrawString(text_date, f, Brushes.Red, e.PageBounds.Width - size_date.Width-margin, margin+size.Height);
            e.Graphics.DrawString(txt_Name, f, Brushes.Navy, e.PageBounds.Width - s_name.Width- margin, m + size_date.Height+size.Height);
            float square=margin+size.Height + size_date.Height+s_name.Height+100;
            e.Graphics.DrawRectangle(Pens.Black, margin, square,e.PageBounds.Width-margin*2,e.PageBounds.Height-margin*2-square);
            e.Graphics.DrawString(txt_examination, f, Brushes.Red, e.PageBounds.Width - 175, margin - s_name.Height+square);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
