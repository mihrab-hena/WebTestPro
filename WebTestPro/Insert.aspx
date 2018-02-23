<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Insert.aspx.cs" Inherits="Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid" align="center">
            <!--div class="jumbotron"></!--div-->
            <div class="form-group row">
                <label for="txtBoxFName" class="col-sm-2 col-form-label" align="right">First Name</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtBoxFName" placeholder="First Name" class="form-control" runat="server" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="txtBoxFName" class="col-sm-2 col-form-label">Last Name</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtBoxLName" placeholder="Last Name" class="form-control" runat="server" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="txtBoxContact" class="col-sm-2 col-form-label">Gender</label>
                <div class="col-sm-4">
                    <asp:RadioButton ID="Male" runat="server" />
                    <asp:RadioButton ID="Female" runat="server" />
                </div>
            </div>
            <div class="form-group row">
                <label for="txtBoxContact" class="col-sm-2 col-form-label">Contact Number</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtBoxContact" placeholder="Phone number" class="form-control" runat="server" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="txtBoxEmail" class="col-sm-2 col-form-label">Email</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtBoxEmail" placeholder="Email" class="form-control" runat="server" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="txtBoxStreetNumber" class="col-sm-2 col-form-label">Street Number</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtBoxStreetNumber" placeholder="Street Number" class="form-control" runat="server" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="txtBoxStreetAddress" class="col-sm-2 col-form-label">Street Name</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtBoxStreetAddress" placeholder="Street Name" class="form-control" runat="server" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="txtBoxPostCode" class="col-sm-2 col-form-label">Post Code</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtBoxPostCode" placeholder="Post Code" class="form-control" runat="server" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="txtBoxDistrict" class="col-sm-2 col-form-label">District</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtBoxDistrict" placeholder="District or City" class="form-control" runat="server" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label for="txtBoxCountry" class="col-sm-2 col-form-label">Country</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtBoxCountry" placeholder="Country" class="form-control" runat="server" ></asp:TextBox>
                </div>
            </div>
            <div class="col-sm-4">
                <asp:Button ID="btnGender" runat="server" Text="Submit" class="btn btn-default" OnClick="btnSubmit_Click"/>
            </div>
        
        </div>
    </form>
</body>
</html>
