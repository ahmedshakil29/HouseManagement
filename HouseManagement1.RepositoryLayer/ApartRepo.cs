using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using HouseManagement1.DataLayer;
using HouseManagement1.EntityLayer;
using HouseManagement1.FrameWorkLayer;


namespace HouseManagement1.RepositoryLayer
{
   public class ApartRepo
    {
        public static List<ApartInfo> GetSearchApart(string Key)
        {
           // string a = Session.UserId.ToString();
            var apartlist = new List<ApartInfo>();
            try
            {
                string sql;
                if (string.IsNullOrEmpty(Key))
                    sql = "select * from apartment where userid= " + Session.UserId + ";";
                else
                {
                    sql = "select * from apartment where userid= " + Session.UserId + " and ( apno like '" + Key + "%' or aptype like '" + Key + "%') ;";
                }
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    ApartInfo apt = ConvertToEntity(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static bool Save(ApartInfo a)
        {
            var sql="";
            if (a.ApartId==-1)
            {
                sql = "insert into apartment values ( '" + a.ApartType + "' , '" + a.ApartNo + "' ,'" + a.ApartSize + "','" + a.ApartView + "'," + a.ApartNoOfRoom + "," + a.ApartRentPrice + ",'" + a.ApartSpecification + "' ,'" + a.ApartStatus + "', " + a.ApartfloorNo + ", " + a.HouseId + ", " + a.userId + " );";
            }
            else
            {
                sql = "update apartment set  aptype='" + a.ApartType + "' , apno= '" + a.ApartNo + "' , size='" + a.ApartSize + "', views='" + a.ApartView + "', noofroom= " + a.ApartNoOfRoom + ", rentprice=" + a.ApartRentPrice + ", specification='" + a.ApartSpecification + "' , status='" + a.ApartStatus + "', floorno= " + a.ApartfloorNo + ", houseid= " + a.HouseId + ", userid= " + a.userId + "  where apid=" + a.ApartId + ";";
            }
                
                var row = DataAccess.ExecuteUpdateQuery(sql);
                if (row == 1)
                {
                    return true;
                }
                return false;
            
        }
        public static List<ApartInfo> GetAll()
        {
            var apartlist = new List<ApartInfo>();
            try
            {
                var sql = "select * from apartment where userid="+Session.UserId+";";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    ApartInfo apt = ConvertToEntity(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static List<ApartInfo> GetAllAdmin()
        {
            var apartlist = new List<ApartInfo>();
            try
            {
                var sql = "select * from apartment;";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    ApartInfo apt = ConvertToEntity(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static List<HouseInfo> GetAllHouse()
        {
            var houselist = new List<HouseInfo>();
            try
            {
                var sql = "select * from house;";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    HouseInfo hse = ConvertToHouseEntity(dt.Rows[ax]);
                    houselist.Add(hse);
                }
                return houselist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static string GetHouseTypeByHouseId(int houseid)
        {
            var house = new HouseInfo();
            try
            {
                var sql = "select * from house where houseid="+houseid+";";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    house = ConvertToHouseEntity(dt.Rows[ax]);
                    
                }
                return house.HouseType;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static HouseInfo GetHouseByHouseId(int houseid)
        {
            var house = new HouseInfo();
            try
            {
                var sql = "select * from house where houseid=" + houseid + ";";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    house = ConvertToHouseEntity(dt.Rows[ax]);

                }
                return house;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static HouseInfo GetHouseByHouseId(string housename)
        {
            var house = new HouseInfo();
            try
            {
                var sql = "select * from house where housename=" + housename + ";";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    house = ConvertToHouseEntity(dt.Rows[ax]);

                }
                return house;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static ApartInfo GetApart(int id)
        {
            var apart = new ApartInfo();
            try
            {
                var sql = "select apartment.*,housename from apartment,house where apartment.houseid=house.houseid and apid=" + id ;
                var dt = DataAccess.GetDataTable(sql);
                if (dt.Rows.Count >= 0)
                {
                    apart = ConvertToEntity2(dt.Rows[0]);
                }
              
                return apart;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        private static ApartInfo ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;

            var a = new ApartInfo();
            a.ApartId = Convert.ToInt32(row["apid"].ToString());
            a.ApartType= row["aptype"].ToString();
            a.ApartNo=row["apno"].ToString();
            a.ApartSize= row["size"].ToString();
            a.ApartView = row["views"].ToString();
            a.ApartNoOfRoom=  Convert.ToInt32( row["noofroom"].ToString());
            a.ApartRentPrice= Convert.ToDouble( row["rentprice"].ToString());
            a.ApartSpecification = row["specification"].ToString();
            a.ApartStatus =row["status"].ToString();
            a.ApartfloorNo = Convert.ToInt32(row["floorno"].ToString());
            a.HouseId =Convert.ToInt32(row["houseid"].ToString());
            
            a.userId = Convert.ToInt32(row["userid"].ToString());
            return a;
        }
        private static ApartInfo ConvertToEntity2(DataRow row)
        {
            if (row == null)
                return null;

            var a = new ApartInfo();
            a.ApartId = Convert.ToInt32(row["apid"].ToString());
            a.ApartType = row["aptype"].ToString();
            a.ApartNo = row["apno"].ToString();
            a.ApartSize = row["size"].ToString();
            a.ApartView = row["views"].ToString();
            a.ApartNoOfRoom = Convert.ToInt32(row["noofroom"].ToString());
            a.ApartRentPrice = Convert.ToDouble(row["rentprice"].ToString());
            a.ApartSpecification = row["specification"].ToString();
            a.ApartStatus = row["status"].ToString();
            a.ApartfloorNo = Convert.ToInt32(row["floorno"].ToString());
            a.HouseId = Convert.ToInt32(row["houseid"].ToString());
            a.HouseName = row["housename"].ToString();
            a.userId = Convert.ToInt32(row["userid"].ToString());
            return a;
        }
        private static HouseInfo ConvertToHouseEntity(DataRow row)
        {
            if (row == null)
                return null;

            var h = new HouseInfo();
            h.HouseId = Convert.ToInt32(row["houseid"].ToString());
            h.HouseName = row["housename"].ToString();
            h.HouseNo = row["houseno"].ToString();
            h.HouseType = row["housetype"].ToString();
            h.HouseCity = row["hcity"].ToString();
            h.HouseRegion = row["hregion"].ToString();
            h.HouseArea = row["harea"].ToString();
            h.HouseRoadNo = row["hroadno"].ToString();
            h.UserId = Convert.ToInt32( row["userid"].ToString());
            return h;
        }

        public static List<ApartInfo> GetSearchApartByAdmin(string Key)
        {
            // string a = Session.UserId.ToString();
            var apartlist = new List<ApartInfo>();
            try
            {
                string sql;
                if (string.IsNullOrEmpty(Key))
                    sql = "select * from apartment ;";
                else
                {
                    sql = "select * from apartment where   ( apno like '" + Key + "%' or aptype like '" + Key + "%') ;";
                }
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    ApartInfo apt = ConvertToEntity3(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        private static ApartInfo ConvertToEntity3(DataRow row)
        {
            if (row == null)
                return null;

            var a = new ApartInfo();
            a.ApartId = Convert.ToInt32(row["apid"].ToString());
            a.ApartType = row["aptype"].ToString();
            a.ApartNo = row["apno"].ToString();
            a.ApartSize = row["size"].ToString();
            a.ApartView = row["views"].ToString();
            a.ApartNoOfRoom = Convert.ToInt32(row["noofroom"].ToString());
            a.ApartRentPrice = Convert.ToDouble(row["rentprice"].ToString());
            a.ApartSpecification = row["specification"].ToString();
            a.ApartStatus = row["status"].ToString();
            a.ApartfloorNo = Convert.ToInt32(row["floorno"].ToString());
          //  a.HouseId = Convert.ToInt32(row["houseid"].ToString());

          //  a.userId = Convert.ToInt32(row["userid"].ToString());
            return a;
        }
    }
}
