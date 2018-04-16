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
    /// 房间类
    /// 数据访问层
    /// </summary>
  public  class RoomService
    {
      /// <summary>
        /// 获取剩余床位大于0的房间
      /// </summary>
      /// <returns></returns>
      public static List<Room> GetNullRooms()
      {
          string sql = "select RoomState = convert(varchar(20),RoomName)+'号房（剩余床位:'+convert(varchar(20),(BedNum-GuestNum))+'）', RoomId from Room Where GuestNum < BedNum And RoomStateId != (select RoomStateID from RoomState where RoomStateName = '维修')";
          try
          {
              SqlDataReader reader =  SqlHelper.GetDataReader(sql);
              List<Room> rooms = new List<Room>();
              while (reader.Read())
              {
                  rooms.Add(
                      new Room(
                        Convert.ToInt32(  reader["RoomId"]),
                        reader["RoomState"].ToString()
                        )
                      );
              }
              reader.Close();
              return rooms;
          }
          catch (Exception)
          {
              throw;
          }
      }
      /// <summary>
      /// 根据房间类型或房间名称获取房间信息
      /// </summary>
      /// <param name="roomTypeId"></param>
      /// <param name="roomName"></param>
      /// <returns></returns>
      public static List<Room> GetRoomsByRoomType(int ?roomTypeId = null,string roomName = null)
      {
          string sql = "select r.*,rs.RoomStateName,rt.TypeName from Room as r Inner Join RoomState as rs On r.RoomStateID = rs.RoomStateID Inner Join RoomType as rt On r.RoomTypeID = rt.TypeID Where 1=1 ";
          SqlParameter [] paras = null;
          if (roomTypeId!= null)
          {
              sql += " And r.RoomTypeId = @RoomTypeId ";
              paras = new SqlParameter[] { 
              new SqlParameter("@RoomTypeId",roomTypeId)
              };
          }
          if (roomName != null)
          {
              sql += " And r.RoomName like +'%' +@RoomName+'%' ";
              paras = new SqlParameter[] { 
              new SqlParameter("@RoomName",roomName)
              };
          }
          try
          {
              SqlDataReader reader = SqlHelper.GetDataReader(sql,paras);
              List<Room> rooms = new List<Room>();
              while (reader.Read())
              {
                  rooms.Add(
                      new Room(
                        Convert.ToInt32(reader["RoomId"]),
                        reader["RoomName"].ToString(),
                        Convert.ToInt32(reader["BedNum"]),
                        reader["Description"].ToString(),
                        new RoomState(
                           Convert.ToInt32( reader["RoomStateID"]),
                           reader["RoomStateName"].ToString()
                            ),
                       Convert.ToInt32(reader["GuestNum"]),
                       new RoomType(
                          Convert.ToInt32( reader["RoomTypeID"]),
                          reader["TypeName"].ToString()
                           )
                        )
                      );
              }
              reader.Close();
              return rooms;
          }
          catch (Exception)
          {
              throw;
          }
      }
      /// <summary>
      /// 更新房间入住人数（住店）
      /// </summary>
      /// <param name="roomId"></param>
      public static void UpdateRoomGuestNum(int roomId)
      {
          string sql = "Update Room Set RoomStateID = (select RoomStateID from RoomState where RoomStateName = '入住'),GuestNum+=1 where RoomID = @RoomId";
          SqlParameter[] paras = { 
            new SqlParameter("@RoomId",roomId)
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
      /// 把房间的客人数量减一(退房)
      /// </summary>
      /// <param name="roomId"></param>
      /// <returns></returns>
      public static bool UpdateRoomGuestNumByCheckOutRoom(int roomId)
      {
          string sql = "Update Room Set GuestNum-=1 Where RoomId = @RoomId";
          SqlParameter[] paras = { 
            new SqlParameter("@RoomId",roomId)                     
            };
          try
          {
             return SqlHelper.ExecuteWithTran(sql, paras);
          }
          catch (Exception)
          {
              throw;
          }
      }
      /// <summary>
      /// 获取当前房间入住人数
      /// </summary>
      /// <param name="roomId"></param>
      /// <returns></returns>
      public static int GetRoomGuestNumByCheckOutRoom(int roomId)
      {
          string sql = "Select GuestNum From Room Where RoomId = @RoomId";
          SqlParameter[] paras = { 
            new SqlParameter("@RoomId",roomId)                     
            };
          try
          {
              SqlDataReader reader = SqlHelper.GetDataReader(sql, paras);
              if (reader.Read())
              {
                  return Convert.ToInt32(reader["GuestNum"]);
              }
              else
              {
                  return 100;
              }
          }
          catch (Exception)
          {
              throw;
          }
      }
      /// <summary>
      /// 把房间状态改为空闲
      /// </summary>
      /// <param name="roomId"></param>
      /// <returns></returns>
      public static bool UpdateRoomRoomStateByCheckOutRoom(int roomId)
      {
          string sql = "UPDATE Room SET RoomStateID = (Select RoomStateID FROM RoomState WHERE RoomStateName = '空闲') WHERE RoomID = @RoomId";
          SqlParameter[] paras = { 
            new SqlParameter("@RoomId",roomId)                     
            };
          try
          {
              return SqlHelper.ExecuteWithTran(sql, paras);
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
          string sql = "Delete Room Where RoomID = @RoomId And RoomId Not In (Select RoomId From GuestRecord)";
          SqlParameter[] paras = { 
           new SqlParameter("@RoomId",roomId)                      
           };
          try
          {
             return SqlHelper.Execute(sql, paras);
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
          string sql = "Insert Room Values(@BedNum,@Description,(Select RoomStateID From RoomState Where RoomStateName = '空闲'),0,@RoomTypeId,@RoomName)";
          SqlParameter[] paras = { 
             new SqlParameter("@BedNum",room.BedNum),
             new SqlParameter("@Description",room.Description),
             new SqlParameter("@RoomTypeId",room.RoomType.TypeID),
             new SqlParameter("@RoomName",room.RoomName)
             };
          try
          {
              return SqlHelper.Execute(sql, paras);
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
          string sql = "Update Room Set BedNum = @BedNum,Description = @Description,RoomTypeId = @RoomTypeId,RoomName = @RoomName Where RoomId = @RoomId";
          SqlParameter[] paras = { 
             new SqlParameter("@BedNum",room.BedNum),
             new SqlParameter("@Description",room.Description),
             new SqlParameter("@RoomTypeId",room.RoomType.TypeID),
              new SqlParameter("@RoomName",room.RoomName),
             new SqlParameter("@RoomId",room.RoomId)
             };
          try
          {
              return SqlHelper.Execute(sql, paras);
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
          string sql = "SELECT ROOMNAME FROM  ROOM WHERE ROOMNAME = @RoomName";
          SqlParameter[] paras = { 
               new SqlParameter("@RoomName",roomName)                  
               };
          try
          {
              SqlDataReader reader = SqlHelper.GetDataReader(sql,paras);
              List<Room> rooms = new List<Room>();
              bool isExists = false;
              if (reader.Read())
              {
                  isExists = true;
              }
              reader.Close();
              return isExists;
          }
          catch (Exception)
          {
              throw;
          }
      }
    }
}
