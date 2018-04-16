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
    /// 房间类
    /// 业务逻辑层
    /// </summary>
   public class RoomBLL
    {
       /// <summary>
        /// 查询剩余床位大于0的房间
       /// </summary>
       /// <returns></returns>
       public static List<Room> GetNullRooms()
       {
           try
           {
              return RoomService.GetNullRooms();
           }
           catch (Exception)
           {
               throw;
           }
       }
        /// <summary>
       /// 根据房间类型获取房间状态
        /// </summary>
        /// <param name="roomTypeId"></param>
        /// <param name="roomName"></param>
        /// <returns></returns>
       public static List<Room> GetRoomsByRoomType(int? roomTypeId = null, string roomName = null)
       {
           try
           {
               return RoomService.GetRoomsByRoomType(roomTypeId, roomName);
           }
           catch (Exception)
           {
               throw;
           }
       }
       /// <summary>
       /// 删除房间
       /// </summary>
       /// <param name="roomId"></param>
       /// <returns></returns>
       public static bool DeleteRoom(int roomId)
       {
           try
           {
               return RoomService.DeleteRoom(roomId);
           }
           catch (Exception)
           {
               throw;
           }
       }
       /// <summary>
       /// 新增房间
       /// </summary>
       /// <param name="room"></param>
       /// <returns></returns>
       public static bool AddRoom(Room room)
       {
           try
           {
               return RoomService.AddRoom(room);
           }
           catch (Exception)
           {
               throw;
           }
       }
       /// <summary>
       /// 修改房间
       /// </summary>
       /// <param name="room"></param>
       /// <returns></returns>
       public static bool UpdateRoom(Room room)
       {
           try
           {
               return RoomService.UpdateRoom(room);
           }
           catch (Exception)
           {
               throw;
           }
       }
       /// <summary>
      /// 编辑房间信息时查询是否有此房间名
      /// </summary>
      /// <param name="roomName"></param>
      /// <returns></returns>
       public static bool CheckRoomNameByEditRoom(string roomName)
       {
           try
           {
              return RoomService.CheckRoomNameByEditRoom(roomName);
           }
           catch (Exception)
           {
               throw;
           }
       }
    }
}
