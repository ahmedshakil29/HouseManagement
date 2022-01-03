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
    public  class HouseRepo
    {
        //public  DataTable SearchHouse(string key)
        //{
        //    string sql;
        //    if (string.IsNullOrEmpty(key))
        //        sql = "select * from house;";
        //    else
        //        sql = "select * from house where housename like '" + key + "%';";
        //   // GetAll();

        //    return DataAccess.GetDataTable(sql);
            
        //}
        public static List<HouseInfo> GetSearch( string Key)
        {
            var houselist = new List<HouseInfo>();
            try
            {
               string sql;
               if (string.IsNullOrEmpty(Key))
                   sql = "select * from house where  userid=" + Session.UserId + ";";
               else
               {
                   sql = "select * from house where userid=" + Session.UserId + " and ( harea like '" + Key + "%' or hregion like '" + Key + "%' );";
               }
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    HouseInfo hou = ConvertToEntity(dt.Rows[ax]);
                    houselist.Add(hou);
                }
                return houselist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static bool Save( HouseInfo h)
        {
            //Console.WriteLine("svsv");
            var sql = "";
            if (h.HouseId == -1)
            {
                sql = "insert into house(housename,houseno,housetype,hcity,hregion,harea,hroadno,userid) values ('" + h.HouseName + "','" + h.HouseNo + "','" + h.HouseType + "','" + h.HouseCity + "','" + h.HouseRegion + "','" + h.HouseArea + "','" + h.HouseRoadNo + "','" + Session.UserId + "');";
            }
            else
            {
                sql = "update  house set  housename ='" + h.HouseName + "',houseno= '" + h.HouseNo + "', housetype ='" + h.HouseType + "',hcity = '" + h.HouseCity + "', hregion = '" + h.HouseRegion + "',harea = '" + h.HouseArea + "', hroadno = '" + h.HouseRoadNo  + "' where houseid = " + h.HouseId + ";";
                
            }
            var row = DataAccess.ExecuteUpdateQuery(sql);
            if (row == 1)
            {
                return true;
            }
            return false;
        }
        public static List<HouseInfo> GetAll()
        {
            var houselist = new List<HouseInfo>();
            try
            {
                var sql = "select * from house where  userid=" + Session.UserId +";";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    HouseInfo hou = ConvertToEntity(dt.Rows[ax]);
                    houselist.Add(hou);
                }
                return houselist;
            }
            catch(Exception exc)
            {
                return null;
            }
        }
        public static List<HouseInfo> GetAllAdmin()
        {
            var houselist = new List<HouseInfo>();
            try
            {
                var sql = "select * from house ;";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    HouseInfo hou = ConvertToEntity(dt.Rows[ax]);
                    houselist.Add(hou);
                }
                return houselist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        private static HouseInfo ConvertToEntity (DataRow row)
        {
          if (row == null)
                return null ; 
          
          var h = new HouseInfo();
          h.HouseId = Convert.ToInt32( row["houseid"].ToString());
          h.HouseName = row["housename"].ToString();
          h.HouseNo = row["houseno"].ToString();
          h.HouseType = row["housetype"].ToString();
          h.HouseCity = row["hcity"].ToString();
          h.HouseRegion = row["hregion"].ToString();
          h.HouseArea = row["harea"].ToString();
          h.HouseRoadNo = row["hroadno"].ToString();
          h.UserId = Convert.ToInt32(row["userid"].ToString());
            return h;
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
                    house = ConvertToEntity(dt.Rows[ax]);

                }
                return house;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public static List<HouseInfo> GetSearchouseByAdmin(string Key)
        {
            var houselist = new List<HouseInfo>();
            try
            {
                string sql;
                if (string.IsNullOrEmpty(Key))
                    sql = "select * from house ;";
                else
                {
                    sql = "select * from house where  housename like '" + Key + "%' or housetype like '" + Key + "%' or hregion like '" + Key + "%' or harea like '" + Key + "%' ;";
                }
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    HouseInfo hou = ConvertToEntity2(dt.Rows[ax]);
                    houselist.Add(hou);
                }
                return houselist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        private static HouseInfo ConvertToEntity2(DataRow row)
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
          //  h.UserId = Convert.ToInt32(row["userid"].ToString());
            return h;
        }
    }
}
