using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HouseManagement1.DataLayer;
using HouseManagement1.EntityLayer;
using HouseManagement1.FrameWorkLayer;

namespace HouseManagement1.RepositoryLayer
{
   public  class HomeUserRepo
    {
       public static List<HomeUserInfo> GetSearchUserByAdmin(string Key)
       {
           // string a = Session.UserId.ToString();
           var userlist = new List<HomeUserInfo>();
           try
           {
               string sql;
               if (string.IsNullOrEmpty(Key))
                   sql = "select * from homeuser ;";
               else
               {
                   sql = "select * from homeuser where  name like '" + Key + "%' or phone like '" + Key + "%' or blood like '" + Key + "%' ;";
               }
               var dt = DataAccess.GetDataTable(sql);
               for (int ax = 0; ax < dt.Rows.Count; ax++)
               {
                   HomeUserInfo apt = ConvertToEntity2(dt.Rows[ax]);
                   userlist.Add(apt);
               }
               return userlist;
           }
           catch (Exception exc)
           {
               return null;
           }
       }

       public static bool LogIn(HomeUserInfo u)
       {
           string sql = "select * from homeuser where username = '" + u.UserName + "' and password = '" + u.UserPassword + "';";
           var ds = DataAccess.GetDataSet(sql);
           if (ds.Tables[0].Rows.Count == 1)
           {
               Session.UserId = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
               Session.UserName = ds.Tables[0].Rows[0][1].ToString();
               Session.UserTypeId = Convert.ToInt32(ds.Tables[0].Rows[0][7].ToString());
               return true;
           }
           else
           {
               return false;
           }
       }
       public static HomeUserInfo GetUser(int id)
       {

           try
           {
               var user = new HomeUserInfo();
               string sql = "select * from homeuser where userid=" + id + ";";
               var dt = DataAccess.GetDataTable(sql);
               if (dt.Rows.Count > 0)
               {
                   user = ConvertToEntity(dt.Rows[0]);
               }

               return user;
           }
           catch (Exception e)
           {
               return null;
           }
             
       }
       public static List<HomeUserInfo> GetAllAdmin()
       {
           var apartlist = new List<HomeUserInfo>();
           try
           {
               var sql = "select * from homeuser;";
               var dt = DataAccess.GetDataTable(sql);
               for (int ax = 0; ax < dt.Rows.Count; ax++)
               {
                   HomeUserInfo apt = ConvertToEntity(dt.Rows[ax]);
                   apartlist.Add(apt);
               }
               return apartlist;
           }
           catch (Exception exc)
           {
               return null;
           }
       }      
       public static bool Save(HomeUserInfo a)
       {
          // Console.WriteLine("Data  Complete");

          
          // var sql2 = "insert into house(houseid,housename,houseno,housetype,hcity,hregion,harea,hroadno,userid) values ('" + h.HouseId + "','" + h.HouseName + "','" + h.HouseNo + "','" + h.HouseType + "','" + h.HouseCity + "','" + h.HouseRegion + "','" + h.HouseArea + "','" + h.HouseRoadNo + "','" + h.UserId + "');";
           //  var sql = "update table homeuse set (userid = " + a.UserId + ", username= '" + a.UserName + "' , password='" + a.UserPassword + "' ,name='" + a.UserRealName + "',phone='" + a.UserPhone + "',email='" + a.UserEmail + "',blood='" + a.UserBlood + "',usertypeid='" + a.UserTypeId + "' where userid = " + a.UserId + " );";
           
           var sql = "insert into homeuser (username,password,name,phone,email,blood,usertypeid) values ( '" + a.UserName + "' , '" + a.UserPassword + "' ,'" + a.UserRealName + "','" + a.UserPhone + "','" + a.UserEmail + "','" + a.UserBlood + "'," + a.UserTypeId + ");";
           var row = DataAccess.ExecuteUpdateQuery(sql);
           if (row == 1)
           {
               return true;
           }
           return false;

       }
       public static bool Update(HomeUserInfo a)
       {
           // Console.WriteLine("Data  Complete");

           var sql = "update homeuser set  username='" + a.UserName + "' , password= '" + a.UserPassword + "' , name='" + a.UserRealName + "', phone='" + a.UserPhone + "', email= '" + a.UserEmail + "', blood='" + a.UserBlood + "'" +  "  where userid=" + Session.UserId + ";";
           // var sql2 = "insert into house(houseid,housename,houseno,housetype,hcity,hregion,harea,hroadno,userid) values ('" + h.HouseId + "','" + h.HouseName + "','" + h.HouseNo + "','" + h.HouseType + "','" + h.HouseCity + "','" + h.HouseRegion + "','" + h.HouseArea + "','" + h.HouseRoadNo + "','" + h.UserId + "');";
           //  var sql = "update table homeuse set (userid = " + a.UserId + ", username= '" + a.UserName + "' , password='" + a.UserPassword + "' ,name='" + a.UserRealName + "',phone='" + a.UserPhone + "',email='" + a.UserEmail + "',blood='" + a.UserBlood + "',usertypeid='" + a.UserTypeId + "' where userid = " + a.UserId + " );";

           var row = DataAccess.ExecuteUpdateQuery(sql);
           if (row == 1)
           {
               return true;
           }
           return false;

       }
       private static HomeUserInfo ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;

            var a = new HomeUserInfo();
           
            a.UserId = Convert.ToInt32(row["userid"].ToString());
            a.UserName = row["username"].ToString();
            a.UserPassword = row["password"].ToString();
            a.UserRealName = row["name"].ToString();
            a.UserPhone = row["phone"].ToString();
            a.UserEmail = row["email"].ToString();
            a.UserBlood = row["blood"].ToString();
            a.UserTypeId = Convert.ToInt32(row["usertypeid"].ToString());
            
            return a;
        }
       private static HomeUserInfo ConvertToEntity2(DataRow row)
       {
           if (row == null)
               return null;

           var a = new HomeUserInfo();

          a.UserId = Convert.ToInt32(row["userid"].ToString());
         //  a.UserName = row["username"].ToString();
          // a.UserPassword = row["password"].ToString();
           a.UserRealName = row["name"].ToString();
           a.UserPhone = row["phone"].ToString();
           a.UserEmail = row["email"].ToString();
           a.UserBlood = row["blood"].ToString();
          // a.UserTypeId = Convert.ToInt32(row["usertypeid"].ToString());

           return a;
       }
        
    }
 }

