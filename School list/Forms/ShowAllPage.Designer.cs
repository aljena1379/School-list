namespace School_list
{
    partial class formShow
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
            this.components = new System.ComponentModel.Container();
            this.dgvShowAll = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_DBDataSet = new School_list.School_DBDataSet();
            this.studentsTableAdapter = new School_list.School_DBDataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowAll
            // 
            this.dgvShowAll.AllowUserToAddRows = false;
            this.dgvShowAll.AllowUserToDeleteRows = false;
            this.dgvShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAll.Location = new System.Drawing.Point(14, 13);
            this.dgvShowAll.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvShowAll.Name = "dgvShowAll";
            this.dgvShowAll.ReadOnly = true;
            this.dgvShowAll.Size = new System.Drawing.Size(818, 453);
            this.dgvShowAll.TabIndex = 0;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.school_DBDataSet;
            // 
            // school_DBDataSet
            // 
            this.school_DBDataSet.DataSetName = "School_DBDataSet";
            this.school_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // formShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 479);
            this.Controls.Add(this.dgvShowAll);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "formShow";
            this.Text = "Show Students";
            this.Load += new System.EventHandler(this.frmShowAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowAll;
        private School_DBDataSet school_DBDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private School_DBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}