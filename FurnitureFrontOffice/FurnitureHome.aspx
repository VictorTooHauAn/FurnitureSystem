<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FurnitureHome.aspx.cs" Inherits="FurnitureFrontOffice.FurnitureHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFind" runat="server" Text="Find a furniture" OnClick="btnFind_Click" />
            &nbsp;
            <asp:Button ID="btnAlter" runat="server" Text="Alter a furniture" OnClick="btnAlter_Click" />
        </div>
    </form>
</body>
</html>
