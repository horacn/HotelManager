using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Models
{
    /// <summary>
    /// 房间类型
    /// </summary>
    public class RoomType
    {
        public int TypeID { get; set; }//类型编号
        public string TypeName { get; set; }//类型名称
        public decimal TypePrice { get; set; }//类型价格

        public RoomType(int typeID, string typeName)
        {
            this.TypeID = typeID;
            this.TypeName = typeName;
        }

        public RoomType( string typeName, decimal typePrice)
        {
            this.TypeName = typeName;
            this.TypePrice = typePrice;
        }

        public RoomType(int typeID,string typeName,decimal typePrice)
        {
            this.TypeID = typeID;
            this.TypeName = typeName;
            this.TypePrice = typePrice;
        }
        public override string ToString()
        {
            return this.TypeName;
        }
    }
}
