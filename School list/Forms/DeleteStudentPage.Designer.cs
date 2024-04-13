using School_list.Forms;

namespace School_list
{
    partial class formDeleteStudent
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
            this.btnVerifyNaturalIdNumber = new System.Windows.Forms.Button();
            this.lblNaturalIdNumber = new System.Windows.Forms.Label();
            this.txtNaturalIdNumber = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.fatherName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.classNumber = new System.Windows.Forms.Label();
            this.lblClassNumber = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerifyNaturalIdNumber
            // 
            this.btnVerifyNaturalIdNumber.Location = new System.Drawing.Point(265, 71);
            this.btnVerifyNaturalIdNumber.Name = "btnVerifyNaturalIdNumber";
            this.btnVerifyNaturalIdNumber.Size = new System.Drawing.Size(94, 43);
            this.btnVerifyNaturalIdNumber.TabIndex = 0;
            this.btnVerifyNaturalIdNumber.Text = "Verify";
            this.btnVerifyNaturalIdNumber.UseVisualStyleBackColor = true;
            this.btnVerifyNaturalIdNumber.Click += new System.EventHandler(this.btnVerifyNaturalIdNumber_Click);
            this.btnVerifyNaturalIdNumber.MouseEnter += new System.EventHandler(CosmeticAnimations.ButtonsMouseEnter);
            this.btnVerifyNaturalIdNumber.MouseLeave += new System.EventHandler(CosmeticAnimations.ButtonsMouseLeave);
            // 
            // lblNaturalIdNumber
            // 
            this.lblNaturalIdNumber.AutoSize = true;
            this.lblNaturalIdNumber.Location = new System.Drawing.Point(87, 19);
            this.lblNaturalIdNumber.Name = "lblNaturalIdNumber";
            this.lblNaturalIdNumber.Size = new System.Drawing.Size(199, 23);
            this.lblNaturalIdNumber.TabIndex = 1;
            this.lblNaturalIdNumber.Text = "Natural ID Number:";
            // 
            // txtNaturalIdNumber
            // 
            this.txtNaturalIdNumber.Location = new System.Drawing.Point(339, 16);
            this.txtNaturalIdNumber.Name = "txtNaturalIdNumber";
            this.txtNaturalIdNumber.Size = new System.Drawing.Size(174, 30);
            this.txtNaturalIdNumber.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(87, 142);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(121, 23);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(316, 142);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(0, 23);
            this.firstName.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(316, 175);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(0, 23);
            this.lastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(87, 175);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(118, 23);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // fatherName
            // 
            this.fatherName.AutoSize = true;
            this.fatherName.Location = new System.Drawing.Point(316, 213);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(0, 23);
            this.fatherName.TabIndex = 8;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(87, 213);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(139, 23);
            this.lblFatherName.TabIndex = 7;
            this.lblFatherName.Text = "Father Name:";
            // 
            // classNumber
            // 
            this.classNumber.AutoSize = true;
            this.classNumber.Location = new System.Drawing.Point(316, 249);
            this.classNumber.Name = "classNumber";
            this.classNumber.Size = new System.Drawing.Size(0, 23);
            this.classNumber.TabIndex = 10;
            // 
            // lblClassNumber
            // 
            this.lblClassNumber.AutoSize = true;
            this.lblClassNumber.Location = new System.Drawing.Point(87, 249);
            this.lblClassNumber.Name = "lblClassNumber";
            this.lblClassNumber.Size = new System.Drawing.Size(149, 23);
            this.lblClassNumber.TabIndex = 9;
            this.lblClassNumber.Text = "Class Number:";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(277, 312);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 43);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(CosmeticAnimations.ButtonsMouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(CosmeticAnimations.ButtonsMouseLeave);
            // 
            // formDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 428);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.classNumber);
            this.Controls.Add(this.lblClassNumber);
            this.Controls.Add(this.fatherName);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtNaturalIdNumber);
            this.Controls.Add(this.lblNaturalIdNumber);
            this.Controls.Add(this.btnVerifyNaturalIdNumber);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formDeleteStudent";
            this.Text = "Delete Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerifyNaturalIdNumber;
        private System.Windows.Forms.Label lblNaturalIdNumber;
        private System.Windows.Forms.TextBox txtNaturalIdNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label fatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label classNumber;
        private System.Windows.Forms.Label lblClassNumber;
        private System.Windows.Forms.Button btnDelete;
    }
}