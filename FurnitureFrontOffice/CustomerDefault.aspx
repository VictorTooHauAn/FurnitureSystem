<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDefault.aspx.cs" Inherits="FurnitureFrontOffice.CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomer" runat="server" Height="188px" Width="229px"></asp:ListBox>
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnAdd" runat="server" Height="36px" OnClick="btnAdd_Click1" Text="Add" Width="69px" />
            <asp:Button ID="btnDelete" runat="server" Height="36px" OnClick="btnDelete_Click" Text="Delete" Width="69px" />
            <asp:Button ID="btnUpdate" runat="server" Height="36px" OnClick="btnUpdate_Click" Text="Update" Width="69px" />
        </div>
    </form>
</body>
</html>
