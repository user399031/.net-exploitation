using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class ConnHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
        public static DataTable getDT(string strSQL)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //public static List<string> GetDistinceColoum(string strSQL, string str1)
        //{
        //    DataTable dt = GetDataTable(strSQL);
        //    List<string> strList = new List<string>();
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        string str = dr[str1].ToString();
        //        strList.Add(str);
        //    }
        //    return strList;
        //}
        //public static DataTable GetDistinceColoum(string strSQL)
    }
}
