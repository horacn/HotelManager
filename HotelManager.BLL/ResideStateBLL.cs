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
    /// 顾客状态
    /// 业务逻辑层
    /// </summary>
   public class ResideStateBLL
    {
        /// <summary>
        /// 获取全部的顾客状态
        /// </summary>
        /// <returns></returns>
        public static List<ResideState> GetResideState()
        {
            try
            {
               return ResideStateService.GetResideState();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
