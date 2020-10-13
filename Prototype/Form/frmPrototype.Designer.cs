namespace Prototype
{
    partial class frmPrototype
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
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPunchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColDepartment,
            this.ColWorkId,
            this.ColPosition,
            this.ColDate,
            this.ColTime,
            this.ColPunchTime,
            this.ColResult,
            this.ColLocation,
            this.ColNote});
            this.dgvAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAttendance.Location = new System.Drawing.Point(31, 111);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(1196, 489);
            this.dgvAttendance.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(818, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 25);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1152, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(31, 72);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 25);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "AttendanceId";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.Visible = false;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.Width = 68;
            // 
            // ColDepartment
            // 
            this.ColDepartment.DataPropertyName = "Department";
            this.ColDepartment.HeaderText = "Department";
            this.ColDepartment.Name = "ColDepartment";
            this.ColDepartment.Width = 102;
            // 
            // ColWorkId
            // 
            this.ColWorkId.DataPropertyName = "WorkId";
            this.ColWorkId.HeaderText = "Work Id";
            this.ColWorkId.Name = "ColWorkId";
            this.ColWorkId.Width = 79;
            // 
            // ColPosition
            // 
            this.ColPosition.DataPropertyName = "Position";
            this.ColPosition.HeaderText = "Postion";
            this.ColPosition.Name = "ColPosition";
            this.ColPosition.Width = 76;
            // 
            // ColDate
            // 
            this.ColDate.DataPropertyName = "AttendanceDate";
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.Width = 60;
            // 
            // ColTime
            // 
            this.ColTime.DataPropertyName = "AttendanceTime";
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.Width = 61;
            // 
            // ColPunchTime
            // 
            this.ColPunchTime.DataPropertyName = "PunchTime";
            this.ColPunchTime.HeaderText = "Punch Time";
            this.ColPunchTime.Name = "ColPunchTime";
            this.ColPunchTime.Width = 99;
            // 
            // ColResult
            // 
            this.ColResult.DataPropertyName = "Result";
            this.ColResult.HeaderText = "Result";
            this.ColResult.Name = "ColResult";
            this.ColResult.Width = 68;
            // 
            // ColLocation
            // 
            this.ColLocation.DataPropertyName = "AttendanceLocation";
            this.ColLocation.HeaderText = "Location";
            this.ColLocation.Name = "ColLocation";
            this.ColLocation.Width = 82;
            // 
            // ColNote
            // 
            this.ColNote.DataPropertyName = "Note";
            this.ColNote.HeaderText = "Note";
            this.ColNote.Name = "ColNote";
            this.ColNote.Width = 62;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(112, 76);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(36, 17);
            this.lblPath.TabIndex = 7;
            this.lblPath.Text = "Path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(154, 72);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(1073, 25);
            this.txtPath.TabIndex = 8;
            // 
            // frmPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 637);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAttendance);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrototype";
            this.Text = "J&T Express Inc. - Attendance Monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWorkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPunchTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNote;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
    }
}

