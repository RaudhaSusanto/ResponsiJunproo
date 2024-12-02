namespace ResponsiJunproo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbKaryawan = new TextBox();
            tbDepartemen = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvKaryawan = new DataGridView();
            btnSave = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 49);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 113);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 143);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Dep. Karyawan   :";
            // 
            // tbKaryawan
            // 
            tbKaryawan.Location = new Point(134, 105);
            tbKaryawan.Name = "tbKaryawan";
            tbKaryawan.Size = new Size(154, 23);
            tbKaryawan.TabIndex = 3;
            // 
            // tbDepartemen
            // 
            tbDepartemen.Location = new Point(134, 135);
            tbDepartemen.Name = "tbDepartemen";
            tbDepartemen.Size = new Size(154, 23);
            tbDepartemen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(463, 64);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 5;
            label4.Text = "ID Departemen:";
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 94);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 7;
            label6.Text = "ENG = Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(463, 109);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 8;
            label7.Text = "DEV = Developer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(463, 124);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 9;
            label8.Text = "PM = Product M";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(463, 138);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 10;
            label9.Text = "FIN = Finance";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(26, 184);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(213, 184);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(463, 184);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Location = new Point(12, 234);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.Size = new Size(563, 204);
            dgvKaryawan.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(294, 184);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "SaveEdit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(463, 79);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 17;
            label10.Text = "HR = HR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 450);
            Controls.Add(label10);
            Controls.Add(btnSave);
            Controls.Add(dgvKaryawan);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbDepartemen);
            Controls.Add(tbKaryawan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbKaryawan;
        private TextBox tbDepartemen;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvKaryawan;
        private Button btnSave;
        private Label label10;
    }
}
