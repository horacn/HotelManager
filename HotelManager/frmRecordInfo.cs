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
    /// 顾客信息查询窗体
    /// </summary>
    public partial class frmRecordInfo : Form
    {
        public frmRecordInfo()
        {
            InitializeComponent();
        }

        private void frmRecordInfo_Load(object sender, EventArgs e)
        {
            ShowResideState();
            picTop_Click(sender, e);
            //开始日期等于昨天
            this.dtpBeginTime.Value = DateTime.Now.AddDays(-1);
        }
        //绑定下拉框
        public void ShowResideState()
        {
            try
            {
                this.cboResideState.DisplayMember = "ResideName";
                this.cboResideState.ValueMember = "ResideId";
                List<ResideState> resides = ResideStateBLL.GetResideState();
                resides.Insert(0, new ResideState(-1,"请选择"));
                this.cboResideState.DataSource = new BindingList<ResideState>(resides);
            }
            catch (Exception ex)
            {
                MessageBox.Show("绑定顾客状态下拉框出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //点击CheckBox时，把日期控件激活
        private void cboxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxDate.Checked)
            {
                this.dtpBeginTime.Enabled = true;
                this.dtpEndTime.Enabled = true;
                this.lblTo.Enabled = true;
                this.lblfromTime.Enabled = true;
            }
            else
            {
                this.dtpBeginTime.Enabled = false;
                this.dtpEndTime.Enabled = false;
                this.lblTo.Enabled = false;
                this.lblfromTime.Enabled = false;
            }
            picTop_Click(sender, e);
        }
        //把总金额显示在下方的方法
        public void ShowTotalMoney()
        {
            if (this.dgvRecordInfo.SelectedRows.Count < 1)
            {
                return ;
            }
            GuestSeach guest = this.dgvRecordInfo.CurrentRow.DataBoundItem as GuestSeach;
            if (guest.ResideName == "未结账")
            {
                //计算时间间隔
                TimeSpan ts = DateTime.Now - guest.ResideDate;
                int days = ts.Days;
                if (DateTime.Now.Hour > guest.ResideDate.Hour)
                {
                    days++;
                }
                if (days < 1)
                {
                    days = 1;
                }
                decimal totalMoney = guest.RoomType.TypePrice * days;
                this.txtAmount.Text = totalMoney.ToString();
            }
            else
            {
                this.txtAmount.Text = guest.TotalMoney.ToString();
            }

            if (guest.ResideName == "已结账")
            {
                this.btnConfirm.Enabled = false;
                this.lblTotalMoney.Enabled = false;
            }
            else
            {
                this.btnConfirm.Enabled = true;
                this.lblTotalMoney.Enabled = true;
            }
        }
        //点击dgv时将信息显示到下面的TextBox中（事件）
        private void dgvRecordInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowTotalMoney();
        }
        //查询客人信息（事件）
        private void cboResideState_SelectedIndexChanged(object sender, EventArgs e)
        {
            picTop_Click(sender, e);
        }
        //查询酒店入住信息
        public void SeachGuests()
        {
            this.dgvRecordInfo.AutoGenerateColumns = false;
            int resideId = Convert.ToInt32( this.cboResideState.SelectedValue);
            DateTime resideDate = this.dtpBeginTime.Value;
            DateTime leaveDate = this.dtpEndTime.Value;
            //按时间段查
            if (this.cboxDate.Checked &&  resideId == -1)
            {
                try
                {
                    this.dgvRecordInfo.DataSource = new BindingList<GuestSeach>(GuestRecordBLL.GetGuests(this.Pages, resideDate, leaveDate));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("按时间段查询顾客信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //按状态查
            else if (!this.cboxDate.Checked &&  resideId != -1)
            {
                try
                {
                    this.dgvRecordInfo.DataSource = new BindingList<GuestSeach>(GuestRecordBLL.GetGuests(this.Pages, null, null, resideId));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("按入住状态查询顾客信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //按时间段和状态查
            else if (this.cboxDate.Checked && resideId != -1)
            {
                try
                {
                    this.dgvRecordInfo.DataSource = new BindingList<GuestSeach>(GuestRecordBLL.GetGuests(this.Pages, resideDate, leaveDate, resideId));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("按时间段以及入住状态查询顾客信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //查全部
            else if (!this.cboxDate.Checked &&  resideId == -1)
            {
                try
                {
                    this.dgvRecordInfo.DataSource = new BindingList<GuestSeach>(GuestRecordBLL.GetGuests(this.Pages));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询全部顾客信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            ShowTotalMoney();
            //刷新尾页及总行数
            GetMaxPages();

            if (this.dgvRecordInfo.RowCount < 1)
                return;
            //判断是否结账来显示不同的颜色
            foreach (DataGridViewRow row in this.dgvRecordInfo.Rows)
            {
                if (row.Cells["colResideState"].Value.ToString() == "未结账")
                    row.DefaultCellStyle.ForeColor = Color.Red;//DataGridViewRow的字体风格、颜色
                else
                    row.DefaultCellStyle.ForeColor = Color.Blue;
            }
        }
        //退房（事件）
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.dgvRecordInfo.SelectedRows.Count < 1)
            {
                return;
            }
            GuestSeach guest = this.dgvRecordInfo.CurrentRow.DataBoundItem as GuestSeach;
            guest.TotalMoney = Convert.ToDecimal(this.txtAmount.Text);
            guest.LeaveDate = DateTime.Now;
            try
            {
                //用存储过程退房
                //if (GuestRecordBLL.CheckOutRoomByPROC(guest))
                //{
                //    MessageBox.Show("退房成功！应退回押金" + guest.Deposit + "元", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    SeachGuests();
                // }
                //else
                //{
                //    MessageBox.Show("对不起，您的操作有误，退房失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

                //用Sql语句退房
                if (GuestRecordBLL.CheckOutRoomBySql(guest))
                {
                    MessageBox.Show("退房成功！应退回押金" + guest.Deposit + "元", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SeachGuests();
                }
                else
                {
                    MessageBox.Show("对不起，您的操作有误，退房失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("退房出现异常，请联系管理员!\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvRecordInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.btnConfirm.Enabled == true)//Enter键退房
            {
                this.btnConfirm_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)//Escape键最小化窗体
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (e.KeyCode == Keys.Right)//Right键向下翻页
            {
                this.picUnder_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Left)//Left键向上翻页
            {
                this.picOn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Home)//Home键回到首页
            {
                this.picTop_Click(sender, e);
            }
            else if (e.KeyCode == Keys.End)//End键到尾页
            {
                this.picBottom_Click(sender, e);
            }
        }
        //每当窗体被激活，就刷新列表
        private void frmRecordInfo_Activated(object sender, EventArgs e)
        {
           picTop_Click(sender, e);
        }

        //总行数
        private int AllCounts;
        //当前页数
        private int Pages = 1;
        //尾页
        private int MaxPages;

        //获取尾页的方法
        public void GetMaxPages()
        {
            int resideId = Convert.ToInt32(this.cboResideState.SelectedValue);
            DateTime resideDate = this.dtpBeginTime.Value;
            DateTime leaveDate = this.dtpEndTime.Value;
            //按时间段查
            if (this.cboxDate.Checked && resideId == -1)
            {
                try
                {
                    this.AllCounts =GuestRecordBLL.GetGuestCount(resideDate, leaveDate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("按时间段查询客户表记录总数量出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //按状态查
            else if (!this.cboxDate.Checked && resideId != -1)
            {
                try
                {
                    this.AllCounts = GuestRecordBLL.GetGuestCount(null, null, resideId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("按入住状态查询客户表记录总数量出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //按时间段和状态查
            else if (this.cboxDate.Checked && resideId != -1)
            {
                try
                {
                    this.AllCounts = GuestRecordBLL.GetGuestCount(resideDate, leaveDate, resideId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("按时间段以及入住状态查询客户表记录总数量出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //查全部
            else if (!this.cboxDate.Checked && resideId == -1)
            {
                try
                {
                    this.AllCounts = GuestRecordBLL.GetGuestCount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询全部客户表记录总数量出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                //计算尾页
                this.MaxPages = this.AllCounts / 21;
                if (this.AllCounts % 21 != 0 || this.AllCounts == 0)
                    this.MaxPages++;
                
                //分别要显示的标签
                if (this.AllCounts > 21)
                    this.lblShowManagers.Text = "共" + this.AllCounts + "条记录，每页21条，共" + this.MaxPages + "页";
                else if (this.AllCounts <= 21 && this.AllCounts > 0)
                    this.lblShowManagers.Text = "共" + this.AllCounts + "条记录，共" + this.MaxPages + "页";
                else
                {
                    this.lblShowManagers.Text = "没有符合条件的记录";
                    this.btnConfirm.Enabled = false;
                    this.lblTotalMoney.Enabled = false;
                }
        }
        //跳到尾页
        private void picBottom_Click(object sender, EventArgs e)
        {
            if (this.Pages == this.MaxPages)
                return;
            this.Pages = this.MaxPages;
            this.txtPage.Text = this.Pages.ToString();
            SeachGuests();
        }
        //跳到下页
        private void picUnder_Click(object sender, EventArgs e)
        {
            if (this.Pages == this.MaxPages)
                return;
            this.Pages++;
            this.txtPage.Text = this.Pages.ToString();
            SeachGuests();
        }
        //跳到上页
        private void picOn_Click(object sender, EventArgs e)
        {
            if (this.Pages == 1)
                return;
            this.Pages--;
            this.txtPage.Text = this.Pages.ToString();
            SeachGuests();
        }
        //跳到首页
        private void picTop_Click(object sender, EventArgs e)
        {
            this.Pages = 1;
            this.txtPage.Text = this.Pages.ToString();
            SeachGuests();
        }
        //输入页码，跳到相应页面
        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPage.Text.Trim().Length == 0)
                return;
            if(!CheckNum.CheckStringIsNum(this.txtPage.Text.Trim()) || this.txtPage.Text.Contains("."))
            {
                MessageBox.Show("您的输入有误！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPage.Clear();
                return;
            }
            if (Convert.ToInt32(this.txtPage.Text.Trim()) > this.MaxPages)
                return;
            if (Convert.ToInt32(this.txtPage.Text.Trim()) <= 0)
                return;
            this.Pages = Convert.ToInt32(this.txtPage.Text.Trim());
            SeachGuests();
        }
    }
}
