<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FurnitureDelete.aspx.cs" Inherits="FurnitureFrontOffice.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: bisque">
    <form id="form1" runat="server">
        <div>
            <p> Are you sure you want to delete this furniture?</p>
            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
            &nbsp;
            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>
