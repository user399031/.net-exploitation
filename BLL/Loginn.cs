using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
   public class Loginn
    {
       //public static DataTable IsLogin(string strUsername,string strUserPwd)
       //{
       //    string strSQL = "select * from myConn where (username='" + strUsername + "' and userpassword='" + strUserPwd + "')";
       //    DataTable dt = ConnHelper.getDT(strSQL);
       //    return dt;
       //}
       //public static DataTable Reboll(string strSQL)
       //{
       //    DataTable dt = ConnHelper.getDT(strSQL);
       //    return dt;
       //}
       public static int check(string name, string password)
       {
           string strSQL = "select * from myConn where username='" + name + "'";
           DataTable dt = ConnHelper.getDT(strSQL);
           if (dt.Rows[0]["username"].ToString() == name && dt.Rows[0]["userpassword"].ToString() == password)
           {
               return (int)dt.Rows[0]["ID"];
           }
           else
           {
               return 5;
           }
       }
    }
}
