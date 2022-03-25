<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDefault.aspx.cs" Inherits="FurnitureFrontOffice.CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            text-decoration: underline;
        }
    </style>
</head>
<body  style="background-color: bisque">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <span class="auto-style2"><strong>Customer </strong></span>
            <br />
            <asp:ListBox ID="lstCustomer" runat="server" Height="188px" Width="229px"></asp:ListBox>
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnAdd" runat="server" Height="36px" OnClick="btnAdd_Click1" Text="Add" Width="69px" />
            <asp:Button ID="btnDelete" runat="server" Height="36px" OnClick="btnDelete_Click" Text="Delete" Width="69px" />
            <asp:Button ID="btnUpdate" runat="server" Height="36px" OnClick="btnUpdate_Click" Text="Update" Width="69px" />
            <asp:Button ID="btnFind" runat="server" Height="36px" OnClick="btnFind_Click" style="margin-top: 0px" Text="Find" Width="57px" />
            <br />
            <asp:Button ID="btnHomepage" runat="server" Height="40px" OnClick="btnHomepage_Click" Text="Homepage" Width="138px" />
        </div>
    </form>
</body>
</html>
