using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.BLL;
using HotelManager.Models;

namespace HotelManager
{
    /// <summary>
    /// 顾客登记窗体
    /// </summary>
    public partial class frmGuestInfo : Form
    {
        public frmGuestInfo()
        {
            InitializeComponent();
        }
        //房间编号
        public int RoomId = -1;
        //窗体构造函数
        public frmGuestInfo(int roomId)
        {
            InitializeComponent();
            this.RoomId = roomId;
        }
        private void frmGuestInfo_Load(object sender, EventArgs e)
        {
            ShowRoom();
            if (this.RoomId!=-1)
            {
                this.cboRooms.SelectedValue = this.RoomId;
            }
            this.txtIdentityID.Focus();
        }
        /// <summary>
        /// 显示房间下拉框
        /// </summary>
        public void ShowRoom()
        {
            try
            {
                this.cboRooms.DisplayMember = "Description";
                this.cboRooms.ValueMember = "RoomID";
                List<Room> rooms = RoomBLL.GetNullRooms();
                if (rooms.Count <= 0)
                {
                    rooms.Insert(0, new Room(-1, "房间已满"));
                    this.btnOk.Enabled = false;
                }
                else
                    rooms.Insert(0, new Room(-1, "请选择房间"));
                this.cboRooms.DataSource = new BindingList<Room>(rooms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取房间下拉框出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 顾客入住
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckIsNull())
                 return;
            //创建顾客对象
            GuestInsert guest = new GuestInsert(
                this.txtIdentityID.Text.Trim(),
                this.txtGuestName.Text.Trim(),
               Convert.ToInt32(this.cboRooms.SelectedValue),
                this.dtpReside.Value,
               Convert.ToDecimal( this.txtDeposit.Text.Trim())
                );
            //登记
            try
            {
                if (GuestRecordBLL.AddGuest(guest))
                {
                    MessageBox.Show("登记成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Recovery();
                    this.txtIdentityID.Focus();
                }
                else
                    MessageBox.Show("登记失败。", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("顾客登记出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 检查输入是否合法
        /// </summary>
        /// <returns></returns>
        public bool CheckIsNull()
        {
            if (this.txtIdentityID.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入身份证号！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdentityID.Focus();
                return false;
            }
            if (this.txtGuestName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入顾客姓名！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtGuestName.Focus();
                return false;
            }
            if (this.txtDeposit.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入押金数额！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtDeposit.Focus();
                return false;
            }
            if (Convert.ToInt32(this.cboRooms.SelectedValue) <=0)
            {
                this.cboRooms.DroppedDown = true;//使下拉框展开
                return false;
            }
            if (this.txtIdentityID.Text.Trim().Length != 18)
            {
                MessageBox.Show("身份证号必须为18位！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdentityID.Focus();
                return false;
            }
            if (!CheckNum.CheckStringIsNum(this.txtDeposit.Text.Trim()))
            {
                MessageBox.Show("您的输入有误，押金必须为数字类型！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtDeposit.Clear();
                this.txtDeposit.Focus();
                return false;
            }
            if (!CheckNum.CheckIdCard(this.txtIdentityID.Text.Trim()))
            {
                MessageBox.Show("请输入合法的身份证号！必须是数字类型或者以“X”结尾", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtIdentityID.Focus();
                return false;
            }
            if (Convert.ToDecimal(this.txtDeposit.Text.Trim())<=50)
            {
                MessageBox.Show("押金必须大于50元！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtDeposit.Focus();
                return false;
            }
            return true;
        }
        //把文本框清空，重新绑定房间下拉框
        public void Recovery()
        {
            this.txtDeposit.Clear();
            this.txtGuestName.Clear();
            this.txtIdentityID.Clear();
            this.dtpReside.Value = DateTime.Now;
            ShowRoom();
        }

        private void frmGuestInfo_Activated(object sender, EventArgs e)
        {
            frmGuestInfo_Load(sender, e);
        }
    }
}
