using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Insert : System.Web.UI.Page
{
    private int testCounter = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack != true)
        {
            testCounter++;
        }
    }



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

        UserDataBaseHandler userDataBaseHandler = new UserDataBaseHandler();

        if (RadioButtonListGender.SelectedItem != null)
        {
            aUser.Gender = RadioButtonListGender.SelectedValue;
        }
        else aUser.Gender = "NA";

        try
        {
            if (userDataBaseHandler.InsertUserDataToDB(aUser))
            {
                Response.Write("<script>alert('Your information has been inserted successfully!');</script>");
                ClearAllFormElements();
            }
        }
        catch (SqlException sqlException)
        {
            Response.Write("<script>alert('Data could not be saved');</script>");
        }
        catch (Exception exception)
        {
            Response.Write("<script>alert('Error occured');</script>");
        }
    }

    private void ClearAllFormElements()
    {
        txtBoxFName.Text = null;
        txtBoxLName.Text = null;
        txtBoxEmail.Text = null;
        txtBoxContact.Text = null;
        txtBoxStreetNumber.Text = null;
        txtBoxStreetAddress.Text = null;
        txtBoxPostCode.Text = null;
        txtBoxDistrict.Text = null;
        txtBoxCountry.Text = null;
        RadioButtonListGender.ClearSelection();
    }
}

    

