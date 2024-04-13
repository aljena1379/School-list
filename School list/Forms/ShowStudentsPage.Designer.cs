using School_list.Forms;

namespace School_list
{
    partial class formShowStudents
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
            this.lblNaturalIdNumber = new System.Windows.Forms.Label();
            this.btnShowIndividual = new System.Windows.Forms.Button();
            this.txtNaturalIdNumber = new System.Windows.Forms.TextBox();
            this.grpbxShowIndividual = new System.Windows.Forms.GroupBox();
            this.classNumber = new System.Windows.Forms.Label();
            this.lblClassNumer = new System.Windows.Forms.Label();
            this.fatherName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpbxShowByClass = new System.Windows.Forms.GroupBox();
            this.txtClassNumberSearch = new System.Windows.Forms.TextBox();
            this.btnShowByClass = new System.Windows.Forms.Button();
            this.lblClassNumberSearch = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblShowAll = new System.Windows.Forms.Label();
            this.grpbxShowIndividual.SuspendLayout();
            this.grpbxShowByClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaturalIdNumber
            // 
            this.lblNaturalIdNumber.AutoSize = true;
            this.lblNaturalIdNumber.Location = new System.Drawing.Point(95, 26);
            this.lblNaturalIdNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNaturalIdNumber.Name = "lblNaturalIdNumber";
            this.lblNaturalIdNumber.Size = new System.Drawing.Size(199, 23);
            this.lblNaturalIdNumber.TabIndex = 0;
            this.lblNaturalIdNumber.Text = "Natural ID Number:";
            // 
            // btnShowIndividual
            // 
            this.btnShowIndividual.Location = new System.Drawing.Point(238, 59);
            this.btnShowIndividual.Name = "btnShowIndividual";
            this.btnShowIndividual.Size = new System.Drawing.Size(83, 31);
            this.btnShowIndividual.TabIndex = 1;
            this.btnShowIndividual.Text = "Show";
            this.btnShowIndividual.UseVisualStyleBackColor = true;
            this.btnShowIndividual.Click += new System.EventHandler(this.btnShowIndividual_Click);
            // 
            // txtNaturalIdNumber
            // 
            this.txtNaturalIdNumber.Location = new System.Drawing.Point(336, 23);
            this.txtNaturalIdNumber.Name = "txtNaturalIdNumber";
            this.txtNaturalIdNumber.Size = new System.Drawing.Size(224, 30);
            this.txtNaturalIdNumber.TabIndex = 2;
            // 
            // grpbxShowIndividual
            // 
            this.grpbxShowIndividual.Controls.Add(this.classNumber);
            this.grpbxShowIndividual.Controls.Add(this.lblClassNumer);
            this.grpbxShowIndividual.Controls.Add(this.fatherName);
            this.grpbxShowIndividual.Controls.Add(this.lblFatherName);
            this.grpbxShowIndividual.Controls.Add(this.lastName);
            this.grpbxShowIndividual.Controls.Add(this.lblLastName);
            this.grpbxShowIndividual.Controls.Add(this.firstName);
            this.grpbxShowIndividual.Controls.Add(this.lblFirstName);
            this.grpbxShowIndividual.Controls.Add(this.txtNaturalIdNumber);
            this.grpbxShowIndividual.Controls.Add(this.btnShowIndividual);
            this.grpbxShowIndividual.Controls.Add(this.lblNaturalIdNumber);
            this.grpbxShowIndividual.Location = new System.Drawing.Point(34, 12);
            this.grpbxShowIndividual.Name = "grpbxShowIndividual";
            this.grpbxShowIndividual.Size = new System.Drawing.Size(593, 230);
            this.grpbxShowIndividual.TabIndex = 3;
            this.grpbxShowIndividual.TabStop = false;
            this.grpbxShowIndividual.Text = "Show Individual";
            // 
            // classNumber
            // 
            this.classNumber.AutoSize = true;
            this.classNumber.Location = new System.Drawing.Point(261, 193);
            this.classNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.classNumber.Name = "classNumber";
            this.classNumber.Size = new System.Drawing.Size(0, 23);
            this.classNumber.TabIndex = 10;
            // 
            // lblClassNumer
            // 
            this.lblClassNumer.AutoSize = true;
            this.lblClassNumer.Location = new System.Drawing.Point(19, 193);
            this.lblClassNumer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClassNumer.Name = "lblClassNumer";
            this.lblClassNumer.Size = new System.Drawing.Size(149, 23);
            this.lblClassNumer.TabIndex = 9;
            this.lblClassNumer.Text = "Class Number:";
            // 
            // fatherName
            // 
            this.fatherName.AutoSize = true;
            this.fatherName.Location = new System.Drawing.Point(261, 161);
            this.fatherName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(0, 23);
            this.fatherName.TabIndex = 8;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(19, 161);
            this.lblFatherName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(139, 23);
            this.lblFatherName.TabIndex = 7;
            this.lblFatherName.Text = "Father Name:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(261, 128);
            this.lastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(0, 23);
            this.lastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(19, 128);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(118, 23);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(261, 96);
            this.firstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(0, 23);
            this.firstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(19, 96);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(121, 23);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // grpbxShowByClass
            // 
            this.grpbxShowByClass.Controls.Add(this.txtClassNumberSearch);
            this.grpbxShowByClass.Controls.Add(this.btnShowByClass);
            this.grpbxShowByClass.Controls.Add(this.lblClassNumberSearch);
            this.grpbxShowByClass.Location = new System.Drawing.Point(34, 259);
            this.grpbxShowByClass.Name = "grpbxShowByClass";
            this.grpbxShowByClass.Size = new System.Drawing.Size(593, 105);
            this.grpbxShowByClass.TabIndex = 4;
            this.grpbxShowByClass.TabStop = false;
            this.grpbxShowByClass.Text = "Show By Class";
            // 
            // txtClassNumberSearch
            // 
            this.txtClassNumberSearch.Location = new System.Drawing.Point(336, 29);
            this.txtClassNumberSearch.Name = "txtClassNumberSearch";
            this.txtClassNumberSearch.Size = new System.Drawing.Size(224, 30);
            this.txtClassNumberSearch.TabIndex = 5;
            // 
            // btnShowByClass
            // 
            this.btnShowByClass.Location = new System.Drawing.Point(238, 65);
            this.btnShowByClass.Name = "btnShowByClass";
            this.btnShowByClass.Size = new System.Drawing.Size(83, 31);
            this.btnShowByClass.TabIndex = 4;
            this.btnShowByClass.Text = "Show";
            this.btnShowByClass.UseVisualStyleBackColor = true;
            this.btnShowByClass.Click += new System.EventHandler(this.btnShowByClass_Click);
            // 
            // lblClassNumberSearch
            // 
            this.lblClassNumberSearch.AutoSize = true;
            this.lblClassNumberSearch.Location = new System.Drawing.Point(95, 32);
            this.lblClassNumberSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClassNumberSearch.Name = "lblClassNumberSearch";
            this.lblClassNumberSearch.Size = new System.Drawing.Size(149, 23);
            this.lblClassNumberSearch.TabIndex = 3;
            this.lblClassNumberSearch.Text = "Class Number:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(272, 400);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(83, 31);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Show";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblShowAll
            // 
            this.lblShowAll.AutoSize = true;
            this.lblShowAll.Location = new System.Drawing.Point(53, 404);
            this.lblShowAll.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowAll.Name = "lblShowAll";
            this.lblShowAll.Size = new System.Drawing.Size(192, 23);
            this.lblShowAll.TabIndex = 6;
            this.lblShowAll.Text = "Show All Students:";
            // 
            // formShowStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 455);
            this.Controls.Add(this.lblShowAll);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.grpbxShowByClass);
            this.Controls.Add(this.grpbxShowIndividual);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formShowStudents";
            this.Text = "Show Students";
            this.grpbxShowIndividual.ResumeLayout(false);
            this.grpbxShowIndividual.PerformLayout();
            this.grpbxShowByClass.ResumeLayout(false);
            this.grpbxShowByClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaturalIdNumber;
        private System.Windows.Forms.Button btnShowIndividual;
        private System.Windows.Forms.TextBox txtNaturalIdNumber;
        private System.Windows.Forms.GroupBox grpbxShowIndividual;
        private System.Windows.Forms.Label classNumber;
        private System.Windows.Forms.Label lblClassNumer;
        private System.Windows.Forms.Label fatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpbxShowByClass;
        private System.Windows.Forms.TextBox txtClassNumberSearch;
        private System.Windows.Forms.Button btnShowByClass;
        private System.Windows.Forms.Label lblClassNumberSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblShowAll;
    }
}