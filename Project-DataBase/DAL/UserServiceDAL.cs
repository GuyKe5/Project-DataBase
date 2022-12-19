using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Project_DataBase.Classes;

namespace Project_DataBase.DAL
{
    public class UserServiceDAL
    {
        public static DataTable GetUserDataDAL(User user)
        {
            string query = $"exec [GetUserData] {user.userName},{user.password}";
            DataTable result=SQLHelper.SelectData(query);
            return result;

        }
    }
}