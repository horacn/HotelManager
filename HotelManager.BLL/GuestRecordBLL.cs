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
    /// 顾客类
    /// 业务逻辑层
    /// </summary>
    public class GuestRecordBLL
    {
        /// <summary>
        /// 顾客登记
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        public static bool AddGuest(GuestInsert guest)
        {
            try
            {
              return  GuestRecordService.AddGuest(guest);
            }
            catch (Exception)
            {
                throw;
            }
        }
         /// <summary>
        /// 获取客户表的总行数
         /// </summary>
         /// <param name="resideDate"></param>
         /// <param name="leaveDate"></param>
         /// <param name="resideId"></param>
         /// <returns></returns>
        public static int GetGuestCount(DateTime? resideDate = null, DateTime? leaveDate = null, int? resideId = null)
        {
            try
            {
                return GuestRecordService.GetGuestCount(resideDate,leaveDate,resideId);
            }
            catch (Exception)
            {
                throw;
            }
        }
         /// <summary>
        /// 查询住房信息
         /// </summary>
         /// <param name="page"></param>
         /// <param name="resideDate"></param>
         /// <param name="leaveDate"></param>
         /// <param name="resideId"></param>
         /// <returns></returns>
        public static List<GuestSeach> GetGuests(int page, DateTime? resideDate = null, DateTime? leaveDate = null, int? resideId = null)
        {
            try
            {
                return GuestRecordService.GetGuests(page, resideDate, leaveDate, resideId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 退房（存储过程）
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        public static bool CheckOutRoomByPROC(GuestSeach guest)
        {
            try
            {
               return  GuestRecordService.CheckOutRoomByPROC(guest);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 退房（Sql语句）
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        public static bool CheckOutRoomBySql(GuestSeach guest)
        {
            try
            {
               return GuestRecordService.CheckOutRoomBySql(guest);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
