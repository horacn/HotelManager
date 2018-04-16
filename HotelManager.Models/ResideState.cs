using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    /// <summary>
    /// 顾客入住状态（结账/未结账）
    /// </summary>
   public class ResideState
    {
        public int ResideId { get; set; }//编号
        public string ResideName { get; set; }//名称

        public ResideState() { }

        public ResideState(int id, string name)
        {
            this.ResideId = id;
            this.ResideName = name;
        }

    }
}
