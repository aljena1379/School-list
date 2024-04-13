using School_list.Forms;

namespace School_list
{
    partial class formMain
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHeader.Location = new System.Drawing.Point(155, 52);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(547, 33);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Management Of Students List of School";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.LightGray;
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Location = new System.Drawing.Point(93, 143);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(201, 73);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            this.btnAddStudent.MouseEnter += new System.EventHandler(CosmeticAnimations.ButtonsMouseEnter);
            this.btnAddStudent.MouseLeave += new System.EventHandler(CosmeticAnimations.ButtonsMouseLeave);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.BackColor = System.Drawing.Color.LightGray;
            this.btnEditStudent.ForeColor = System.Drawing.Color.Black;
            this.btnEditStudent.Location = new System.Drawing.Point(330, 143);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(201, 73);
            this.btnEditStudent.TabIndex = 2;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            this.btnEditStudent.MouseEnter += new System.EventHandler(CosmeticAnimations.ButtonsMouseEnter);
            this.btnEditStudent.MouseLeave += new System.EventHandler(CosmeticAnimations.ButtonsMouseLeave);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.BackColor = System.Drawing.Color.LightGray;
            this.btnShowStudents.ForeColor = System.Drawing.Color.Black;
            this.btnShowStudents.Location = new System.Drawing.Point(286, 236);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(291, 73);
            this.btnShowStudents.TabIndex = 3;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = false;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            this.btnShowStudents.MouseEnter += new System.EventHandler(CosmeticAnimations.ButtonsMouseEnter);
            this.btnShowStudents.MouseLeave += new System.EventHandler(CosmeticAnimations.ButtonsMouseLeave);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.LightGray;
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteStudent.Location = new System.Drawing.Point(570, 143);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(201, 73);
            this.btnDeleteStudent.TabIndex = 4;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            this.btnDeleteStudent.MouseEnter += new System.EventHandler(CosmeticAnimations.ButtonsMouseEnter);
            this.btnDeleteStudent.MouseLeave += new System.EventHandler(CosmeticAnimations.ButtonsMouseLeave);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 401);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnDeleteStudent;
    }
}

