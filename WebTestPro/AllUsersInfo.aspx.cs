using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AllUsersInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UserDataBaseHandler userDataBaseHandler = new UserDataBaseHandler();
        List<User> userList = new List<User>();


        try
        {
            userList = userDataBaseHandler.GetAllUsers();
            AllUserGridView.DataSource = userList;
            AllUserGridView.DataBind();
        }
        catch (SqlException sqlException)
        {
            Response.Write("<script>alert('Error occured while retriving data from Database');</script>");
        }
        catch (Exception exceptoinObj)
        {
            Response.Write("<script>alert('Error occured');</script>");
        }
    }
}