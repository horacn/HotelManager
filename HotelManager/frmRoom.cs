using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.Models;
using HotelManager.BLL;

namespace HotelManager
{
    /// <summary>
    /// 房间信息管理窗体
    /// </summary>
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }
        //当前状态（新增/修改）
        public string FormType = string.Empty;

        private void frmRoom_Load(object sender, EventArgs e)
        {
            try
            {
                this.cboRoomType.DisplayMember = "TypeName";
                this.cboRoomType.ValueMember = "TypeId";
                this.cboRoomType.DataSource = new BindingList<RoomType>(RoomTypeBLL.GetRoomType());
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取房间类型下拉框出现异常\n" + ex.Message,"系统提示 ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            ShowRoom();
        }
        //显示房间信息
        public void ShowRoom()
        {
            this.dgvRooms.AutoGenerateColumns = false;
            if (this.txtSearchByRoomId.Text.Trim().Length == 0)
            {
                try
                {
                    this.dgvRooms.DataSource = new BindingList<Room>(RoomBLL.GetRoomsByRoomType());
                    Showtext();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("获取房间信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    this.dgvRooms.DataSource = new BindingList<Room>(RoomBLL.GetRoomsByRoomType(null,this.txtSearchByRoomId.Text.Trim()));
                    Showtext();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("获取房间信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (this.dgvRooms.RowCount < 1)
                return;
            //判断是否结账来显示不同的颜色
            foreach (DataGridViewRow row in this.dgvRooms.Rows)
            {
                if (row.Cells["colReside"].Value.ToString() == "维修")
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;//DataGridViewRow的字体风格、颜色
                }
                if (row.Cells["colReside"].Value.ToString() == "入住")
                {
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                }
            }
        }
        private void txtSearchByRoomId_TextChanged(object sender, EventArgs e)
        {
            ShowRoom();
        }
        //dgv点击事件
        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Showtext();
        }
        //根据dgv显示文本框
        public void Showtext()
        {
            if (!Checkdgv())
            {
                this.txtBedNum.Text = string.Empty;
                this.txtDescription.Text = string.Empty;
                this.cboRoomType.SelectedIndex = 0;
                return;
            }
            if (this.dgvRooms.CurrentRow.DataBoundItem == null)
            {
                return;
            }
            Room room = this.dgvRooms.CurrentRow.DataBoundItem as Room;
            this.txtRoomName.Text = room.RoomName;
            this.txtBedNum.Text = room.BedNum.ToString();
            this.txtDescription.Text = room.Description;
            this.cboRoomType.SelectedValue = room.RoomType.TypeID;
        }
        //判断当前选中行是否大于0
        public bool Checkdgv()
        {
            if (this.dgvRooms.SelectedRows.Count < 1)
            {
                return false;
            }
            return true;
        }
        //关闭窗体
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //使文本框可输入
        public void ExeuceText()
        {
            this.txtDescription.Enabled = true;
            this.txtBedNum.Enabled = true;
            this.cboRoomType.Enabled = true;
            this.txtRoomName.Enabled = true;
            this.lblRoomName.Enabled = true;
            this.lblBedNum.Enabled = true;
            this.lblDescetion.Enabled = true;
            this.lblRoomType.Enabled = true;
            this.txtRoomName.Focus();
        }
        //使文本框不可输入
        public void ExeuceTextReanOnly()
        {
            this.txtDescription.Enabled = false;
            this.txtBedNum.Enabled = false;
            this.cboRoomType.Enabled = false;
            this.txtRoomName.Enabled = false;
            this.lblRoomName.Enabled = false;
            this.lblBedNum.Enabled = false;
            this.lblDescetion.Enabled = false;
            this.lblRoomType.Enabled = false;
        }
        //取消
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            ExeuceTextReanOnly();
            this.tsmiSave.Enabled = false;
            this.tsmiUpdate.Enabled = true;
            this.tsmiAdd.Enabled = true;
            Showtext();
        }
        //修改
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            ExeuceText();
            this.FormType = "修改";
            this.tsmiAdd.Enabled = false;
            this.tsmiSave.Enabled = true;
        }
        //新建
        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            ExeuceText();
            this.tsmiUpdate.Enabled = false;
            this.tsmiSave.Enabled = true;
            this.FormType = "新建";
            this.txtBedNum.Clear();
            this.txtDescription.Clear();
            this.txtRoomName.Clear();
            if (this.cboRoomType.Items.Count>0)
            {
                this.cboRoomType.SelectedIndex = 0;
            }
        }
        //删除
        private void tsmiDel_Click(object sender, EventArgs e)
        {
            if (!Checkdgv())
                return;
            if (MessageBox.Show("您确认要删除此房间吗？", "系统提示 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (this.dgvRooms.CurrentRow.DataBoundItem == null)
            {
                return;
            }
            Room room = this.dgvRooms.CurrentRow.DataBoundItem as Room;
            try
            {
                if(RoomBLL.DeleteRoom(room.RoomId))
                    ShowRoom();
                else
                    MessageBox.Show("该房间正在使用中，不能删除", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除房间出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //保存
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (this.txtRoomName.Text.Trim().Length == 0)
            {
                MessageBox.Show("房号不能为空！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtRoomName.Focus();
                return;
            }
            if (this.txtBedNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("床位数不能为空！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBedNum.Focus();
                return;
            }
            if (this.txtDescription.Text.Trim().Length == 0)
            {
                MessageBox.Show("房间描述不能为空！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtDescription.Focus();
                return;
            }
            if (!CheckNum.CheckStringIsNum(this.txtBedNum.Text.Trim()) || this.txtBedNum.Text.Contains("."))
            {
                MessageBox.Show("您的输入有误，床位数必须为数字类型,不能包含其他字符！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBedNum.Clear();
                this.txtBedNum.Focus();
                return;
            }
            if (Convert.ToInt32(this.txtBedNum.Text.Trim()) <=0)
            {
                MessageBox.Show("床位数必须大于0！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBedNum.Clear();
                this.txtBedNum.Focus();
                return;
            }
            //根据新增或修改分开操作
            //修改
            if (this.FormType == "修改")
            {
                if (!Checkdgv())
                    return;
                if (this.dgvRooms.CurrentRow.DataBoundItem == null)
                {
                    return;
                }
                //判断是否有这个房间号
                try
                {
                    if (this.txtRoomName.Text.Trim() != (this.dgvRooms.CurrentRow.DataBoundItem as Room).RoomName)
                    {
                        if (RoomBLL.CheckRoomNameByEditRoom(this.txtRoomName.Text.Trim()))
                        {
                            MessageBox.Show("对不起，已经有这个房间号了！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtRoomName.Clear();
                            this.txtRoomName.Focus();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                     MessageBox.Show("判断是否有这个房间号出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                int roomId = (this.dgvRooms.CurrentRow.DataBoundItem as Room).RoomId;
                Room room = new Room(
                    roomId,
                    this.txtRoomName.Text.Trim(),
                    Convert.ToInt32( this.txtBedNum.Text.Trim()),
                    this.txtDescription.Text.Trim(),
                    this.cboRoomType.SelectedItem as RoomType//下拉框当前房间类型对象
                    );
                try
                {
                    if (RoomBLL.UpdateRoom(room))
                    {
                        ShowRoom();
                        ExeuceTextReanOnly();
                        this.tsmiSave.Enabled = false;
                        this.tsmiAdd.Enabled = true;
                    }
                    else
                        MessageBox.Show("您的操作有误，修改房间失败！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改房间出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //新增
            else if (this.FormType == "新建")
            {
                if (RoomBLL.CheckRoomNameByEditRoom(this.txtRoomName.Text.Trim()))
                {
                    MessageBox.Show("对不起，已经有这个房间号了！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtRoomName.Clear();
                    this.txtRoomName.Focus();
                    return;
                }
                Room room = new Room(
                    0,
                    this.txtRoomName.Text.Trim(),
                    Convert.ToInt32(this.txtBedNum.Text.Trim()),
                    this.txtDescription.Text.Trim(),
                    this.cboRoomType.SelectedItem as RoomType//下拉框当前房间类型对象
                    );
                try
                {
                    if (RoomBLL.AddRoom(room))
                    {
                        ShowRoom();
                        ExeuceTextReanOnly();
                        this.tsmiSave.Enabled = false;
                        this.tsmiUpdate.Enabled = true;
                    }
                    else
                        MessageBox.Show("您的操作有误，新增房间失败！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("新增房间出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 房间维修BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomWeiXiu("维修");
        }
        //将房间变为维修或维修完成了
        public void RoomWeiXiu(string msg)
        {
            if (!Checkdgv())
                return;
            int roomId = (this.dgvRooms.CurrentRow.DataBoundItem as Room).RoomId;
            try
            {
                RoomStateBLL.RoomWeiXiu(roomId, msg);
                ShowRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show("房间维修出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 维修完成GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomWeiXiu("维修完成");
        }
        //打开右键菜单时判断当前选中行是否是维修状态
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (!Checkdgv())
                return;
            Room room = this.dgvRooms.CurrentRow.DataBoundItem as Room;
            if (room.Roomstate.RoomStateName == "维修")
            {
                this.tsmiWeiXiu.Enabled = false;
                this.tsmiWeiXiuOk.Enabled = true;
            }
            else
            {
                this.tsmiWeiXiu.Enabled = true;
                this.tsmiWeiXiuOk.Enabled = false;
            }
        }
        //删除的KeyDown事件
        private void dgvRooms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.tsmiDel_Click(sender, e);
            }
        }
      
        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            //保存的KeyDown事件
            if (e.KeyCode == Keys.Enter)
            {
                this.tsmiSave_Click(sender, e);
            }
            //取消的KeyDown事件
            else if(e.KeyCode == Keys.Escape)
            {
                this.tsbCancel_Click(sender, e);
            }
        }
        //每当窗体被激活，就刷新列表
        private void frmRoom_Activated(object sender, EventArgs e)
        {
            frmRoom_Load(sender, e);
        }
    }
}
