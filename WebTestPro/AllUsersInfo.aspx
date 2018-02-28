<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllUsersInfo.aspx.cs" Inherits="AllUsersInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Responsive GridView in ASP.NET</title>  
    <meta charset="utf-8" />  
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />  
    <link href="Content/bootstrap.cosmo.min.css" rel="stylesheet" />  
    <link href="Content/StyleSheet.css" rel="stylesheet" />   
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="AllUserInfoForm" runat="server">
        <div class="auto-style1" style="text-align: center">
            All Users</div>
        <div class="row">  
            <div class="col-lg-12 ">  
                <div class="table-responsive">
                    <asp:GridView ID="AllUserGridView" Width="70%" runat="server" CssClass="table table-striped table-bordered table-hover">
                    </asp:GridView>
                </div>
            </div>
        </div>
        <asp:LinkButton ID="linkBtnGoBack" runat="server" OnClick="linkBtnGoBack_Click">Go Back</asp:LinkButton>
    </form>
</body>
</html>
