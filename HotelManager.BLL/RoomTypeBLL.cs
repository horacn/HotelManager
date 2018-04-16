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
    /// 房间类型
    /// 业务逻辑层
    /// </summary>
    public class RoomTypeBLL
    {
        /// <summary>
        /// 模糊查询房间类型
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static List<RoomType> GetRoomType(string typeName = null)
        {
            try
            {
                return RoomTypeService.GetRoomType(typeName);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 删除房间类型
        /// </summary>
        /// <param name="roomTypeId"></param>
        /// <returns></returns>
        public static bool DelRoomType(int roomTypeId)
        {
            try
            {
              return  RoomTypeService.DelRoomType(roomTypeId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 新增房间类型
        /// </summary>
        /// <param name="roomType"></param>
        public static void AddRoomType(RoomType roomType)
        {
            try
            {
                RoomTypeService.AddRoomType(roomType);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 修改房间类型
        /// </summary>
        /// <param name="roomType"></param>
        public static void UpdateRoomType(RoomType roomType)
        {
            try
            {
                RoomTypeService.UpdateRoomType(roomType);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
