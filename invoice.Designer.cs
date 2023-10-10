namespace FutureScan
{
    partial class invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_exam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_cash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.future_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.future_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = " الفاتورة ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_date
            // 
            this.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_date.Location = new System.Drawing.Point(743, 21);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(184, 15);
            this.txt_date.TabIndex = 3;
            this.txt_date.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouse_click);
            this.txt_date.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_date);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(813, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 42);
            this.label6.TabIndex = 7;
            this.label6.Text = "الاسم ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(510, 128);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(231, 38);
            this.txt_name.TabIndex = 8;
            // 
            // txt_exam
            // 
            this.txt_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exam.Location = new System.Drawing.Point(510, 202);
            this.txt_exam.Name = "txt_exam";
            this.txt_exam.Size = new System.Drawing.Size(231, 38);
            this.txt_exam.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(799, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "الفحص";
            // 
            // txt_dis
            // 
            this.txt_dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dis.Location = new System.Drawing.Point(7, 128);
            this.txt_dis.Name = "txt_dis";
            this.txt_dis.Size = new System.Drawing.Size(231, 38);
            this.txt_dis.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(310, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 42);
            this.label4.TabIndex = 11;
            this.label4.Text = "الخصم";
            // 
            // text_cash
            // 
            this.text_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cash.Location = new System.Drawing.Point(7, 202);
            this.text_cash.Name = "text_cash";
            this.text_cash.Size = new System.Drawing.Size(231, 38);
            this.text_cash.TabIndex = 14;
            this.text_cash.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(278, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 42);
            this.label5.TabIndex = 13;
            this.label5.Text = "المبلغ المدفوع";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FutureScan.Properties.Resources.b8;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(361, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "طباعة";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // future_image
            // 
            this.future_image.Image = global::FutureScan.Properties.Resources.future;
            this.future_image.Location = new System.Drawing.Point(12, 12);
            this.future_image.Name = "future_image";
            this.future_image.Size = new System.Drawing.Size(141, 88);
            this.future_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.future_image.TabIndex = 2;
            this.future_image.TabStop = false;
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_cash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_exam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.future_image);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "invoice";
            this.Text = "invoice";
            this.Load += new System.EventHandler(this.invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.future_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox future_image;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_exam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_cash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}