using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserDataBaseHandler
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

    public bool UpdateUserDataToDB(User anUser)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBHotel"].ConnectionString;
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        SqlCommand sqlComnd = new SqlCommand();
        sqlComnd.Connection = sqlConnection;

        sqlComnd.Parameters.AddWithValue("@FirstName", anUser.FirstName);
        sqlComnd.Parameters.AddWithValue("@LastName", anUser.LastName);
        sqlComnd.Parameters.AddWithValue("@Gender", anUser.Gender);
        sqlComnd.Parameters.AddWithValue("@Phone", anUser.PhoneNumber);
        sqlComnd.Parameters.AddWithValue("@Email", anUser.Email);
        sqlComnd.Parameters.AddWithValue("@StreetAddress", anUser.StreetNumber + " " + anUser.StreetAddress);
        sqlComnd.Parameters.AddWithValue("@PostCode", anUser.PostCode);
        sqlComnd.Parameters.AddWithValue("@District", anUser.District);
        sqlComnd.Parameters.AddWithValue("@Country", anUser.Country);

        return true;
    }
}