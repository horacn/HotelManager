using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HotelManager.Models;

namespace HotelManager.DAL
{
    /// <summary>
    /// 顾客类
    /// 数据访问层
    /// </summary>
   public class GuestRecordService
    {
       /// <summary>
        /// 顾客登记
       /// </summary>
       /// <param name="guest"></param>
       /// <returns></returns>
       public static bool AddGuest(GuestInsert guest)
       {
            string sql = "Insert GuestRecord(IdentityID,GuestName,RoomID,ResideID,ResideDate,Deposit) Values(@IdCard,@Name,@RoomId,(Select ResideId From ResideState Where ResideName = '未结账'),@ResideDate,@Deposit)";
            SqlParameter [] paras = {
            new SqlParameter("@IdCard",guest.IdentityId),     
            new SqlParameter("@Name",guest.GuestName),    
            new SqlParameter("@RoomId",guest.RoomId), 
            new SqlParameter("@ResideDate",guest.ResideDate),    
            new SqlParameter("@Deposit",guest.Deposit)
            };
           try 
	       {
               if (!SqlHelper.Execute(sql, paras))
                   return false;
              //更新房间入住人数
               RoomService.UpdateRoomGuestNum(guest.RoomId);
              return true;
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
       public static int GetGuestCount( DateTime? resideDate = null, DateTime? leaveDate = null, int? resideId = null)
       {
           string sql = "Select  Count(*)as Counts From GuestRecord as g Inner Join Room as r On g.RoomID = r.RoomID Inner Join ResideState as rs On g.ResideID = rs.ResideID  where 1=1  ";
           SqlParameter[] paras = null;
           //按时间段查
           if (resideDate != null && leaveDate != null && resideId == null)
           {
               sql += " And ResideDate Between @ResideDate And @LeaveDate Or LeaveDate Between @ResideDate And @LeaveDate";
               paras = new SqlParameter[]{
                   new SqlParameter("@ResideDate", resideDate),
                   new SqlParameter("@LeaveDate", leaveDate)
               };
           }
           //按状态查
           if (resideId != null && resideDate == null && leaveDate == null)
           {
               sql += " And g.ResideID = @ResideId";
               paras = new SqlParameter[]{
                   new SqlParameter("@ResideId", resideId)
               };
           }
           //按时间段和状态查
           if (resideId != null && resideDate != null && leaveDate != null)
           {
               sql += " And (ResideDate Between @ResideDate And @LeaveDate Or LeaveDate Between @ResideDate And @LeaveDate) And g.ResideID = @ResideId";
               paras = new SqlParameter[]{
                   new SqlParameter("@ResideDate", resideDate),
                   new SqlParameter("@LeaveDate", leaveDate),
                   new SqlParameter("@ResideId", resideId)
               };
           }
           //否则，查询全部
           try
           {
               SqlDataReader reader =  SqlHelper.GetDataReader(sql,paras);
               if (reader.Read())
               {
                   return Convert.ToInt32( reader["Counts"]);
               }
               return 0;
           }
           catch (Exception)
           {
               throw;
           }
       }
       /// <summary>
       /// 查询酒店交易信息
       /// </summary>
       /// <param name="page"></param>
       /// <param name="resideDate"></param>
       /// <param name="leaveDate"></param>
       /// <param name="resideId"></param>
       /// <returns></returns>
       public static List<GuestSeach> GetGuests(int page,DateTime? resideDate = null, DateTime? leaveDate = null, int? resideId = null)
       {
           //分页显示，每次显示21条数据
           string sql = "Select Top 21 g.*,r.RoomName,rs.ResideName,r.RoomStateId,r.RoomTypeID,RoomStateName = (Select RoomStateName From RoomState Where RoomStateID = r.RoomStateId),RoomTypeName = (Select TypeName From RoomType Where TypeId = r.RoomTypeID),RoomTypePrice = (Select TypePrice From RoomType Where TypeId = r.RoomTypeID) From GuestRecord as g Inner Join Room as r On g.RoomID = r.RoomID Inner Join ResideState as rs On g.ResideID = rs.ResideID  where GuestID Not In(Select Top(21 * (@Page-1)) GuestID From GuestRecord ) ";
           SqlParameter[] paras = new SqlParameter[]{
                   new SqlParameter("@Page", page)
                };
           //按时间段查
           if (resideDate != null && leaveDate != null && resideId == null)
           {
               sql += " And ResideDate Between @ResideDate And @LeaveDate Or LeaveDate Between @ResideDate And @LeaveDate order by g.GuestID ";
               paras = new SqlParameter[]{
                   new SqlParameter("@Page", page),
                   new SqlParameter("@ResideDate", resideDate),
                   new SqlParameter("@LeaveDate", leaveDate)
               };
           }
           //按状态查
           if (resideId != null && resideDate == null && leaveDate == null)
           {
               sql += " And g.ResideID = @ResideId order by g.GuestID ";
               paras = new SqlParameter[]{
                   new SqlParameter("@Page", page),
                   new SqlParameter("@ResideId", resideId)
               };
           }
           //按时间段和状态查
           if (resideId != null && resideDate != null && leaveDate != null)
           {
               sql += " And (ResideDate Between @ResideDate And @LeaveDate Or LeaveDate Between @ResideDate And @LeaveDate) And g.ResideID = @ResideId  order by g.GuestID ";
               paras = new SqlParameter[]{
                   new SqlParameter("@Page", page),
                   new SqlParameter("@ResideDate", resideDate),
                   new SqlParameter("@LeaveDate", leaveDate),
                   new SqlParameter("@ResideId", resideId)
               };
           }
           //否则，查询全部
           if (resideId == null && resideDate == null && leaveDate == null)
           {
               sql += " order by g.GuestID";
           }
           try
           {
               SqlDataReader reader = SqlHelper.GetDataReader(sql, paras);
             List<GuestSeach> guests = new List<GuestSeach>();
             while (reader.Read())
             {
                    GuestSeach guest = new GuestSeach(
                        Convert.ToInt32(reader["GuestID"]),
                        reader["IdentityID"].ToString(),
                        reader["GuestName"].ToString(),
                        reader["ResideName"].ToString(),
                        new RoomType(
                            reader["RoomTypeName"].ToString(),
                            Convert.ToDecimal(reader["RoomTypePrice"])
                        ),
                        reader["RoomStateName"].ToString(),
                        new Room(
                            reader["RoomName"].ToString(),
                            Convert.ToInt32(reader["RoomID"])
                            ),
                        Convert.ToDateTime(reader["ResideDate"]),
                        Convert.ToDecimal(reader["Deposit"])
                        );
                    //判断离店日期及总金额是否为DBNull
                    if (reader["LeaveDate"] == System.DBNull.Value)
                    {
                        guest.LeaveDate = null;
                    }
                    else
                    {
                        guest.LeaveDate = Convert.ToDateTime(reader["LeaveDate"]);
                    }
                    if (reader["TotalMoney"] == System.DBNull.Value)
                    {
                        guest.TotalMoney = null;
                    }
                    else
                    {
                        guest.TotalMoney = Convert.ToDecimal(reader["TotalMoney"]);
                    }
                    guests.Add(guest);
             }
             reader.Close();
             return guests;
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
           string sql = "USP_CHECKINGOUTROOM";
           SqlParameter [] paras = { 
              new SqlParameter("@GUESTID",guest.GuestId),
              new SqlParameter("@LEAVEDATE",guest.LeaveDate),
              new SqlParameter("@TOTALMONEY",guest.TotalMoney)
              };
           try
           {
               return SqlHelper.ExecuteByPROC(sql,paras);
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
           //先更改顾客状态、退房日期、总金额
           string sql = "Update GuestRecord Set ResideID = (Select ResideId From ResideState Where ResideName = '已结账'),LeaveDate = @LeaveDate,TotalMoney = @TotalMoney Where GuestID = @GuestID";
           SqlParameter[] paras = { 
                 new SqlParameter("@LeaveDate",guest.LeaveDate),
                 new SqlParameter("@TotalMoney",guest.TotalMoney),
                 new SqlParameter("@GuestID",guest.GuestId)
             };
           try
           {
               if (!SqlHelper.ExecuteWithTran(sql, paras))
                   return false;
           }
           catch (Exception)
           {
               throw;
           }
           //再把房间的客人数量减一
           try
           {
               if (!RoomService.UpdateRoomGuestNumByCheckOutRoom(guest.Room.RoomId))
                   return false;
           }
           catch (Exception)
           {
               throw;
           }
           //判断当前房间入住人数是否小于等于0
           try
           {
               if (RoomService.GetRoomGuestNumByCheckOutRoom(guest.Room.RoomId) <= 0)
               {
                   //如果这个房间当前入住人数小于等于0，把状态改为空闲
                   try
                   {
                       if (!RoomService.UpdateRoomRoomStateByCheckOutRoom(guest.Room.RoomId))
                           return false;
                   }
                   catch (Exception)
                   {
                       throw;
                   }
               }
           }
           catch (Exception)
           {
               throw;
           }
           return true;
       }
     }
}
