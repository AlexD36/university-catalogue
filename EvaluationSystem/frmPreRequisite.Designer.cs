namespace EvaluationSystem
{
    partial class frmPreRequisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreRequisite));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.RichTextBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtPreRequisite = new System.Windows.Forms.RichTextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(111, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(638, 23);
            this.txtSearch.TabIndex = 64;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtdesc
            // 
            this.txtdesc.Enabled = false;
            this.txtdesc.Location = new System.Drawing.Point(156, 71);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(336, 74);
            this.txtdesc.TabIndex = 15;
            this.txtdesc.Text = "";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label11);
            this.GroupBox4.Controls.Add(this.txtSearch);
            this.GroupBox4.Controls.Add(this.dtgList);
            this.GroupBox4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBox4.Location = new System.Drawing.Point(17, 76);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Size = new System.Drawing.Size(760, 560);
            this.GroupBox4.TabIndex = 71;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "List of Subject";
            this.GroupBox4.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label11.Location = new System.Drawing.Point(10, 25);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(66, 16);
            this.Label11.TabIndex = 65;
            this.Label11.Text = "Search :";
            this.Label11.Click += new System.EventHandler(this.Label11_Click);
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
            this.dtgList.Location = new System.Drawing.Point(9, 62);
            this.dtgList.Margin = new System.Windows.Forms.Padding(4);
            this.dtgList.MultiSelect = false;
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersVisible = false;
            this.dtgList.RowHeadersWidth = 51;
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(742, 492);
            this.dtgList.TabIndex = 63;
            this.dtgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgList_CellClick);
            // 
            // txtSubject
            // 
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Enabled = false;
            this.txtSubject.Location = new System.Drawing.Point(156, 39);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(336, 23);
            this.txtSubject.TabIndex = 20;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(93, 157);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(50, 16);
            this.Label13.TabIndex = 18;
            this.Label13.Text = "Year :";
            this.Label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(14, 75);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(133, 16);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Descriptive Title :";
            // 
            // txtSemester
            // 
            this.txtSemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSemester.Enabled = false;
            this.txtSemester.Location = new System.Drawing.Point(156, 186);
            this.txtSemester.Margin = new System.Windows.Forms.Padding(4);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(188, 23);
            this.txtSemester.TabIndex = 17;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(57, 189);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(86, 16);
            this.Label14.TabIndex = 19;
            this.Label14.Text = "Semester :";
            this.Label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(156, 154);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(188, 23);
            this.txtYear.TabIndex = 16;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtSubject);
            this.GroupBox3.Controls.Add(this.txtdesc);
            this.GroupBox3.Controls.Add(this.Label13);
            this.GroupBox3.Controls.Add(this.Label7);
            this.GroupBox3.Controls.Add(this.txtSemester);
            this.GroupBox3.Controls.Add(this.Label14);
            this.GroupBox3.Controls.Add(this.txtYear);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBox3.Location = new System.Drawing.Point(786, 76);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(549, 233);
            this.GroupBox3.TabIndex = 70;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Subject Details";
            this.GroupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(52, 42);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 16);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Course No. :";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.Gray;
            this.Label15.Location = new System.Drawing.Point(12, 20);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(407, 54);
            this.Label15.TabIndex = 59;
            this.Label15.Text = "Input Course No. inside the box.\r\nAdd a comma(,) if more than  1 pre requisite. T" +
    "ype it \r\ncorrectly. ex. it101,it102";
            this.Label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // txtPreRequisite
            // 
            this.txtPreRequisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreRequisite.Location = new System.Drawing.Point(9, 86);
            this.txtPreRequisite.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreRequisite.Name = "txtPreRequisite";
            this.txtPreRequisite.Size = new System.Drawing.Size(529, 170);
            this.txtPreRequisite.TabIndex = 60;
            this.txtPreRequisite.Text = "";
            this.txtPreRequisite.TextChanged += new System.EventHandler(this.txtPreRequisite_TextChanged);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label12.Location = new System.Drawing.Point(474, 10);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(382, 57);
            this.Label12.TabIndex = 68;
            this.Label12.Text = "Pre-Requisite";
            this.Label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label15);
            this.GroupBox2.Controls.Add(this.txtPreRequisite);
            this.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBox2.Location = new System.Drawing.Point(786, 316);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(549, 265);
            this.GroupBox2.TabIndex = 69;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Pre-Requisite";
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(1065, 588);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 33);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Location = new System.Drawing.Point(1207, 588);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 33);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPreRequisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 645);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPreRequisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pre-Requisite Form";
            this.Load += new System.EventHandler(this.frmPreRequisite_Load);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.RichTextBox txtdesc;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.DataGridView dtgList;
        internal System.Windows.Forms.TextBox txtSubject;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtSemester;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox txtYear;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.RichTextBox txtPreRequisite;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClose;
    }
}