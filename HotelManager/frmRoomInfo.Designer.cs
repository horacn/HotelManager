namespace HotelManager
{
    partial class frmRoomInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomInfo));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvRoomType = new System.Windows.Forms.TreeView();
            this.lvRoom = new System.Windows.Forms.ListView();
            this.tipRoom = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvRoomType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvRoom);
            this.splitContainer1.Size = new System.Drawing.Size(592, 414);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvRoomType
            // 
            this.tvRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRoomType.Location = new System.Drawing.Point(0, 0);
            this.tvRoomType.Name = "tvRoomType";
            this.tvRoomType.Size = new System.Drawing.Size(163, 414);
            this.tvRoomType.TabIndex = 0;
            this.tvRoomType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRoomType_AfterSelect);
            // 
            // lvRoom
            // 
            this.lvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRoom.Location = new System.Drawing.Point(0, 0);
            this.lvRoom.Name = "lvRoom";
            this.lvRoom.ShowItemToolTips = true;
            this.lvRoom.Size = new System.Drawing.Size(425, 414);
            this.lvRoom.TabIndex = 0;
            this.lvRoom.UseCompatibleStateImageBehavior = false;
            this.lvRoom.DoubleClick += new System.EventHandler(this.lvRoom_DoubleClick);
            this.lvRoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvRoom_KeyDown);
            // 
            // frmRoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 414);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 320);
            this.Name = "frmRoomInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间信息查看";
            this.Activated += new System.EventHandler(this.frmRoomInfo_Activated);
            this.Load += new System.EventHandler(this.frmRoomInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvRoomType;
        private System.Windows.Forms.ListView lvRoom;
        private System.Windows.Forms.ToolTip tipRoom;
    }
}