using Project_DataBase.Classes;
using Project_DataBase.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Project_DataBase.BLL
{
    public class UserService
    { 
        public static void GetUserData(string username,string password)
        {
            DataTable data = UserServiceDAL.GetUserDataDAL(username, password);
            Console.WriteLine(data);


        }
    }
}