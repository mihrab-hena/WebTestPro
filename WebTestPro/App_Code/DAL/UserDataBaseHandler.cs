using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// UserDataBaseHandler class provides support for hendling data of users from Database
/// </summary>
public class UserDataBaseHandler
{
    private bool successStatus;
    public UserDataBaseHandler()
    {
        //
        // TODO: Add constructor logic here
        //
        successStatus = false;
    }

    public bool InsertUserDataToDB(User anUser)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBHotel"].ConnectionString;
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        SqlCommand sqlComnd = new SqlCommand();
        sqlComnd.Connection = sqlConnection;
        sqlComnd.CommandText = "INSERT INTO UserInfo" +
                               "(FirstName,LastName,Gender,Phone,Email,StreetAddress,PostCode,District,Country)" +
                               " VALUES(@FirstName,@LastName,@Gender,@Phone,@Email,@StreetAddress,@PostCode,@District,@Country);";
        sqlComnd.Parameters.AddWithValue("@FirstName",anUser.FirstName);
        sqlComnd.Parameters.AddWithValue("@LastName",anUser.LastName);
        sqlComnd.Parameters.AddWithValue("@Gender",anUser.Gender);
        sqlComnd.Parameters.AddWithValue("@Phone",anUser.PhoneNumber);
        sqlComnd.Parameters.AddWithValue("@Email",anUser.Email);
        sqlComnd.Parameters.AddWithValue("@StreetAddress", anUser.StreetNumber + " "+ anUser.StreetAddress);
        sqlComnd.Parameters.AddWithValue("@PostCode",anUser.PostCode);
        sqlComnd.Parameters.AddWithValue("@District",anUser.District);
        sqlComnd.Parameters.AddWithValue("@Country",anUser.Country);

        try
        {
            sqlConnection.Open();
            sqlComnd.ExecuteNonQuery();
            successStatus = true;
        }
        finally
        {
            if (sqlConnection != null)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
        return successStatus;
    }

    //public bool UpdateUserDataToDB(User anUser)
    //{
    //    string connectionString = ConfigurationManager.ConnectionStrings["DBHotel"].ConnectionString;
    //    SqlConnection sqlConnection = new SqlConnection(connectionString);
    //    SqlCommand sqlComnd = new SqlCommand();
    //    sqlComnd.Connection = sqlConnection;

    //    sqlComnd.Parameters.AddWithValue("@FirstName", anUser.FirstName);
    //    sqlComnd.Parameters.AddWithValue("@LastName", anUser.LastName);
    //    sqlComnd.Parameters.AddWithValue("@Gender", anUser.Gender);
    //    sqlComnd.Parameters.AddWithValue("@Phone", anUser.PhoneNumber);
    //    sqlComnd.Parameters.AddWithValue("@Email", anUser.Email);
    //    sqlComnd.Parameters.AddWithValue("@StreetAddress", anUser.StreetNumber + " " + anUser.StreetAddress);
    //    sqlComnd.Parameters.AddWithValue("@PostCode", anUser.PostCode);
    //    sqlComnd.Parameters.AddWithValue("@District", anUser.District);
    //    sqlComnd.Parameters.AddWithValue("@Country", anUser.Country);

    //    return true;
    //}

    public List<User> GetAllUsers()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBHotel"].ConnectionString;
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        SqlCommand sqlComnd = new SqlCommand();
        sqlComnd.Connection = sqlConnection;
        SqlDataReader sqlDataReader = null;
        List<User> userList = new List<User>();
        sqlComnd.CommandText = "SELECT TOP (20) [UserID], [FirstName] ,[LastName]" +
                                ",[Gender] ,[Phone] ,[Email] ,[StreetAddress] ,[PostCode]" +
                                ",[District] ,[Country] FROM[htlMng].[dbo].[UserInfo]";
        try
        {
            sqlConnection.Open();
            sqlDataReader = sqlComnd.ExecuteReader();
            
            while (sqlDataReader.Read())
            {
                User aUser = new User();
                
                aUser.FirstName = (sqlDataReader["FirstName"] ?? "" ).ToString();
                aUser.LastName = (sqlDataReader["LastName"] ?? "" ).ToString();
                aUser.Gender = (sqlDataReader["Gender"] ?? "" ).ToString();
                aUser.PhoneNumber = (sqlDataReader["Phone"] ?? "" ).ToString();
                aUser.Email = (sqlDataReader["Email"] ?? "" ).ToString();
                aUser.StreetNumber = "";
                aUser.StreetAddress = (sqlDataReader["StreetAddress"] ?? "" ).ToString();
                aUser.PostCode = (sqlDataReader["PostCode"] ?? "" ).ToString();
                aUser.District = (sqlDataReader["District"] ?? "" ).ToString();
                aUser.Country = (sqlDataReader["Country"] ?? "" ).ToString();
                userList.Add(aUser);
            }
        }
        finally
        {
            if (sqlConnection != null)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            if (sqlDataReader != null)
            {
                sqlDataReader.Close();
            }
        }
        return userList;
    }
}