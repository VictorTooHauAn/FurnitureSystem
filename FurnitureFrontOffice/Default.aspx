<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FurnitureFrontOffice.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: bisque">
    <form id="form1" runat="server">
        <div>
            <h1> Furniture Management System  </h1>
            <asp:Button ID="btnCustomerSection" runat="server" Width="100px" Text="View Customer" OnClick="btnCustomerSection_Click" />
            &nbsp;
            &nbsp;
            <asp:Button ID="btnFurnitureSection" runat="server" Text="View Furniture" OnClick="btnFurnitureSection_Click" />

        </div>
    </form>
</body>
</html>
