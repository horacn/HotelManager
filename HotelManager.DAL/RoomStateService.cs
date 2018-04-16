using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.Models;
using System.Data.SqlClient;

namespace HotelManager.DAL
{
    /// <summary>
    /// 房间状态（数据访问层）
    /// </summary>
   public class RoomStateService
    {
       /// <summary>
        /// 把房间状态变为维修或变为空闲
       /// </summary>
       /// <param name="roomId"></param>
       /// <param name="msg"></param>
       public static void RoomWeiXiu(int roomId,string msg)
       {
           string sql = string.Empty;
           if(msg == "维修")
                sql = "Update Room Set RoomStateID = (Select RoomStateID From RoomState Where RoomStateName = '维修') Where RoomID = @RoomId";
           else if(msg == "维修完成")
               sql = "Update Room Set RoomStateID = (Select RoomStateID From RoomState Where RoomStateName = '空闲') Where RoomID = @RoomId";
           SqlParameter[] paras = { 
                new SqlParameter("@RoomId",roomId)                  
            };
           try
           {
               SqlHelper.Execute(sql,paras);
           }
           catch (Exception)
           {
               throw;
           }
       }
    }
}
