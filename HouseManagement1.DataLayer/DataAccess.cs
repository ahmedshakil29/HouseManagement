using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HouseManagement1.DataLayer
{
    public static class DataAccess
    {
        private static SqlConnection sqlcon;
        public static SqlConnection SqlCon
        {
            get
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(@"Data Source=DESKTOP-ID70KDG\SQLEXPRESS;Initial Catalog=home;Persist Security Info=True;User ID=sa;Password=123456");
                }
                else if (sqlcon.State != ConnectionState.Open)
                {
                    sqlcon.Open();
                }
                return sqlcon;
                //sqlCon = new SqlConnection(@"Data Source=DESKTOP-ID70KDG\SQLEXPRESS;Initial Catalog=HomeManagement;User ID=sa;Password=123456");
                //sqlCon.Open();
                //return sqlCon;
            }
        }
        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, SqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }
        public static int  ExecuteUpdateQuery(string query)
        {
            //this.QueryText(sql);
            //int u = this.Sqlcom.ExecuteNonQuery();
            //return u;
            SqlCommand sqcom = new SqlCommand(query, SqlCon);
           sqcom.ExecuteNonQuery();
           return 1;
        }


    }

}
/*
 private static SqlConnection sqlCon;
        public static SqlConnection SqlCon
        {
            get
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(@"Data Source=DESKTOP-ID70KDG\SQLEXPRESS;Initial Catalog=HomeManagement;User ID=sa;Password=123456");
                }
                else if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }
                return sqlCon;

            }
        }
        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, SqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }
        public static int ExecuteUpdateQuery(string query)
        {
            //this.QueryText(sql);
            //int u = this.Sqlcom.ExecuteNonQuery();
            //return u;
            SqlCommand sqcom = new SqlCommand(query, sqlCon);
            return sqcom.ExecuteNonQuery();
        }*/