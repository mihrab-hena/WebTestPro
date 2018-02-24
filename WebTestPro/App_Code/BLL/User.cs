using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public User()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private string firstName;
    private string lastName;
    private string gender;
    private string phoneNumber;
    private string email;
    private string streetNumber;
    private string streetAddress;
    private string postCode;
    private string district;
    private string country;

    private string fullName = "";

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string StreetNumber
    {
        get { return streetNumber; }
        set { streetNumber = value; }
    }

    public string StreetAddress
    {
        get { return streetAddress; }
        set { streetAddress = value; }
    }

    public string PostCode
    {
        get { return postCode; }
        set { postCode = value; }
    }

    public string District
    {
        get { return district; }
        set { district = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public bool InsertUser(User user)
    {
        UserDataBaseHandler userDataBaseHandler = new UserDataBaseHandler();
        return (userDataBaseHandler.InsertUserDataToDB(user));
    }

    public bool UpdateUser(User user)
    {
        UserDataBaseHandler userDataBaseHandler = new UserDataBaseHandler();
        return (userDataBaseHandler.UpdateUserDataToDB(user));
    }

}