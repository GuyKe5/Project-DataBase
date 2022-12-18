using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Project_DataBase.DAL
{
    public class UserServiceDAL
    {
        public static GetId(string username,string password)
        {
            string query = $"exec [GetUserID] {username},{passsword}";
            return SQLHelper.SelectScalarToInt32(query);

                }
    }
}