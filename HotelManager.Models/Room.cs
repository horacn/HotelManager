using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    /// <summary>
    /// 房间
    /// </summary>
  public  class Room
    {
        public int RoomId { get; set; }//房间编号
        public int BedNum { get; set; }//床位数
        public string Description { get; set; }//房间描述
        public RoomState Roomstate { get; set; }//房间状态对象
        public int GuestNum { get; set; }//入住人数 
        public RoomType RoomType { get; set; }//房间类型对象
        public string RoomName { get; set; }//房间名称
        
        public Room(int roomId, string description) 
        {
            this.RoomId = roomId;
            this.Description = description;
        }

        public Room(int roomId,string roomName,int bedNum,string description,RoomState roomstate,int guestNum,RoomType roomType)
        {
            this.RoomName = roomName;
            this.RoomId = roomId;
            this.BedNum = bedNum;
            this.Description = description;
            this.Roomstate = roomstate;
            this.GuestNum = guestNum;
            this.RoomType = roomType;
        }
        public Room(int roomId)
        {
            this.RoomId = roomId;
        }
        /// <summary>
        /// 新增修改用
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="roomName"></param>
        /// <param name="bedNum"></param>
        /// <param name="description"></param>
        /// <param name="roomType"></param>
        public Room(int roomId, string roomName, int bedNum, string description, RoomType roomType)
        {
            this.RoomId = roomId;
            this.RoomName = roomName;
            this.BedNum = bedNum;
            this.Description = description;
            this.RoomType = roomType;
        }
        public Room(string roomName,int roomId)
        {
            this.RoomId = roomId;
            this.RoomName  = roomName;
        }
        public override string ToString()
        {
            return RoomName;
        }
    }
}
