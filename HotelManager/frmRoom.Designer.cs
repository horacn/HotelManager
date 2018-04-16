namespace HotelManager
{
    partial class frmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoom));
            this.tsRoom = new System.Windows.Forms.ToolStrip();
            this.tsmiAdd = new System.Windows.Forms.ToolStripButton();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripButton();
            this.tsmiDel = new System.Windows.Forms.ToolStripButton();
            this.tsmiCancel = new System.Windows.Forms.ToolStripButton();
            this.tsmiExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchByRoomId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReside = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiWeiXiu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWeiXiuOk = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescetion = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtBedNum = new System.Windows.Forms.TextBox();
            this.lblBedNum = new System.Windows.Forms.Label();
            this.tsRoom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsRoom
            // 
            this.tsRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiUpdate,
            this.tsmiSave,
            this.tsmiDel,
            this.tsmiCancel,
            this.tsmiExit});
            this.tsRoom.Location = new System.Drawing.Point(0, 0);
            this.tsRoom.Name = "tsRoom";
            this.tsRoom.Size = new System.Drawing.Size(715, 40);
            this.tsRoom.TabIndex = 2;
            this.tsRoom.Text = "toolStrip1";
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAdd.Image")));
            this.tsmiAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(36, 37);
            this.tsmiAdd.Text = "新建";
            this.tsmiAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUpdate.Image")));
            this.tsmiUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(36, 37);
            this.tsmiUpdate.Text = "修改";
            this.tsmiUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Enabled = false;
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(36, 37);
            this.tsmiSave.Text = "保存";
            this.tsmiSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiDel
            // 
            this.tsmiDel.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDel.Image")));
            this.tsmiDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDel.Name = "tsmiDel";
            this.tsmiDel.Size = new System.Drawing.Size(36, 37);
            this.tsmiDel.Text = "删除";
            this.tsmiDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiDel.Click += new System.EventHandler(this.tsmiDel_Click);
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCancel.Image")));
            this.tsmiCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.Size = new System.Drawing.Size(36, 37);
            this.tsmiCancel.Text = "取消";
            this.tsmiCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExit.Image")));
            this.tsmiExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(36, 37);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchByRoomId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 43);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // txtSearchByRoomId
            // 
            this.txtSearchByRoomId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchByRoomId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchByRoomId.Location = new System.Drawing.Point(295, 17);
            this.txtSearchByRoomId.Name = "txtSearchByRoomId";
            this.txtSearchByRoomId.Size = new System.Drawing.Size(150, 21);
            this.txtSearchByRoomId.TabIndex = 0;
            this.txtSearchByRoomId.TextChanged += new System.EventHandler(this.txtSearchByRoomId_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房号";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToOrderColumns = true;
            this.dgvRooms.AllowUserToResizeRows = false;
            this.dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.colReside,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvRooms.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvRooms.Location = new System.Drawing.Point(0, 85);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowTemplate.Height = 23;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(715, 285);
            this.dgvRooms.TabIndex = 11;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            this.dgvRooms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRooms_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RoomName";
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "房号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BedNum";
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "床位数";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // colReside
            // 
            this.colReside.DataPropertyName = "RoomState";
            this.colReside.FillWeight = 80F;
            this.colReside.HeaderText = "房间状态";
            this.colReside.Name = "colReside";
            this.colReside.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RoomType";
            this.Column4.HeaderText = "房间类型";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            this.Column5.FillWeight = 140F;
            this.Column5.HeaderText = "房间描述";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GuestNum";
            this.Column6.FillWeight = 80F;
            this.Column6.HeaderText = "房客数";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWeiXiu,
            this.tsmiWeiXiuOk});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsmiWeiXiu
            // 
            this.tsmiWeiXiu.Name = "tsmiWeiXiu";
            this.tsmiWeiXiu.Size = new System.Drawing.Size(141, 22);
            this.tsmiWeiXiu.Text = "房间维修(&B)";
            this.tsmiWeiXiu.Click += new System.EventHandler(this.房间维修BToolStripMenuItem_Click);
            // 
            // tsmiWeiXiuOk
            // 
            this.tsmiWeiXiuOk.Name = "tsmiWeiXiuOk";
            this.tsmiWeiXiuOk.Size = new System.Drawing.Size(141, 22);
            this.tsmiWeiXiuOk.Text = "维修完成(&G)";
            this.tsmiWeiXiuOk.Click += new System.EventHandler(this.维修完成GToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRoomName);
            this.groupBox2.Controls.Add(this.lblRoomName);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.lblDescetion);
            this.groupBox2.Controls.Add(this.cboRoomType);
            this.groupBox2.Controls.Add(this.lblRoomType);
            this.groupBox2.Controls.Add(this.txtBedNum);
            this.groupBox2.Controls.Add(this.lblBedNum);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 103);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "房间类型信息";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomName.Enabled = false;
            this.txtRoomName.Location = new System.Drawing.Point(89, 17);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(120, 21);
            this.txtRoomName.TabIndex = 0;
            this.txtRoomName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // lblRoomName
            // 
            this.lblRoomName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Enabled = false;
            this.lblRoomName.Location = new System.Drawing.Point(47, 21);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(29, 12);
            this.lblRoomName.TabIndex = 0;
            this.lblRoomName.Text = "房号";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(317, 19);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(386, 74);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // lblDescetion
            // 
            this.lblDescetion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescetion.AutoSize = true;
            this.lblDescetion.Enabled = false;
            this.lblDescetion.Location = new System.Drawing.Point(251, 20);
            this.lblDescetion.Name = "lblDescetion";
            this.lblDescetion.Size = new System.Drawing.Size(53, 12);
            this.lblDescetion.TabIndex = 0;
            this.lblDescetion.Text = "房间描述";
            // 
            // cboRoomType
            // 
            this.cboRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.Enabled = false;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(89, 75);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(120, 20);
            this.cboRoomType.TabIndex = 2;
            this.cboRoomType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // lblRoomType
            // 
            this.lblRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Enabled = false;
            this.lblRoomType.Location = new System.Drawing.Point(23, 79);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(53, 12);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "房间类型";
            // 
            // txtBedNum
            // 
            this.txtBedNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBedNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBedNum.Enabled = false;
            this.txtBedNum.Location = new System.Drawing.Point(89, 46);
            this.txtBedNum.Name = "txtBedNum";
            this.txtBedNum.Size = new System.Drawing.Size(120, 21);
            this.txtBedNum.TabIndex = 1;
            this.txtBedNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // lblBedNum
            // 
            this.lblBedNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBedNum.AutoSize = true;
            this.lblBedNum.Enabled = false;
            this.lblBedNum.Location = new System.Drawing.Point(35, 50);
            this.lblBedNum.Name = "lblBedNum";
            this.lblBedNum.Size = new System.Drawing.Size(41, 12);
            this.lblBedNum.TabIndex = 0;
            this.lblBedNum.Text = "床位数";
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(725, 400);
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间信息管理";
            this.Activated += new System.EventHandler(this.frmRoom_Activated);
            this.Load += new System.EventHandler(this.frmRoom_Load);
            this.tsRoom.ResumeLayout(false);
            this.tsRoom.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsRoom;
        private System.Windows.Forms.ToolStripButton tsmiAdd;
        private System.Windows.Forms.ToolStripButton tsmiUpdate;
        private System.Windows.Forms.ToolStripButton tsmiSave;
        private System.Windows.Forms.ToolStripButton tsmiDel;
        private System.Windows.Forms.ToolStripButton tsmiCancel;
        private System.Windows.Forms.ToolStripButton tsmiExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchByRoomId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescetion;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtBedNum;
        private System.Windows.Forms.Label lblBedNum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiWeiXiu;
        private System.Windows.Forms.ToolStripMenuItem tsmiWeiXiuOk;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReside;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}