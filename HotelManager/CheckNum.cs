using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    /// <summary>
    /// 检查数字的工具类
    /// </summary>
   public static class CheckNum
    {
       /// <summary>
        /// 检查数字是否合法
       /// </summary>
       /// <param name="checkStr"></param>
       /// <returns></returns>
       public static bool CheckStringIsNum(string checkStr)
       {
           if (checkStr.Trim().Length == 0)
               return false;
           double isMoney = 0;
           try
           {
               isMoney = Convert.ToDouble(checkStr.Trim());
               return true;
           }
           catch (Exception)
           {
               return false;
           }
       }
       /// <summary>
       /// 检查身份证是否合法
       /// </summary>
       /// <param name="idCard"></param>
       /// <returns></returns>
       public static bool CheckIdCard(string idCard)
       {
           if (idCard.Trim().Length != 18)
               return false;
           Int64 isIdCordForInt = 0;
           string x = "X";
           try
           {
               isIdCordForInt = Convert.ToInt64(idCard.Trim());
               isIdCordForInt = Convert.ToInt64(idCard.Trim().Substring(0, 17));
               return true;
           }
           catch (Exception)
           {
               int count = 0;
               for (int i = 0; i < idCard.Length-1; i++)
               {
                   if (x.Equals(idCard.Substring(i, 1).Trim().ToUpper()))
                       count++;
               }
               if (count!= 0)
                   return false;
               if (!x.Equals(idCard.Trim().Substring(17, 1).ToUpper()))
                   return false;
               else
                   return true;
            }
       }
    }
}
