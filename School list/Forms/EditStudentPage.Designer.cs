namespace School_list
{
    partial class formEditStudent
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
            this.txtClassNumber = new System.Windows.Forms.TextBox();
            this.lblClassNumber = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtNaturalIdNumber = new System.Windows.Forms.TextBox();
            this.lblNaturalIdNumber = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnVerifyNaturalIdNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClassNumber
            // 
            this.txtClassNumber.Enabled = false;
            this.txtClassNumber.Location = new System.Drawing.Point(269, 240);
            this.txtClassNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtClassNumber.Name = "txtClassNumber";
            this.txtClassNumber.Size = new System.Drawing.Size(298, 30);
            this.txtClassNumber.TabIndex = 21;
            // 
            // lblClassNumber
            // 
            this.lblClassNumber.AutoSize = true;
            this.lblClassNumber.Location = new System.Drawing.Point(40, 243);
            this.lblClassNumber.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblClassNumber.Name = "lblClassNumber";
            this.lblClassNumber.Size = new System.Drawing.Size(149, 23);
            this.lblClassNumber.TabIndex = 20;
            this.lblClassNumber.Text = "Class Number:";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Enabled = false;
            this.txtFatherName.Location = new System.Drawing.Point(269, 200);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(298, 30);
            this.txtFatherName.TabIndex = 19;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(40, 203);
            this.lblFatherName.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(139, 23);
            this.lblFatherName.TabIndex = 18;
            this.lblFatherName.Text = "Father Name:";
            // 
            // txtNaturalIdNumber
            // 
            this.txtNaturalIdNumber.Location = new System.Drawing.Point(269, 14);
            this.txtNaturalIdNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNaturalIdNumber.Name = "txtNaturalIdNumber";
            this.txtNaturalIdNumber.Size = new System.Drawing.Size(298, 30);
            this.txtNaturalIdNumber.TabIndex = 17;
            this.txtNaturalIdNumber.TextChanged += new System.EventHandler(this.txtNaturalIdNumber_TextChanged);
            // 
            // lblNaturalIdNumber
            // 
            this.lblNaturalIdNumber.AutoSize = true;
            this.lblNaturalIdNumber.Location = new System.Drawing.Point(40, 17);
            this.lblNaturalIdNumber.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblNaturalIdNumber.Name = "lblNaturalIdNumber";
            this.lblNaturalIdNumber.Size = new System.Drawing.Size(199, 23);
            this.lblNaturalIdNumber.TabIndex = 16;
            this.lblNaturalIdNumber.Text = "Natural ID Number:";
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(269, 160);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(298, 30);
            this.txtLastName.TabIndex = 15;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(40, 163);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(118, 23);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(269, 120);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(298, 30);
            this.txtFirstName.TabIndex = 13;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Enabled = false;
            this.btnEditStudent.Location = new System.Drawing.Point(206, 305);
            this.btnEditStudent.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(111, 38);
            this.btnEditStudent.TabIndex = 12;
            this.btnEditStudent.Text = "Edit";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(37, 123);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(121, 23);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnVerifyNaturalIdNumber
            // 
            this.btnVerifyNaturalIdNumber.Location = new System.Drawing.Point(206, 58);
            this.btnVerifyNaturalIdNumber.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.btnVerifyNaturalIdNumber.Name = "btnVerifyNaturalIdNumber";
            this.btnVerifyNaturalIdNumber.Size = new System.Drawing.Size(111, 35);
            this.btnVerifyNaturalIdNumber.TabIndex = 24;
            this.btnVerifyNaturalIdNumber.Text = "Verify";
            this.btnVerifyNaturalIdNumber.UseVisualStyleBackColor = true;
            this.btnVerifyNaturalIdNumber.Click += new System.EventHandler(this.btnVerifyNaturalIdNumber_Click);
            // 
            // formEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 432);
            this.Controls.Add(this.btnVerifyNaturalIdNumber);
            this.Controls.Add(this.txtClassNumber);
            this.Controls.Add(this.lblClassNumber);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.txtNaturalIdNumber);
            this.Controls.Add(this.lblNaturalIdNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formEditStudent";
            this.Text = "Edit Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassNumber;
        private System.Windows.Forms.Label lblClassNumber;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.TextBox txtNaturalIdNumber;
        private System.Windows.Forms.Label lblNaturalIdNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnVerifyNaturalIdNumber;
    }
}