namespace HotelManager
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.业务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuestInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础设置ToolStripMenuItem,
            this.业务管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础设置ToolStripMenuItem
            // 
            this.基础设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomType,
            this.tsmiRoom});
            this.基础设置ToolStripMenuItem.Name = "基础设置ToolStripMenuItem";
            this.基础设置ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.基础设置ToolStripMenuItem.Text = "基础设置(&E)";
            // 
            // tsmiRoomType
            // 
            this.tsmiRoomType.Name = "tsmiRoomType";
            this.tsmiRoomType.Size = new System.Drawing.Size(163, 22);
            this.tsmiRoomType.Text = "房间类型管理(&T)";
            this.tsmiRoomType.Click += new System.EventHandler(this.tsmiRoomType_Click);
            // 
            // tsmiRoom
            // 
            this.tsmiRoom.Name = "tsmiRoom";
            this.tsmiRoom.Size = new System.Drawing.Size(163, 22);
            this.tsmiRoom.Text = "房间信息管理(&E)";
            this.tsmiRoom.Click += new System.EventHandler(this.tsmiRoomInfo_Click);
            // 
            // 业务管理ToolStripMenuItem
            // 
            this.业务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGuestInfo,
            this.tsmiRoomInfo,
            this.tsmiRecordInfo});
            this.业务管理ToolStripMenuItem.Name = "业务管理ToolStripMenuItem";
            this.业务管理ToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.业务管理ToolStripMenuItem.Text = "业务管理(&M)";
            // 
            // tsmiGuestInfo
            // 
            this.tsmiGuestInfo.Name = "tsmiGuestInfo";
            this.tsmiGuestInfo.Size = new System.Drawing.Size(165, 22);
            this.tsmiGuestInfo.Text = "入住登记(&W)";
            this.tsmiGuestInfo.Click += new System.EventHandler(this.tsmiGuestInfo_Click);
            // 
            // tsmiRoomInfo
            // 
            this.tsmiRoomInfo.Name = "tsmiRoomInfo";
            this.tsmiRoomInfo.Size = new System.Drawing.Size(165, 22);
            this.tsmiRoomInfo.Text = "房间状态查看(&H)";
            this.tsmiRoomInfo.Click += new System.EventHandler(this.tsmiRoomInfo_Click_1);
            // 
            // tsmiRecordInfo
            // 
            this.tsmiRecordInfo.Name = "tsmiRecordInfo";
            this.tsmiRecordInfo.Size = new System.Drawing.Size(165, 22);
            this.tsmiRecordInfo.Text = "入住信息查看(&L)";
            this.tsmiRecordInfo.Click += new System.EventHandler(this.tsmiRecordInfo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(720, 458);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店信息管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomType;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoom;
        private System.Windows.Forms.ToolStripMenuItem 业务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuestInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordInfo;
    }
}

