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
    /// 房间类型
    /// 数据访问层
    /// </summary>
   public class RoomTypeService
    {
       /// <summary>
        /// 模糊查询房间类型
       /// </summary>
       /// <param name="typeName"></param>
       /// <returns></returns>
       public static List<RoomType> GetRoomType(string typeName = null)
       {
           string sql = "select * from RoomType Where 1=1 ";
           SqlParameter[] paras = null;
           if (typeName!=null)
           {
               sql += " And TypeName like +'%'+@TypeName+'%'";
              paras = new  SqlParameter[] { 
                new SqlParameter("@TypeName",typeName)                     
             };
           }
           
           try
           {
               SqlDataReader reader = SqlHelper.GetDataReader(sql, paras);
               List<RoomType> roomTypes = new List<RoomType>();
               while (reader.Read())
               {
                   roomTypes.Add(
                       new RoomType(
                         Convert.ToInt32(  reader["TypeId"]),
                         reader["TypeName"].ToString(),
                       Convert.ToDecimal(  reader["TypePrice"])
                         )
                     );
               }
               reader.Close();
               return roomTypes;
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
           string sql = "Delete RoomType where TypeId = @Id and TypeId Not In(Select RoomTypeId From Room)";
           SqlParameter[] paras = { 
           new SqlParameter("@Id",roomTypeId)                       
           };
           try
           {
             return  SqlHelper.Execute(sql, paras);
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
           string sql = "insert RoomType values(@Name,@Price)";
           SqlParameter[] paras = { 
           new SqlParameter("@Name",roomType.TypeName),
           new SqlParameter("@Price",roomType.TypePrice)            
           };
           try
           {
               SqlHelper.Execute(sql, paras);
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
           string sql = "Update RoomType set TypeName = @Name,TypePrice = @Price Where TypeId = @Id";
           SqlParameter[] paras = { 
           new SqlParameter("@Name",roomType.TypeName),
           new SqlParameter("@Price",roomType.TypePrice),
           new SqlParameter("@Id",roomType.TypeID) 
           };
           try
           {
               SqlHelper.Execute(sql, paras);
           }
           catch (Exception)
           {
               throw;
           }
       }
    }
}
