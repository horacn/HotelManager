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
    /// 顾客状态
    /// 数据访问层
    /// </summary>
   public class ResideStateService
    {
       /// <summary>
        /// 获取全部的顾客状态
       /// </summary>
       /// <returns></returns>
       public static List<ResideState> GetResideState()
       {
           string sql = "Select * From ResideState ";
           try
           {
               SqlDataReader reader = SqlHelper.GetDataReader(sql);
               List<ResideState> resides = new List<ResideState>();
               while (reader.Read())
               {
                   resides.Add(
                       new ResideState(
                           Convert.ToInt32(reader["ResideId"]),
                           reader["ResideName"].ToString()
                           )
                       );
               }
               reader.Close();
               return resides;
           }
           catch (Exception)
           {
               throw;
           }
       }
    }
}
