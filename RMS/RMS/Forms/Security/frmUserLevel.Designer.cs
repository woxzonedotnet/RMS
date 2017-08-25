namespace RMS.Forms.Security
{
    partial class frmUserLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLevel));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtUserLevelCode = new System.Windows.Forms.TextBox();
            this.lblUserLevelCode = new System.Windows.Forms.Label();
            this.txtUserLevel = new System.Windows.Forms.TextBox();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.lblActiveState = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvRoleList = new System.Windows.Forms.DataGridView();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.clmUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmControlName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoleState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errUL = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbActiveState = new RMS.ColumnComboBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 31);
            this.panel3.TabIndex = 69;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(73, 16);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "User Level";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.btnExit.Location = new System.Drawing.Point(448, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel5.Location = new System.Drawing.Point(-9, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 503);
            this.panel5.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Location = new System.Drawing.Point(484, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 512);
            this.panel1.TabIndex = 72;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel6.Location = new System.Drawing.Point(-138, 496);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(954, 10);
            this.panel6.TabIndex = 73;
            // 
            // txtUserLevelCode
            // 
            this.txtUserLevelCode.Location = new System.Drawing.Point(126, 57);
            this.txtUserLevelCode.Name = "txtUserLevelCode";
            this.txtUserLevelCode.ReadOnly = true;
            this.txtUserLevelCode.Size = new System.Drawing.Size(152, 20);
            this.txtUserLevelCode.TabIndex = 76;
            // 
            // lblUserLevelCode
            // 
            this.lblUserLevelCode.AutoSize = true;
            this.lblUserLevelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUserLevelCode.Location = new System.Drawing.Point(12, 58);
            this.lblUserLevelCode.Name = "lblUserLevelCode";
            this.lblUserLevelCode.Size = new System.Drawing.Size(109, 16);
            this.lblUserLevelCode.TabIndex = 74;
            this.lblUserLevelCode.Text = "User Level Code";
            // 
            // txtUserLevel
            // 
            this.txtUserLevel.Location = new System.Drawing.Point(126, 93);
            this.txtUserLevel.Name = "txtUserLevel";
            this.txtUserLevel.Size = new System.Drawing.Size(193, 20);
            this.txtUserLevel.TabIndex = 78;
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUserLevel.Location = new System.Drawing.Point(12, 94);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(73, 16);
            this.lblUserLevel.TabIndex = 77;
            this.lblUserLevel.Text = "User Level";
            // 
            // lblActiveState
            // 
            this.lblActiveState.AutoSize = true;
            this.lblActiveState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblActiveState.Location = new System.Drawing.Point(234, 408);
            this.lblActiveState.Name = "lblActiveState";
            this.lblActiveState.Size = new System.Drawing.Size(85, 16);
            this.lblActiveState.TabIndex = 79;
            this.lblActiveState.Text = "Active Status";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(393, 446);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 84;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(312, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 83;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(231, 446);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 82;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(150, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = global::RMS.Properties.Resources.search25;
            this.btnSearch.Location = new System.Drawing.Point(284, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 75;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvRoleList
            // 
            this.dgvRoleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUserRole,
            this.clmControlName,
            this.clmRoleState});
            this.dgvRoleList.Location = new System.Drawing.Point(16, 130);
            this.dgvRoleList.Name = "dgvRoleList";
            this.dgvRoleList.Size = new System.Drawing.Size(452, 264);
            this.dgvRoleList.TabIndex = 85;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSelectAll.FlatAppearance.BorderSize = 0;
            this.btnSelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSelectAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSelectAll.Location = new System.Drawing.Point(16, 403);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 25);
            this.btnSelectAll.TabIndex = 86;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClearAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearAll.Location = new System.Drawing.Point(109, 403);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 25);
            this.btnClearAll.TabIndex = 87;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // clmUserRole
            // 
            this.clmUserRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmUserRole.HeaderText = "User Role";
            this.clmUserRole.Name = "clmUserRole";
            // 
            // clmControlName
            // 
            this.clmControlName.HeaderText = "Control Name";
            this.clmControlName.Name = "clmControlName";
            this.clmControlName.Visible = false;
            // 
            // clmRoleState
            // 
            this.clmRoleState.HeaderText = "State";
            this.clmRoleState.Name = "clmRoleState";
            this.clmRoleState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmRoleState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmRoleState.Width = 80;
            // 
            // errUL
            // 
            this.errUL.ContainerControl = this;
            // 
            // cmbActiveState
            // 
            this.cmbActiveState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbActiveState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbActiveState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbActiveState.DropDownWidth = 17;
            this.cmbActiveState.FormattingEnabled = true;
            this.cmbActiveState.Location = new System.Drawing.Point(333, 407);
            this.cmbActiveState.Name = "cmbActiveState";
            this.cmbActiveState.Size = new System.Drawing.Size(135, 21);
            this.cmbActiveState.TabIndex = 80;
            this.cmbActiveState.ViewColumn = 0;
            // 
            // frmUserLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 497);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.dgvRoleList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbActiveState);
            this.Controls.Add(this.lblActiveState);
            this.Controls.Add(this.txtUserLevel);
            this.Controls.Add(this.lblUserLevel);
            this.Controls.Add(this.txtUserLevelCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblUserLevelCode);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserLevel";
            this.Load += new System.EventHandler(this.frmUserLevel_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtUserLevelCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblUserLevelCode;
        private System.Windows.Forms.TextBox txtUserLevel;
        private System.Windows.Forms.Label lblUserLevel;
        private ColumnComboBox cmbActiveState;
        private System.Windows.Forms.Label lblActiveState;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvRoleList;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmControlName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmRoleState;
        private System.Windows.Forms.ErrorProvider errUL;
    }
}