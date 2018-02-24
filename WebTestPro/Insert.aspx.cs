using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private bool successStatus = false;


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        User aUser = new User();
        aUser.FirstName = txtBoxFName.Text;
        aUser.LastName = txtBoxLName.Text;
        aUser.PhoneNumber = txtBoxContact.Text;
        aUser.Email = txtBoxEmail.Text;
        aUser.StreetNumber = txtBoxStreetNumber.Text;
        aUser.StreetAddress = txtBoxStreetAddress.Text;
        aUser.PostCode = txtBoxPostCode.Text;
        aUser.District = txtBoxDistrict.Text;
        aUser.Country = txtBoxCountry.Text;

        if (RadioButtonListGender.SelectedItem != null)
        {
            aUser.Gender = RadioButtonListGender.SelectedValue;
        }
        aUser.InsertUser(aUser);

        //UserDataBaseHandler userDataBaseHandler = new UserDataBaseHandler();
        //successStatus = userDataBaseHandler.InsertUserDataToDB(aUser);
        
    }
}

    

