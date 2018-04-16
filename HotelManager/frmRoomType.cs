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
    /// 房间类型管理窗体
    /// </summary>
    public partial class frmRoomType : Form
    {
        public frmRoomType()
        {
            InitializeComponent();
        }

        //当前状态（新增/修改）
        public string FormType = string.Empty;

        private void frmRoomType_Load(object sender, EventArgs e)
        {
            ShowRoomTypes();
            
        }
        //显示房间类型列表
        public void ShowRoomTypes(string roomTypeName = null)
        {
            this.dgvRoomTypes.AutoGenerateColumns = false;
            try
            {
                this.dgvRoomTypes.DataSource = new BindingList<RoomType>(RoomTypeBLL.GetRoomType(roomTypeName));
                Showtext();
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询房间类型出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //模糊查询
        private void txtSearchByTypeName_TextChanged(object sender, EventArgs e)
        {
            ShowRoomTypes(this.txtSearchByTypeName.Text.Trim());
        }
        //点击事件
        private void dgvRoomTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Showtext();
        }
        //根据dgv显示文本框
        public void Showtext()
        {
            if (!Checkdgv())
            {
                this.txtTypeName.Text = string.Empty;
                this.txtTypePrice.Text = string.Empty;
                return;
            }
            if (this.dgvRoomTypes.CurrentRow.DataBoundItem == null)
            {
                return;
            }
            RoomType rt = this.dgvRoomTypes.CurrentRow.DataBoundItem as RoomType;
            this.txtTypeName.Text = rt.TypeName;
            this.txtTypePrice.Text = rt.TypePrice.ToString();
        }
        //退出
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //判断当前选中行是否大于0
        public bool Checkdgv()
        {
            if (this.dgvRoomTypes.SelectedRows.Count < 1)
            {
                return false;
            }
            return true;
        }
        //删除
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (!Checkdgv())
                return;
            if ( MessageBox.Show("您确认要删除此房间类型吗？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (this.dgvRoomTypes.CurrentRow.DataBoundItem == null)
            {
                return;
            }
            RoomType rt = this.dgvRoomTypes.CurrentRow.DataBoundItem as RoomType;
            try
            {
                if(RoomTypeBLL.DelRoomType(rt.TypeID))
                    ShowRoomTypes();
                else
                    MessageBox.Show("该房间类型的房间正在使用中，不能删除", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除房间类型出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //修改
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ExeuceText();
            this.FormType = "修改";
            this.tsmiAdd.Enabled = false;
            this.tsmiSave.Enabled = true;
        }
        //使文本框可输入
        public void ExeuceText()
        {
            this.txtTypePrice.Enabled = true;
            this.txtTypeName.Enabled = true;
            this.lblPrice.Enabled = true;
            this.lblRoomType.Enabled = true;
            this.txtTypeName.Focus();
        }
        //使文本框不可输入
        public void ExeuceTextReanOnly()
        {
            this.txtTypePrice.Enabled = false;
            this.txtTypeName.Enabled = false;
            this.lblPrice.Enabled = false;
            this.lblRoomType.Enabled = false;
        }
        //新建
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ExeuceText();
            this.FormType = "新建";
            this.txtTypeName.Clear();
            this.txtTypePrice.Clear();
            this.tsmiUpdate.Enabled = false;
            this.tsmiSave.Enabled = true;
        }
        //保存
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.txtTypeName.Text.Trim().Length == 0)
            {
                MessageBox.Show("房间类型名称不能为空！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTypeName.Focus();
                return;
            }
            if (this.txtTypePrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("房间价格不能为空！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTypePrice.Focus();
                return;
            }
            if (!CheckNum.CheckStringIsNum(this.txtTypePrice.Text.Trim()))
            {
                MessageBox.Show("您的输入有误，房间价格必须为数字类型！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTypePrice.Clear();
                this.txtTypePrice.Focus();
                return;
            }
            if (Convert.ToDecimal(this.txtTypePrice.Text.Trim())<=0)
            {
                MessageBox.Show("房间价格必须大于0！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTypePrice.Clear();
                this.txtTypePrice.Focus();
                return;
            }
            //根据新增或修改分开操作
            //修改
            if (this.FormType == "修改")
            {
                if (!Checkdgv())
                    return;
                if (this.dgvRoomTypes.CurrentRow.DataBoundItem == null)
                {
                    return;
                }
                int typeId = (this.dgvRoomTypes.CurrentRow.DataBoundItem as RoomType).TypeID;
                RoomType rt = new RoomType(
                    typeId, this.txtTypeName.Text.Trim(), Convert.ToDecimal(this.txtTypePrice.Text.Trim())
                    );
                try
                {
                    RoomTypeBLL.UpdateRoomType(rt);
                    ShowRoomTypes();
                    ExeuceTextReanOnly();
                    this.tsmiSave.Enabled = false;
                    this.tsmiAdd.Enabled = true;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("修改房间类型出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //新增
            else if (this.FormType == "新建")
            {
                RoomType rt = new RoomType(
                    this.txtTypeName.Text.Trim(),
                    Convert.ToDecimal(this.txtTypePrice.Text.Trim())
                    );
                try
                {
                    RoomTypeBLL.AddRoomType(rt);
                    ShowRoomTypes();
                    ExeuceTextReanOnly();
                    this.tsmiSave.Enabled = false;
                    this.tsmiUpdate.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("新增房间类型出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //取消
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ExeuceTextReanOnly();
            this.tsmiSave.Enabled = false;
            this.tsmiUpdate.Enabled = true;
            this.tsmiAdd.Enabled = true;
            Showtext();
        }
        //当光标停留在下方的TextBox时，处理KeyDown事件
        private void txtTypeName_KeyDown(object sender, KeyEventArgs e)
        {
            //当新增或修改时，按下Enter就保存
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键 
            {
                      //这里是事件名称
                this.toolStripButton3_Click(sender, e);//执行保存事件
            }
            //当新增或修改时，按下Esc就取消
            else if (e.KeyCode == Keys.Escape)//如果输入的是Exc键
            {
                this.toolStripButton5_Click(sender,e);
            }
        }
        //当鼠标停留在dgv时，处理KeyDown事件
        private void dgvRoomTypes_KeyDown(object sender, KeyEventArgs e)
        {
            if (Checkdgv())
            {
                //如果按下的是Delete键，就删除
                if (e.KeyCode == Keys.Delete)
                {
                    this.toolStripButton4_Click(sender, e);
                }
            }
        }
    }
}
