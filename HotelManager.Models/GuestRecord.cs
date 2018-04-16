using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    /// <summary>
    /// 顾客入住记录
    /// </summary>
   public class GuestRecord
    {
        public int GuestId { get; set; }//编号
        public string IdentityId { get; set; }//身份证号码
        public string GuestName { get; set; }//顾客姓名
        public Room Room { get; set; }//房间对象
        public ResideState ResideState { get; set; }//顾客状态对象
        public DateTime ResideDate { get; set; }//入住日期
        public DateTime ?LeaveDate { get; set; }//离店日期
        public decimal  Deposit { get; set; }//押金
        public decimal ?TotalMoney { get; set; }//总金额

        public GuestRecord() { }

      
    }
}
