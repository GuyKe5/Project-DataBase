using Project_DataBase.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project_DataBase.Classes;
using Project_DataBase.DAL;
namespace Project_DataBase
{
    public partial class WebForm1 : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable s = SQLHelper.SelectData("select * from Users");
            UserService.GetUserData("1","9");
        }
    }
}