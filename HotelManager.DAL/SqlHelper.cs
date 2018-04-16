using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace HotelManager.DAL
{
    /// <summary>
    /// 数据访问层通用类
    /// </summary>
    public class SqlHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public readonly static string connString = ConfigurationManager.ConnectionStrings["SqlServerHotelConnString"].ToString();

        /// <summary>
        /// 获取DataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql,SqlParameter [] paras = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql,conn);
            if (paras!= null)
            {
                cmd.Parameters.AddRange(paras);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static bool Execute(string sql, SqlParameter[] paras = null)
        {
            using (SqlConnection conn = new SqlConnection (connString))
            {
                SqlCommand cmd = new SqlCommand(sql,conn);
                if (paras!= null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery()>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 增删改(存储过程)
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static bool ExecuteByPROC(string sql, SqlParameter[] paras = null)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 增删改(启用事务)
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static bool ExecuteWithTran(string sql, SqlParameter[] paras = null)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                try
                {
                    conn.Open();
                    cmd.Transaction = conn.BeginTransaction();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cmd.Transaction.Commit();
                        return true;
                    }
                    else
                    {
                        cmd.Transaction.Rollback();
                        return false;
                    }
                }
                catch (Exception)
                {
                    cmd.Transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
