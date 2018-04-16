using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    /// <summary>
    /// 顾客入住记录扩展类（登记用）
    /// </summary>
   public class GuestInsert:GuestRecord
    {
        public int RoomId { get; set; }//房间号
        public int ResideId { get; set; }//状态ID

        /// <summary>
        /// 登记用
        /// </summary>
        /// <param name="idCard"></param>
        /// <param name="guestName"></param>
        /// <param name="roomId"></param>
        /// <param name="resideDate"></param>
        /// <param name="deposit"></param>
        public GuestInsert(string idCard, string guestName, int roomId, DateTime resideDate, decimal deposit)
        {
            this.IdentityId = idCard;
            this.GuestName = guestName;
            this.RoomId = roomId;
            this.ResideDate = resideDate;
            this.Deposit = deposit;
        }
    }
}
