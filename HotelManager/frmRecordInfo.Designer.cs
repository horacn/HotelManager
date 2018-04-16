namespace HotelManager
{
    partial class frmRecordInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecordInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.cboxDate = new System.Windows.Forms.CheckBox();
            this.cboResideState = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblfromTime = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginTime = new System.Windows.Forms.DateTimePicker();
            this.dgvRecordInfo = new System.Windows.Forms.DataGridView();
            this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resideDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResideState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.picOn = new System.Windows.Forms.PictureBox();
            this.picUnder = new System.Windows.Forms.PictureBox();
            this.picBottom = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.lblShowManagers = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.lblTotalMoney);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "退房信息";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Location = new System.Drawing.Point(301, 26);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(95, 21);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定退房";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(109, 26);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(166, 21);
            this.txtAmount.TabIndex = 0;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Enabled = false;
            this.lblTotalMoney.Location = new System.Drawing.Point(63, 30);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(29, 12);
            this.lblTotalMoney.TabIndex = 2;
            this.lblTotalMoney.Text = "房款";
            // 
            // gbQuery
            // 
            this.gbQuery.Controls.Add(this.cboxDate);
            this.gbQuery.Controls.Add(this.cboResideState);
            this.gbQuery.Controls.Add(this.lblTo);
            this.gbQuery.Controls.Add(this.lblfromTime);
            this.gbQuery.Controls.Add(this.dtpEndTime);
            this.gbQuery.Controls.Add(this.dtpBeginTime);
            this.gbQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQuery.Location = new System.Drawing.Point(0, 0);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Size = new System.Drawing.Size(927, 59);
            this.gbQuery.TabIndex = 10;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "查询条件";
            // 
            // cboxDate
            // 
            this.cboxDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxDate.AutoSize = true;
            this.cboxDate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxDate.Location = new System.Drawing.Point(193, 26);
            this.cboxDate.Name = "cboxDate";
            this.cboxDate.Size = new System.Drawing.Size(84, 16);
            this.cboxDate.TabIndex = 0;
            this.cboxDate.Text = "时间段查询";
            this.cboxDate.UseVisualStyleBackColor = true;
            this.cboxDate.CheckedChanged += new System.EventHandler(this.cboxDate_CheckedChanged);
            // 
            // cboResideState
            // 
            this.cboResideState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboResideState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResideState.FormattingEnabled = true;
            this.cboResideState.Items.AddRange(new object[] {
            "未结账",
            "已结账"});
            this.cboResideState.Location = new System.Drawing.Point(629, 24);
            this.cboResideState.Name = "cboResideState";
            this.cboResideState.Size = new System.Drawing.Size(105, 20);
            this.cboResideState.TabIndex = 3;
            this.cboResideState.SelectedIndexChanged += new System.EventHandler(this.cboResideState_SelectedIndexChanged);
            // 
            // lblTo
            // 
            this.lblTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTo.AutoSize = true;
            this.lblTo.Enabled = false;
            this.lblTo.Location = new System.Drawing.Point(448, 28);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(17, 12);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "至";
            // 
            // lblfromTime
            // 
            this.lblfromTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfromTime.AutoSize = true;
            this.lblfromTime.Enabled = false;
            this.lblfromTime.Location = new System.Drawing.Point(288, 28);
            this.lblfromTime.Name = "lblfromTime";
            this.lblfromTime.Size = new System.Drawing.Size(17, 12);
            this.lblfromTime.TabIndex = 9;
            this.lblfromTime.Text = "从";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEndTime.Enabled = false;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndTime.Location = new System.Drawing.Point(477, 24);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(125, 21);
            this.dtpEndTime.TabIndex = 2;
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.cboResideState_SelectedIndexChanged);
            // 
            // dtpBeginTime
            // 
            this.dtpBeginTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBeginTime.Enabled = false;
            this.dtpBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBeginTime.Location = new System.Drawing.Point(311, 24);
            this.dtpBeginTime.Name = "dtpBeginTime";
            this.dtpBeginTime.Size = new System.Drawing.Size(127, 21);
            this.dtpBeginTime.TabIndex = 1;
            this.dtpBeginTime.ValueChanged += new System.EventHandler(this.cboResideState_SelectedIndexChanged);
            // 
            // dgvRecordInfo
            // 
            this.dgvRecordInfo.AllowUserToAddRows = false;
            this.dgvRecordInfo.AllowUserToDeleteRows = false;
            this.dgvRecordInfo.AllowUserToOrderColumns = true;
            this.dgvRecordInfo.AllowUserToResizeRows = false;
            this.dgvRecordInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecordInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecordInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecordInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestName,
            this.identityID,
            this.resideDate,
            this.deposit,
            this.colResideState,
            this.leaveDate,
            this.totalMoney,
            this.roomID,
            this.roomTypeName,
            this.roomStateName});
            this.dgvRecordInfo.Location = new System.Drawing.Point(0, 65);
            this.dgvRecordInfo.MultiSelect = false;
            this.dgvRecordInfo.Name = "dgvRecordInfo";
            this.dgvRecordInfo.ReadOnly = true;
            this.dgvRecordInfo.RowHeadersVisible = false;
            this.dgvRecordInfo.RowTemplate.Height = 23;
            this.dgvRecordInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecordInfo.Size = new System.Drawing.Size(927, 361);
            this.dgvRecordInfo.TabIndex = 6;
            this.dgvRecordInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecordInfo_CellClick);
            this.dgvRecordInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRecordInfo_KeyDown);
            // 
            // GuestName
            // 
            this.GuestName.DataPropertyName = "GuestName";
            this.GuestName.FillWeight = 80F;
            this.GuestName.HeaderText = "客户姓名";
            this.GuestName.Name = "GuestName";
            this.GuestName.ReadOnly = true;
            this.GuestName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // identityID
            // 
            this.identityID.DataPropertyName = "IdentityID";
            this.identityID.FillWeight = 150F;
            this.identityID.HeaderText = "身份证号";
            this.identityID.Name = "identityID";
            this.identityID.ReadOnly = true;
            // 
            // resideDate
            // 
            this.resideDate.DataPropertyName = "ResideDate";
            this.resideDate.FillWeight = 120F;
            this.resideDate.HeaderText = "入住日期";
            this.resideDate.Name = "resideDate";
            this.resideDate.ReadOnly = true;
            // 
            // deposit
            // 
            this.deposit.DataPropertyName = "Deposit";
            this.deposit.FillWeight = 80F;
            this.deposit.HeaderText = "押金";
            this.deposit.Name = "deposit";
            this.deposit.ReadOnly = true;
            // 
            // colResideState
            // 
            this.colResideState.DataPropertyName = "ResideName";
            this.colResideState.FillWeight = 80F;
            this.colResideState.HeaderText = "状态";
            this.colResideState.Name = "colResideState";
            this.colResideState.ReadOnly = true;
            // 
            // leaveDate
            // 
            this.leaveDate.DataPropertyName = "LeaveDate";
            this.leaveDate.FillWeight = 120F;
            this.leaveDate.HeaderText = "退房日期";
            this.leaveDate.Name = "leaveDate";
            this.leaveDate.ReadOnly = true;
            // 
            // totalMoney
            // 
            this.totalMoney.DataPropertyName = "TotalMoney";
            this.totalMoney.FillWeight = 80F;
            this.totalMoney.HeaderText = "消费金额";
            this.totalMoney.Name = "totalMoney";
            this.totalMoney.ReadOnly = true;
            // 
            // roomID
            // 
            this.roomID.DataPropertyName = "Room";
            this.roomID.FillWeight = 80F;
            this.roomID.HeaderText = "房号";
            this.roomID.Name = "roomID";
            this.roomID.ReadOnly = true;
            // 
            // roomTypeName
            // 
            this.roomTypeName.DataPropertyName = "RoomType";
            this.roomTypeName.FillWeight = 90F;
            this.roomTypeName.HeaderText = "房间类型";
            this.roomTypeName.Name = "roomTypeName";
            this.roomTypeName.ReadOnly = true;
            // 
            // roomStateName
            // 
            this.roomStateName.DataPropertyName = "RoomStateName";
            this.roomStateName.FillWeight = 80F;
            this.roomStateName.HeaderText = "房间状态";
            this.roomStateName.Name = "roomStateName";
            this.roomStateName.ReadOnly = true;
            // 
            // picTop
            // 
            this.picTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTop.Image = ((System.Drawing.Image)(resources.GetObject("picTop.Image")));
            this.picTop.Location = new System.Drawing.Point(381, 8);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(16, 16);
            this.picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTop.TabIndex = 11;
            this.picTop.TabStop = false;
            this.picTop.Click += new System.EventHandler(this.picTop_Click);
            // 
            // picOn
            // 
            this.picOn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picOn.Image = ((System.Drawing.Image)(resources.GetObject("picOn.Image")));
            this.picOn.Location = new System.Drawing.Point(411, 8);
            this.picOn.Name = "picOn";
            this.picOn.Size = new System.Drawing.Size(16, 16);
            this.picOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOn.TabIndex = 11;
            this.picOn.TabStop = false;
            this.picOn.Click += new System.EventHandler(this.picOn_Click);
            // 
            // picUnder
            // 
            this.picUnder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUnder.Image = ((System.Drawing.Image)(resources.GetObject("picUnder.Image")));
            this.picUnder.Location = new System.Drawing.Point(499, 8);
            this.picUnder.Name = "picUnder";
            this.picUnder.Size = new System.Drawing.Size(16, 16);
            this.picUnder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUnder.TabIndex = 11;
            this.picUnder.TabStop = false;
            this.picUnder.Click += new System.EventHandler(this.picUnder_Click);
            // 
            // picBottom
            // 
            this.picBottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBottom.Image = ((System.Drawing.Image)(resources.GetObject("picBottom.Image")));
            this.picBottom.Location = new System.Drawing.Point(529, 8);
            this.picBottom.Name = "picBottom";
            this.picBottom.Size = new System.Drawing.Size(16, 16);
            this.picBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBottom.TabIndex = 11;
            this.picBottom.TabStop = false;
            this.picBottom.Click += new System.EventHandler(this.picBottom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPage);
            this.panel1.Controls.Add(this.lblShowManagers);
            this.panel1.Controls.Add(this.picUnder);
            this.panel1.Controls.Add(this.picTop);
            this.panel1.Controls.Add(this.picBottom);
            this.panel1.Controls.Add(this.picOn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 33);
            this.panel1.TabIndex = 13;
            // 
            // txtPage
            // 
            this.txtPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPage.Location = new System.Drawing.Point(444, 6);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(38, 21);
            this.txtPage.TabIndex = 14;
            this.txtPage.Text = "1";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPage.TextChanged += new System.EventHandler(this.txtPage_TextChanged);
            // 
            // lblShowManagers
            // 
            this.lblShowManagers.AutoSize = true;
            this.lblShowManagers.Location = new System.Drawing.Point(83, 8);
            this.lblShowManagers.Name = "lblShowManagers";
            this.lblShowManagers.Size = new System.Drawing.Size(41, 12);
            this.lblShowManagers.TabIndex = 13;
            this.lblShowManagers.Text = "label2";
            // 
            // frmRecordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbQuery);
            this.Controls.Add(this.dgvRecordInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 420);
            this.Name = "frmRecordInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顾客信息查询";
            this.Activated += new System.EventHandler(this.frmRecordInfo_Activated);
            this.Load += new System.EventHandler(this.frmRecordInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbQuery.ResumeLayout(false);
            this.gbQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.ComboBox cboResideState;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblfromTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpBeginTime;
        private System.Windows.Forms.DataGridView dgvRecordInfo;
        private System.Windows.Forms.CheckBox cboxDate;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.PictureBox picOn;
        private System.Windows.Forms.PictureBox picUnder;
        private System.Windows.Forms.PictureBox picBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblShowManagers;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn identityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn resideDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResideState;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStateName;
    }
}