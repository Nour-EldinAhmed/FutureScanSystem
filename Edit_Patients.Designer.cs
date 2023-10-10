namespace FutureScan
{
    partial class Edit_Patients
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_emp = new System.Windows.Forms.Button();
            this.updata_emp = new System.Windows.Forms.Button();
            this.delete_emp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_cash = new System.Windows.Forms.TextBox();
            this.txt_exam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(93, 89);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(266, 39);
            this.txt_name.TabIndex = 33;
            this.txt_name.Tag = "";
            // 
            // txt_age
            // 
            this.txt_age.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_age.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(93, 150);
            this.txt_age.Multiline = true;
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(266, 39);
            this.txt_age.TabIndex = 27;
            this.txt_age.Tag = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(397, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 383);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.Data_Grid);
            // 
            // add_emp
            // 
            this.add_emp.BackColor = System.Drawing.Color.White;
            this.add_emp.BackgroundImage = global::FutureScan.Properties.Resources._0;
            this.add_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_emp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_emp.Location = new System.Drawing.Point(178, 514);
            this.add_emp.Name = "add_emp";
            this.add_emp.Size = new System.Drawing.Size(181, 53);
            this.add_emp.TabIndex = 32;
            this.add_emp.Text = "Add";
            this.add_emp.UseVisualStyleBackColor = false;
            this.add_emp.Click += new System.EventHandler(this.add_emp_Click);
            // 
            // updata_emp
            // 
            this.updata_emp.BackColor = System.Drawing.Color.White;
            this.updata_emp.BackgroundImage = global::FutureScan.Properties.Resources._0;
            this.updata_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updata_emp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updata_emp.Location = new System.Drawing.Point(540, 514);
            this.updata_emp.Name = "updata_emp";
            this.updata_emp.Size = new System.Drawing.Size(181, 53);
            this.updata_emp.TabIndex = 31;
            this.updata_emp.Text = "Update";
            this.updata_emp.UseVisualStyleBackColor = false;
            this.updata_emp.Click += new System.EventHandler(this.updata_emp_Click);
            // 
            // delete_emp
            // 
            this.delete_emp.BackColor = System.Drawing.Color.White;
            this.delete_emp.BackgroundImage = global::FutureScan.Properties.Resources._0;
            this.delete_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_emp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_emp.Location = new System.Drawing.Point(987, 514);
            this.delete_emp.Name = "delete_emp";
            this.delete_emp.Size = new System.Drawing.Size(181, 53);
            this.delete_emp.TabIndex = 25;
            this.delete_emp.Text = "Delete";
            this.delete_emp.UseVisualStyleBackColor = false;
            this.delete_emp.Click += new System.EventHandler(this.delete_emp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Exam";
            // 
            // txt_discount
            // 
            this.txt_discount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_discount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(100, 433);
            this.txt_discount.Multiline = true;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(266, 39);
            this.txt_discount.TabIndex = 42;
            this.txt_discount.Tag = "";
            // 
            // txt_cash
            // 
            this.txt_cash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_cash.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cash.Location = new System.Drawing.Point(93, 359);
            this.txt_cash.Multiline = true;
            this.txt_cash.Name = "txt_cash";
            this.txt_cash.Size = new System.Drawing.Size(266, 39);
            this.txt_cash.TabIndex = 43;
            this.txt_cash.Tag = "";
            // 
            // txt_exam
            // 
            this.txt_exam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_exam.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exam.Location = new System.Drawing.Point(93, 296);
            this.txt_exam.Multiline = true;
            this.txt_exam.Name = "txt_exam";
            this.txt_exam.Size = new System.Drawing.Size(266, 39);
            this.txt_exam.TabIndex = 46;
            this.txt_exam.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 49;
            this.label4.Text = "Cash";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 52;
            this.label7.Text = "Age";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 22);
            this.label8.TabIndex = 53;
            this.label8.Text = "Phone";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(93, 226);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(266, 39);
            this.txt_phone.TabIndex = 28;
            this.txt_phone.Tag = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FutureScan.Properties.Resources.keyboard_backspace11;
            this.pictureBox2.Location = new System.Drawing.Point(10, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 24);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(93, 34);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(266, 39);
            this.txt_id.TabIndex = 57;
            this.txt_id.Tag = "";
            // 
            // Edit_Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 603);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_exam);
            this.Controls.Add(this.txt_cash);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.add_emp);
            this.Controls.Add(this.updata_emp);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_emp);
            this.Name = "Edit_Patients";
            this.Text = "Edit_Patients";
            this.Load += new System.EventHandler(this.Edit_Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button add_emp;
        private System.Windows.Forms.Button updata_emp;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_cash;
        private System.Windows.Forms.TextBox txt_exam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
    }
}