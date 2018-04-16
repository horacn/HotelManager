using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.Models;
using HotelManager.DAL;

namespace HotelManager.BLL
{
    /// <summary>
    /// 房间状态（业务逻辑层）
    /// </summary>
   public class RoomStateBLL
    {

        /// <summary>
        /// 把房间状态变为维修或变为空闲
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="msg"></param>
       public static void RoomWeiXiu(int roomId, string msg)
       {
           try
           {
               RoomStateService.RoomWeiXiu(roomId,msg);
           }
           catch (Exception)
           {
               throw;
           }
       }
    }
}
