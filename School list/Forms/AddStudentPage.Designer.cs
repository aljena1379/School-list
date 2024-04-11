namespace School_list
{
    partial class formAddStudent
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtNaturalIdNumber = new System.Windows.Forms.TextBox();
            this.lblNaturalIdNumber = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtClassNumber = new System.Windows.Forms.TextBox();
            this.lblClassNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1110, 145);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 30);
            this.textBox1.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(36, 31);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(121, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(225, 308);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(113, 41);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(244, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(301, 30);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(244, 81);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(301, 30);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(36, 81);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(118, 23);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // txtNaturalIdNumber
            // 
            this.txtNaturalIdNumber.Location = new System.Drawing.Point(244, 129);
            this.txtNaturalIdNumber.Name = "txtNaturalIdNumber";
            this.txtNaturalIdNumber.Size = new System.Drawing.Size(301, 30);
            this.txtNaturalIdNumber.TabIndex = 6;
            // 
            // lblNaturalIdNumber
            // 
            this.lblNaturalIdNumber.AutoSize = true;
            this.lblNaturalIdNumber.Location = new System.Drawing.Point(36, 132);
            this.lblNaturalIdNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNaturalIdNumber.Name = "lblNaturalIdNumber";
            this.lblNaturalIdNumber.Size = new System.Drawing.Size(199, 23);
            this.lblNaturalIdNumber.TabIndex = 5;
            this.lblNaturalIdNumber.Text = "Natural ID Number:";
            this.lblNaturalIdNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(244, 182);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(301, 30);
            this.txtFatherName.TabIndex = 8;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(36, 182);
            this.lblFatherName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(139, 23);
            this.lblFatherName.TabIndex = 7;
            this.lblFatherName.Text = "Father Name:";
            this.lblFatherName.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtClassNumber
            // 
            this.txtClassNumber.Location = new System.Drawing.Point(244, 234);
            this.txtClassNumber.Name = "txtClassNumber";
            this.txtClassNumber.Size = new System.Drawing.Size(301, 30);
            this.txtClassNumber.TabIndex = 10;
            // 
            // lblClassNumber
            // 
            this.lblClassNumber.AutoSize = true;
            this.lblClassNumber.Location = new System.Drawing.Point(36, 234);
            this.lblClassNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClassNumber.Name = "lblClassNumber";
            this.lblClassNumber.Size = new System.Drawing.Size(149, 23);
            this.lblClassNumber.TabIndex = 9;
            this.lblClassNumber.Text = "Class Number:";
            // 
            // formAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 401);
            this.Controls.Add(this.txtClassNumber);
            this.Controls.Add(this.lblClassNumber);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.txtNaturalIdNumber);
            this.Controls.Add(this.lblNaturalIdNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formAddStudent";
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtNaturalIdNumber;
        private System.Windows.Forms.Label lblNaturalIdNumber;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.TextBox txtClassNumber;
        private System.Windows.Forms.Label lblClassNumber;
    }
}