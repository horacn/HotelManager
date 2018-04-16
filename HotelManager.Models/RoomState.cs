using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    /// <summary>
    /// 房间状态
    /// </summary>
   public class RoomState
    {
        public int RoomStateID { get; set; }//状态ID
        public string RoomStateName { get; set; }//状态名称

        public RoomState() { }

        public RoomState(int id, string name)
        {
            this.RoomStateID = id;
            this.RoomStateName = name;
        }
        public override string ToString()
        {
            return this.RoomStateName;
        }
   }
}
