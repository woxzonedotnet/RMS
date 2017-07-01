namespace RMS.Forms
{
    partial class frmSubLocation
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
            this.lblLocationCode = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.txtSubLocationCode = new System.Windows.Forms.TextBox();
            this.txtSubLocationName = new System.Windows.Forms.TextBox();
            this.chkShowInFrontEnd = new System.Windows.Forms.CheckBox();
            this.chkIsOrderLocation = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errSubLocation = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errSubLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocationCode
            // 
            this.lblLocationCode.AutoSize = true;
            this.lblLocationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationCode.Location = new System.Drawing.Point(28, 36);
            this.lblLocationCode.Name = "lblLocationCode";
            this.lblLocationCode.Size = new System.Drawing.Size(95, 16);
            this.lblLocationCode.TabIndex = 0;
            this.lblLocationCode.Text = "Location Code";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(28, 72);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(99, 16);
            this.lblLocationName.TabIndex = 1;
            this.lblLocationName.Text = "Location Name";
            // 
            // txtSubLocationCode
            // 
            this.txtSubLocationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubLocationCode.Location = new System.Drawing.Point(129, 33);
            this.txtSubLocationCode.Name = "txtSubLocationCode";
            this.txtSubLocationCode.Size = new System.Drawing.Size(156, 21);
            this.txtSubLocationCode.TabIndex = 2;
            // 
            // txtSubLocationName
            // 
            this.txtSubLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubLocationName.Location = new System.Drawing.Point(129, 69);
            this.txtSubLocationName.Name = "txtSubLocationName";
            this.txtSubLocationName.Size = new System.Drawing.Size(156, 21);
            this.txtSubLocationName.TabIndex = 3;
            // 
            // chkShowInFrontEnd
            // 
            this.chkShowInFrontEnd.AutoSize = true;
            this.chkShowInFrontEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowInFrontEnd.Location = new System.Drawing.Point(129, 99);
            this.chkShowInFrontEnd.Name = "chkShowInFrontEnd";
            this.chkShowInFrontEnd.Size = new System.Drawing.Size(133, 20);
            this.chkShowInFrontEnd.TabIndex = 4;
            this.chkShowInFrontEnd.Text = "Show In Front End";
            this.chkShowInFrontEnd.UseVisualStyleBackColor = true;
            // 
            // chkIsOrderLocation
            // 
            this.chkIsOrderLocation.AutoSize = true;
            this.chkIsOrderLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsOrderLocation.Location = new System.Drawing.Point(129, 122);
            this.chkIsOrderLocation.Name = "chkIsOrderLocation";
            this.chkIsOrderLocation.Size = new System.Drawing.Size(128, 20);
            this.chkIsOrderLocation.TabIndex = 5;
            this.chkIsOrderLocation.Text = "Is Order Location";
            this.chkIsOrderLocation.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(93, 170);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 37);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(174, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 37);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(255, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errSubLocation
            // 
            this.errSubLocation.ContainerControl = this;
            // 
            // frmSubLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 218);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsOrderLocation);
            this.Controls.Add(this.chkShowInFrontEnd);
            this.Controls.Add(this.txtSubLocationName);
            this.Controls.Add(this.txtSubLocationCode);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.lblLocationCode);
            this.MaximizeBox = false;
            this.Name = "frmSubLocation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Location";
            ((System.ComponentModel.ISupportInitialize)(this.errSubLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocationCode;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.TextBox txtSubLocationCode;
        private System.Windows.Forms.TextBox txtSubLocationName;
        private System.Windows.Forms.CheckBox chkShowInFrontEnd;
        private System.Windows.Forms.CheckBox chkIsOrderLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errSubLocation;
    }
}