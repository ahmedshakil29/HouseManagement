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
   public class BookRepo
    {

       public static List<BookInfo> GetSearchApart(string Key)
        {
            // string a = Session.UserId.ToString();
            var apartlist = new List<BookInfo>();
            try
            {
                string sql;
                if (string.IsNullOrEmpty(Key))
                    sql = "select apid,apno,aptype,rentprice,floorno,noofroom,size,status,house.* from house, apartment where house.houseid=apartment.houseid and status='Active' ;";
                else
                {
                    sql = "select apid,apno,aptype,rentprice,floorno,noofroom,size,status,house.* from house, apartment where house.houseid=apartment.houseid and status='Active' " + " and ( hregion like '" + Key + "%' or aptype like '" + Key + "%') ;";
                }
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    BookInfo apt = ConvertToEntity(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static List<BookInfo> GetSearchApartByUser(string Key)
        {
            // string a = Session.UserId.ToString();
            var apartlist = new List<BookInfo>();
            try
            {
                string sql;
                if (string.IsNullOrEmpty(Key))
                    sql = "select apid,apno,aptype,rentprice,floorno,noofroom,size,status,house.* from house, apartment where house.houseid=apartment.houseid and status='Active' and userid=" + Session.UserId + ";";
                else
                {
                    sql = "select apid,apno,aptype,rentprice,floorno,noofroom,size,status,house.* from house, apartment where house.houseid=apartment.houseid and status='Active' and userid=" + Session.UserId + " and ( hregion like '" + Key + "%' or aptype like '" + Key + "%') ;";
                }
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    BookInfo apt = ConvertToEntity(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static bool Save(BookInfo a)
        {
            var sql = "insert into book values ( '" + a.BookDate + "' ,'" + Session.UserName + "'," + 0 + "," + Session.UserId + "," + a.BookAprtId + " );";
            

            var row = DataAccess.ExecuteUpdateQuery(sql);
            if (row == 1)
            {
                return true;
            }
            return false;

        }
        public static bool Delete(int id)
        {
            var sql = "delete from book where bid = '" + id + "';";


            var row = DataAccess.ExecuteUpdateQuery(sql);
            if (row == 1)
            {
                return true;
            }
            return false;

        }
        public static bool Update(BookInfo a)
        {

            int i=0;
            if(a.BookIsAvtive==true)
            {
                i = 1;
            }
            if (a.BookIsAvtive == false)
            {
                i = 0;
            }
            var sql = "update book set  isactive=" + i + "  where bid=" + a.BookId + ";";


            var row = DataAccess.ExecuteUpdateQuery(sql);
            if (row == 1)
            {
                return true;
            }
            return false;

        }      
        public static List<BookInfo> GetAll()
        {
            var apartlist = new List<BookInfo>();
            try
            {
                var sql = "select apid,apno,aptype,rentprice,floorno,noofroom,size,status,house.* from house, apartment where house.houseid=apartment.houseid and status='Active'" + ";";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    BookInfo apt = ConvertToEntity(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static BookInfo GetBook(int id)
        {
            var book = new BookInfo();
            try
            {
                var sql = "select * from book where  apid="+ id+ ";";
                var dt = DataAccess.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    book = ConvertToEntityBook(dt.Rows[0]);
                }
              
                return book;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static BookInfo GetBook2(int id)
        {
            var book = new BookInfo();
            try
            {
                var sql = "select * from book where  bid=" + id + ";";
                var dt = DataAccess.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    book = ConvertToEntityBook(dt.Rows[0]);
                }

                return book;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static List<BookInfo> GetAllBookingLog(int isactive)
        {
            var apartlist = new List<BookInfo>();
            try
            {
                var sql = "select book.*,apno from book,apartment where book.apid=apartment.apid and isactive=" + isactive + "and apartment.userid=" + Session.UserId + ";";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    BookInfo apt = ConvertToEntityBook2(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static List<BookInfo> GetAllAdmin()
        {
            var apartlist = new List<BookInfo>();
            try
            {
                var sql = "select * from book;";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    BookInfo apt = ConvertToEntityBook2(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static List<BookInfo> GetAllOwner()
        {
            var apartlist = new List<BookInfo>();
            try
            {
                var sql = "select book.*,apno from book,apartment where book.apid=apartment.apid and isactive=" + 1 + "and apartment.userid=" + Session.UserId + ";";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    BookInfo apt = ConvertToEntityBook2(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public static List<BookInfo> GetAllBookingLogForOwner()
        {
            var apartlist = new List<BookInfo>();
            try
            {
                var sql = "select book.* from book,apartment,homeuser where book.apid=apartment.apid and homeuser.userid=apartment.userid and homeuser.userid=" + Session.UserId + ";";
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    BookInfo apt = ConvertToEntityBook(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }        
        private static BookInfo ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;

            var a = new BookInfo();
            a.BookAprtId = Convert.ToInt32(row["apid"].ToString());
            a.Bookapartsize = row["size"].ToString();
            a.BookAprtNo= row["apno"].ToString();
           // a.Bookapartspecification = row["specification"].ToString();
            a.Bookapartstatus = row["status"].ToString();
            a.Bookaparttype = row["aptype"].ToString();
           
            a.Bookfloor = Convert.ToInt32(row["floorno"].ToString());
            a.BookHouseArea = row["harea"].ToString();
            a.BookHouseCity= row["hcity"].ToString();
            a.BookHouseId = Convert.ToInt32(row["houseid"].ToString());
            a.BookHouseName = row["housename"].ToString();

            a.BookHouseNo = row["houseno"].ToString();
            a.BookHouseRegion = row["hregion"].ToString();
            a.BookHouseRoadNo = row["hroadno"].ToString();
            a.BookHouseType = row["housetype"].ToString();
          
            a.Bookrentprice =Convert.ToDouble( row["rentprice"].ToString());
            a.BookUserId = Convert.ToInt32(row["userid"].ToString());
           
            return a;
        }
        private static BookInfo ConvertToEntityBook(DataRow row)
        {
            if (row == null)
                return null;

            var a = new BookInfo();
            a.BookAprtId = Convert.ToInt32(row["apid"].ToString());
            a.BookDate = Convert.ToDateTime(row["bdate"].ToString());
            a.BookId = Convert.ToInt32(row["bid"].ToString());
            a.BookIsAvtive = Convert.ToBoolean(row["isactive"].ToString());
            a.BookRenterName = row["rentername"].ToString();
            //a.BookAprtNo = row["apno"].ToString();
           a.BookUserId = Convert.ToInt32(row["userid"].ToString());

            return a;
        }
        private static BookInfo ConvertToEntityBook2(DataRow row)
        {
            if (row == null)
                return null;

            var a = new BookInfo();
            a.BookAprtId = Convert.ToInt32(row["apid"].ToString());
            a.BookDate = Convert.ToDateTime(row["bdate"].ToString());
            a.BookId = Convert.ToInt32(row["bid"].ToString());
            a.BookIsAvtive = Convert.ToBoolean(row["isactive"].ToString());
            a.BookRenterName = row["rentername"].ToString();
          //  a.BookAprtNo = row["apno"].ToString();
            a.BookUserId = Convert.ToInt32(row["userid"].ToString());

            return a;
        }

        public static List<BookInfo> GetSearchApartByAdmin(string Key)
        {
            var apartlist = new List<BookInfo>();
            try
            {
                string sql;
                if (string.IsNullOrEmpty(Key))
                   sql = "select * from book;";
                else
                {
                    sql = "select * from book where   ( rentername like '" + Key + "%' ) ;";

                }
                var dt = DataAccess.GetDataTable(sql);
                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    BookInfo apt = ConvertToEntityBook2(dt.Rows[ax]);
                    apartlist.Add(apt);
                }
                return apartlist;
            }
            catch (Exception exc)
            {
                return null;
            }
        }





    }
}
