namespace FutureScan
{
    partial class EditEmployee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_nameemp = new System.Windows.Forms.TextBox();
            this.txt_passemp = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_emp = new System.Windows.Forms.Button();
            this.updata_emp = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.delete_emp = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 239);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.data_grid);
            this.dataGridView1.Click += new System.EventHandler(this.EditEmp);
            // 
            // txt_nameemp
            // 
            this.txt_nameemp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_nameemp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameemp.Location = new System.Drawing.Point(71, 122);
            this.txt_nameemp.Multiline = true;
            this.txt_nameemp.Name = "txt_nameemp";
            this.txt_nameemp.Size = new System.Drawing.Size(266, 39);
            this.txt_nameemp.TabIndex = 17;
            this.txt_nameemp.Tag = "";
            this.txt_nameemp.Text = "User Name";
            // 
            // txt_passemp
            // 
            this.txt_passemp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_passemp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passemp.Location = new System.Drawing.Point(71, 198);
            this.txt_passemp.Multiline = true;
            this.txt_passemp.Name = "txt_passemp";
            this.txt_passemp.Size = new System.Drawing.Size(266, 39);
            this.txt_passemp.TabIndex = 18;
            this.txt_passemp.Tag = "";
            this.txt_passemp.Text = "User Name";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(71, 61);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(266, 39);
            this.txt_id.TabIndex = 23;
            this.txt_id.Tag = "";
            this.txt_id.Text = "ID";
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FutureScan.Properties.Resources._5;
            this.pictureBox1.Location = new System.Drawing.Point(9, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 39);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // add_emp
            // 
            this.add_emp.BackColor = System.Drawing.Color.White;
            this.add_emp.BackgroundImage = global::FutureScan.Properties.Resources._0;
            this.add_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_emp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_emp.Location = new System.Drawing.Point(62, 409);
            this.add_emp.Name = "add_emp";
            this.add_emp.Size = new System.Drawing.Size(181, 53);
            this.add_emp.TabIndex = 22;
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
            this.updata_emp.Location = new System.Drawing.Point(412, 409);
            this.updata_emp.Name = "updata_emp";
            this.updata_emp.Size = new System.Drawing.Size(181, 53);
            this.updata_emp.TabIndex = 21;
            this.updata_emp.Text = "Update";
            this.updata_emp.UseVisualStyleBackColor = false;
            this.updata_emp.Click += new System.EventHandler(this.updata_emp_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FutureScan.Properties.Resources.lock1;
            this.pictureBox3.Location = new System.Drawing.Point(9, 198);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 39);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FutureScan.Properties.Resources.profile2;
            this.pictureBox2.Location = new System.Drawing.Point(9, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 39);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // delete_emp
            // 
            this.delete_emp.BackColor = System.Drawing.Color.White;
            this.delete_emp.BackgroundImage = global::FutureScan.Properties.Resources._0;
            this.delete_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_emp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_emp.Location = new System.Drawing.Point(788, 409);
            this.delete_emp.Name = "delete_emp";
            this.delete_emp.Size = new System.Drawing.Size(181, 53);
            this.delete_emp.TabIndex = 13;
            this.delete_emp.Text = "Delete";
            this.delete_emp.UseVisualStyleBackColor = false;
            this.delete_emp.Click += new System.EventHandler(this.delete_emp_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FutureScan.Properties.Resources.keyboard_backspace11;
            this.pictureBox4.Location = new System.Drawing.Point(3, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 24);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1066, 564);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.add_emp);
            this.Controls.Add(this.updata_emp);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_passemp);
            this.Controls.Add(this.txt_nameemp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_emp);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.Load += new System.EventHandler(this.EditEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete_emp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_nameemp;
        private System.Windows.Forms.TextBox txt_passemp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button updata_emp;
        private System.Windows.Forms.Button add_emp;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}