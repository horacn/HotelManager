namespace HotelManager
{
    partial class frmRoomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomType));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiAdd = new System.Windows.Forms.ToolStripButton();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripButton();
            this.tsmiDel = new System.Windows.Forms.ToolStripButton();
            this.tsmiCancel = new System.Windows.Forms.ToolStripButton();
            this.tsmiClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTypePrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.dgvRoomTypes = new System.Windows.Forms.DataGridView();
            this.colTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchByTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiUpdate,
            this.tsmiSave,
            this.tsmiDel,
            this.tsmiCancel,
            this.tsmiClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAdd.Image")));
            this.tsmiAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(36, 37);
            this.tsmiAdd.Text = "新建";
            this.tsmiAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiAdd.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUpdate.Image")));
            this.tsmiUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(36, 37);
            this.tsmiUpdate.Text = "修改";
            this.tsmiUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiUpdate.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.tsmiSave.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsmiDel
            // 
            this.tsmiDel.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDel.Image")));
            this.tsmiDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDel.Name = "tsmiDel";
            this.tsmiDel.Size = new System.Drawing.Size(36, 37);
            this.tsmiDel.Text = "删除";
            this.tsmiDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiDel.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCancel.Image")));
            this.tsmiCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.Size = new System.Drawing.Size(36, 37);
            this.tsmiCancel.Text = "取消";
            this.tsmiCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiCancel.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Image = ((System.Drawing.Image)(resources.GetObject("tsmiClose.Image")));
            this.tsmiClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(36, 37);
            this.tsmiClose.Text = "退出";
            this.tsmiClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiClose.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTypePrice);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.txtTypeName);
            this.groupBox2.Controls.Add(this.lblRoomType);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 48);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "房间类型信息";
            // 
            // txtTypePrice
            // 
            this.txtTypePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTypePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypePrice.Enabled = false;
            this.txtTypePrice.Location = new System.Drawing.Point(350, 19);
            this.txtTypePrice.Name = "txtTypePrice";
            this.txtTypePrice.Size = new System.Drawing.Size(150, 21);
            this.txtTypePrice.TabIndex = 1;
            this.txtTypePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTypeName_KeyDown);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Enabled = false;
            this.lblPrice.Location = new System.Drawing.Point(308, 23);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "价格";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeName.Enabled = false;
            this.txtTypeName.Location = new System.Drawing.Point(126, 19);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(150, 21);
            this.txtTypeName.TabIndex = 0;
            this.txtTypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTypeName_KeyDown);
            // 
            // lblRoomType
            // 
            this.lblRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Enabled = false;
            this.lblRoomType.Location = new System.Drawing.Point(58, 23);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(53, 12);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "房间类型";
            // 
            // dgvRoomTypes
            // 
            this.dgvRoomTypes.AllowUserToAddRows = false;
            this.dgvRoomTypes.AllowUserToDeleteRows = false;
            this.dgvRoomTypes.AllowUserToOrderColumns = true;
            this.dgvRoomTypes.AllowUserToResizeRows = false;
            this.dgvRoomTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoomTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTypeName,
            this.colTypePrice});
            this.dgvRoomTypes.Location = new System.Drawing.Point(0, 84);
            this.dgvRoomTypes.MultiSelect = false;
            this.dgvRoomTypes.Name = "dgvRoomTypes";
            this.dgvRoomTypes.ReadOnly = true;
            this.dgvRoomTypes.RowHeadersVisible = false;
            this.dgvRoomTypes.RowTemplate.Height = 23;
            this.dgvRoomTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomTypes.Size = new System.Drawing.Size(584, 248);
            this.dgvRoomTypes.TabIndex = 11;
            this.dgvRoomTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomTypes_CellClick);
            this.dgvRoomTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRoomTypes_KeyDown);
            // 
            // colTypeName
            // 
            this.colTypeName.DataPropertyName = "TypeName";
            this.colTypeName.FillWeight = 110F;
            this.colTypeName.HeaderText = "房间类型";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.ReadOnly = true;
            // 
            // colTypePrice
            // 
            this.colTypePrice.DataPropertyName = "TypePrice";
            this.colTypePrice.HeaderText = "价格";
            this.colTypePrice.Name = "colTypePrice";
            this.colTypePrice.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchByTypeName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 43);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // txtSearchByTypeName
            // 
            this.txtSearchByTypeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchByTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchByTypeName.Location = new System.Drawing.Point(236, 16);
            this.txtSearchByTypeName.Name = "txtSearchByTypeName";
            this.txtSearchByTypeName.Size = new System.Drawing.Size(150, 21);
            this.txtSearchByTypeName.TabIndex = 0;
            this.txtSearchByTypeName.TextChanged += new System.EventHandler(this.txtSearchByTypeName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型名称";
            // 
            // frmRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvRoomTypes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "frmRoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间类型管理";
            this.Load += new System.EventHandler(this.frmRoomType_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiAdd;
        private System.Windows.Forms.ToolStripButton tsmiUpdate;
        private System.Windows.Forms.ToolStripButton tsmiSave;
        private System.Windows.Forms.ToolStripButton tsmiDel;
        private System.Windows.Forms.ToolStripButton tsmiCancel;
        private System.Windows.Forms.ToolStripButton tsmiClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTypePrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.DataGridView dgvRoomTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchByTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypePrice;
    }
}