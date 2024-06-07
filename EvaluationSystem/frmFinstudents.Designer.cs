namespace EvaluationSystem
{
    partial class frmFinstudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinstudents));
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddGrades = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtgList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label2.Location = new System.Drawing.Point(679, 96);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 20);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Search :";
            // 
            // TextBox1
            // 
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(768, 92);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(404, 26);
            this.TextBox1.TabIndex = 15;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1049, 567);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 38);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddGrades
            // 
            this.btnAddGrades.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrades.Location = new System.Drawing.Point(867, 567);
            this.btnAddGrades.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGrades.Name = "btnAddGrades";
            this.btnAddGrades.Size = new System.Drawing.Size(175, 38);
            this.btnAddGrades.TabIndex = 14;
            this.btnAddGrades.Text = "Print Curriculum";
            this.btnAddGrades.UseVisualStyleBackColor = true;
            this.btnAddGrades.Click += new System.EventHandler(this.btnAddGrades_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(17, 14);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(432, 45);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Search for Students";
            // 
            // dtgList
            // 
            this.dtgList.AllowUserToAddRows = false;
            this.dtgList.AllowUserToDeleteRows = false;
            this.dtgList.AllowUserToResizeColumns = false;
            this.dtgList.AllowUserToResizeRows = false;
            this.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgList.Location = new System.Drawing.Point(17, 128);
            this.dtgList.Margin = new System.Windows.Forms.Padding(4);
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersWidth = 51;
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(1156, 432);
            this.dtgList.TabIndex = 11;
            // 
            // frmFinstudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 618);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddGrades);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dtgList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFinstudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Students Form";
            this.Load += new System.EventHandler(this.frmFinstudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnAddGrades;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dtgList;
    }
}