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
    /// 房间状态查看窗体
    /// </summary>
    public partial class frmRoomInfo : Form
    {
        public frmRoomInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 存放房间图片的ImagesList
        /// </summary>
        private ImageList imgLiRoom;

        private void frmRoomInfo_Load(object sender, EventArgs e)
        {
            this.lvRoom.View = View.LargeIcon;//设置视图格式为大图像
            InitialImageList();
            this.lvRoom.LargeImageList = imgLiRoom;//设置ListView的ImageList
            ShowRoomType();
        }
        //显示所有房间类型菜单
        public void ShowRoomType()
        {
            this.tvRoomType.Nodes.Clear();
            TreeNode tnRoomType = new TreeNode("房间类型");
            try
            {
                List<RoomType> roomType = RoomTypeBLL.GetRoomType();
                foreach (RoomType rt in roomType)
                {
                    TreeNode tn = new TreeNode(rt.TypeName);
                    tn.Tag = rt;
                    tnRoomType.Nodes.Add(tn);
                }
                tnRoomType.ExpandAll();
                this.tvRoomType.Nodes.Add(tnRoomType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("绑定房间类型菜单出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tvRoomType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvRoomType.SelectedNode == null)
            {
                return;
            }
            ShowRoom();
        }
        //在ListView中显示房间信息
        public void ShowRoom()
        {
            //先清空
            this.lvRoom.Items.Clear();
            //判断TreeVie选择的节点深度
            //0，则显示全部
            if (this.tvRoomType.Nodes.Count <= 0)
                return;
            if (this.tvRoomType.SelectedNode.Level == 0)
            {
                try
                {
                    List<Room> rooms = RoomBLL.GetRoomsByRoomType();
                    foreach (Room room in rooms)
                    {
                        ListViewItem lv = new ListViewItem(room.RoomName);
                        ShowImage(room,lv);
                        lv.Tag = room;
                        this.lvRoom.Items.Add(lv);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询全部房间出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //否则，按照房间类型查询
            else
            {
                try
                {
                    int typeId = (this.tvRoomType.SelectedNode.Tag as RoomType).TypeID;
                    List<Room> rooms = RoomBLL.GetRoomsByRoomType(typeId);
                    foreach (Room room in rooms)
                    {
                        ListViewItem lv = new ListViewItem(room.RoomName);
                        ShowImage(room, lv);
                        lv.Tag = room;
                        this.lvRoom.Items.Add(lv);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("根据房间类型查询房间出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //根据房间状态不同显示不同的图片
        //显示提示文字
        public void ShowImage(Room room ,ListViewItem lv)
        {
            if (room.Roomstate.RoomStateName.Trim() == "入住")
            {
                lv.ImageKey = "入住";
            }
            else if (room.Roomstate.RoomStateName.Trim() == "空闲")
            {
                lv.ImageKey = "空闲";
            }
            else
            {
                lv.ImageKey = "维修";
            }
            //设置ToolTip的文本之前，必须将控件的ShowItemToolTips属性值设为True
            lv.ToolTipText = string.Format("房间状态：{0}\n剩余床位：{1}\n房间描述：{2}",room.Roomstate.RoomStateName,room.BedNum-room.GuestNum,room.Description);
        }
        //初始化ImageList
        public void InitialImageList()
        {
            imgLiRoom = new ImageList(); //Imagelist对象
            imgLiRoom.ColorDepth = ColorDepth.Depth32Bit;//设置图片颜色深度
            imgLiRoom.ImageSize = new System.Drawing.Size (36,36);//设置图片尺寸
            //Image从文件路径中读取
            Image imgHousing = Image.FromFile("images\\housing.jpg");//入住
            Image imgModify = Image.FromFile("images\\modify.jpg");//维修
            //给ImageList加项
            imgLiRoom.Images.Add("入住", imgHousing);
            imgLiRoom.Images.Add("维修", imgModify);
            imgLiRoom.Images.Add("空闲", Image.FromFile("images\\empty.jpg"));//空闲
        }
        //双击房间，打开客人入住窗体
        private void lvRoom_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvRoom.SelectedItems.Count <1)
            {
                return;
            }
            Room room = (this.lvRoom.SelectedItems[0].Tag as Room);
            if (room.Roomstate.RoomStateName.Trim() == "维修")
            {
                MessageBox.Show("该房间目前处于维修期，暂不支持入住！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (room.BedNum<=room.GuestNum)
            {
                MessageBox.Show("该房间已住满，请更换房间！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmGuestInfo fg = new frmGuestInfo(room.RoomId);
            fg.ShowDialog();
            ShowRoom();
        }
        //按下Enter则执行lvRoom_DoubleClick事件
        private void lvRoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lvRoom_DoubleClick(sender, e);
            }
        }
        //窗体激活时刷新列表
        private void frmRoomInfo_Activated(object sender, EventArgs e)
        {
            ShowRoom();
        }
    }
}
