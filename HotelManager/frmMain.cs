using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// 子窗体对象
        /// </summary>
        frmGuestInfo frmGuestInfo = null;
        frmRecordInfo frmRescrdInfo = null;
        frmRoom frmRoom = null;
        frmRoomInfo frmRoomInfo = null;
        frmRoomType frmRoomType = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmiRoomInfo_Click(object sender, EventArgs e)
        {
            if (frmRoom == null || frmRoom.IsDisposed)//是否被释放
            {
                frmRoom = new frmRoom();
                frmRoom.MdiParent = this;
                frmRoom.Show();
            }
            frmRoom.Activate();//激活窗体并给予焦点
        }

        private void tsmiRoomType_Click(object sender, EventArgs e)
        {
            if (frmRoomType == null || frmRoomType.IsDisposed)//是否被释放
            {
                frmRoomType  = new frmRoomType();
                frmRoomType.MdiParent = this;
                frmRoomType.Show();
            }
            frmRoomType.Activate();//激活窗体并给予焦点
        }

        private void tsmiGuestInfo_Click(object sender, EventArgs e)
        {
            if (frmGuestInfo == null || frmGuestInfo.IsDisposed)
            {
                frmGuestInfo = new frmGuestInfo();
                frmGuestInfo.MdiParent = this;
                frmGuestInfo.Show();
            }
            frmGuestInfo.Activate();
        }

        private void tsmiRoomInfo_Click_1(object sender, EventArgs e)
        {
            if (frmRoomInfo == null || frmRoomInfo.IsDisposed)
            {
                frmRoomInfo = new frmRoomInfo();
                frmRoomInfo.MdiParent = this;
                frmRoomInfo.Show();
            }
            frmRoomInfo.Activate();
        }

        private void tsmiRecordInfo_Click(object sender, EventArgs e)
        {
            if (frmRescrdInfo == null || frmRescrdInfo.IsDisposed)
            {
                frmRescrdInfo = new frmRecordInfo();
                frmRescrdInfo.MdiParent = this;
                frmRescrdInfo.Show();
            }
            frmRescrdInfo.Activate();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
