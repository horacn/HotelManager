using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    /// <summary>
    /// 顾客入住记录扩展类（查询用）
    /// </summary>
   public class GuestSeach:GuestRecord
    {
        public string ResideName { get; set; }//顾客状态名称
        public RoomType RoomType { get; set; }//房间类型名称
        public string RoomStateName { get; set; }//房间状态名称

       /// <summary>
        /// 显示用
       /// </summary>
       /// <param name="guestId"></param>
       /// <param name="idCard"></param>
       /// <param name="guestName"></param>
       /// <param name="resideName"></param>
       /// <param name="roomType"></param>
       /// <param name="roomStateName"></param>
       /// <param name="room"></param>
       /// <param name="resideDate"></param>
       /// <param name="deposit"></param>
        public GuestSeach(int guestId, string idCard, string guestName,string resideName,RoomType roomType ,string roomStateName ,Room room,DateTime resideDate, decimal deposit)
        {
            this.GuestId = guestId;
            this.IdentityId = idCard;
            this.GuestName = guestName;
            this.RoomStateName = roomStateName;
            this.RoomType = roomType;
            this.ResideName = resideName;
            this.Room = room;
            this.ResideDate = resideDate;
            this.Deposit = deposit;
        }
        public GuestSeach() { }
    }
}
