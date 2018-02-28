<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllUsersInfo.aspx.cs" Inherits="AllUsersInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        <asp:GridView ID="AllUserGridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
