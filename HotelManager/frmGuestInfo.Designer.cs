namespace HotelManager
{
    partial class frmGuestInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuestInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.lblidentityID = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.dtpReside = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtIdentityID = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.cboRooms);
            this.groupBox1.Controls.Add(this.lblidentityID);
            this.groupBox1.Controls.Add(this.lblRoomID);
            this.groupBox1.Controls.Add(this.lblGuestName);
            this.groupBox1.Controls.Add(this.lblDeposit);
            this.groupBox1.Controls.Add(this.dtpReside);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDeposit);
            this.groupBox1.Controls.Add(this.txtIdentityID);
            this.groupBox1.Controls.Add(this.txtGuestName);
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 264);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登记顾客信息";
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(283, 207);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(95, 29);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cboRooms
            // 
            this.cboRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Location = new System.Drawing.Point(112, 169);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(150, 20);
            this.cboRooms.TabIndex = 3;
            // 
            // lblidentityID
            // 
            this.lblidentityID.AutoSize = true;
            this.lblidentityID.Location = new System.Drawing.Point(40, 43);
            this.lblidentityID.Name = "lblidentityID";
            this.lblidentityID.Size = new System.Drawing.Size(53, 12);
            this.lblidentityID.TabIndex = 0;
            this.lblidentityID.Text = "身份证号";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(64, 172);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(29, 12);
            this.lblRoomID.TabIndex = 5;
            this.lblRoomID.Text = "房间";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(40, 86);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(53, 12);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "客户姓名";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(64, 129);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(29, 12);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "押金";
            // 
            // dtpReside
            // 
            this.dtpReside.CustomFormat = "yyyy-MM-dd  HH:mm";
            this.dtpReside.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReside.Location = new System.Drawing.Point(112, 211);
            this.dtpReside.Name = "dtpReside";
            this.dtpReside.Size = new System.Drawing.Size(150, 21);
            this.dtpReside.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "入住时间";
            // 
            // txtDeposit
            // 
            this.txtDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeposit.Location = new System.Drawing.Point(112, 126);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(150, 21);
            this.txtDeposit.TabIndex = 2;
            // 
            // txtIdentityID
            // 
            this.txtIdentityID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentityID.Location = new System.Drawing.Point(112, 40);
            this.txtIdentityID.Name = "txtIdentityID";
            this.txtIdentityID.Size = new System.Drawing.Size(265, 21);
            this.txtIdentityID.TabIndex = 0;
            // 
            // txtGuestName
            // 
            this.txtGuestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuestName.Location = new System.Drawing.Point(112, 83);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(150, 21);
            this.txtGuestName.TabIndex = 1;
            // 
            // frmGuestInfo
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 326);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 364);
            this.Name = "frmGuestInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顾客入住登记";
            this.Activated += new System.EventHandler(this.frmGuestInfo_Activated);
            this.Load += new System.EventHandler(this.frmGuestInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cboRooms;
        private System.Windows.Forms.Label lblidentityID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.DateTimePicker dtpReside;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtIdentityID;
        private System.Windows.Forms.TextBox txtGuestName;
    }
}