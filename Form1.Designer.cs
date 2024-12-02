namespace _505064_MuhammadBudiSetiawan_ResponsiJuniorProject
{
    partial class Form1
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
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_empName = new System.Windows.Forms.Label();
            this.tb_empName = new System.Windows.Forms.TextBox();
            this.lbl_empDept = new System.Windows.Forms.Label();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_logo
            // 
            this.pb_logo.Location = new System.Drawing.Point(12, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(100, 100);
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Location = new System.Drawing.Point(118, 58);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(95, 13);
            this.lbl_logo.TabIndex = 1;
            this.lbl_logo.Text = "PT Berdikari Terus";
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Location = new System.Drawing.Point(12, 118);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(85, 13);
            this.lbl_empName.TabIndex = 2;
            this.lbl_empName.Text = "Nama Karyawan";
            this.lbl_empName.Click += new System.EventHandler(this.lbl_empName_Click);
            // 
            // tb_empName
            // 
            this.tb_empName.Location = new System.Drawing.Point(121, 115);
            this.tb_empName.Name = "tb_empName";
            this.tb_empName.Size = new System.Drawing.Size(312, 20);
            this.tb_empName.TabIndex = 3;
            this.tb_empName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_empDept
            // 
            this.lbl_empDept.AutoSize = true;
            this.lbl_empDept.Location = new System.Drawing.Point(12, 151);
            this.lbl_empDept.Name = "lbl_empDept";
            this.lbl_empDept.Size = new System.Drawing.Size(65, 13);
            this.lbl_empDept.TabIndex = 4;
            this.lbl_empDept.Text = "Departemen";
            // 
            // cb_dept
            // 
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Items.AddRange(new object[] {
            "HR",
            "ENG",
            "DEV",
            "PM",
            "FIN"});
            this.cb_dept.Location = new System.Drawing.Point(121, 148);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(312, 21);
            this.cb_dept.TabIndex = 5;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 185);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(121, 185);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(237, 185);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 214);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(421, 174);
            this.dgv.TabIndex = 9;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(468, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(122, 132);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "ID Departemen\nHR: HR\nENG: Engineer\nDEV: Developer\nPM: Product Manager\nFIN: Financ" +
    "e";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.cb_dept);
            this.Controls.Add(this.lbl_empDept);
            this.Controls.Add(this.tb_empName);
            this.Controls.Add(this.lbl_empName);
            this.Controls.Add(this.lbl_logo);
            this.Controls.Add(this.pb_logo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label lbl_empName;
        private System.Windows.Forms.TextBox tb_empName;
        private System.Windows.Forms.Label lbl_empDept;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

