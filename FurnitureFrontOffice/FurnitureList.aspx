<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FurnitureList.aspx.cs" Inherits="FurnitureFrontOffice.FurnitureList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstFurniture" runat="server" Style="z-index: 1; height: 197px; width: 327px"></asp:ListBox>
            <br />
            <asp:Label ID="lblError" runat="server" Style="z-index: 1; width: 393px"></asp:Label>

            <br />
            <br />
            <asp:Label ID="lblName" runat="server" Style="z-index: 1; width: 317px" Text="Please Enter a furniture name"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server" Style="z-index: 1; width: 169px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" Style="z-index: 1; width: 119px" Text="Apply" />
            <asp:Button ID="btnDisplayAll" runat="server" Height="26px" Style="z-index: 1; width: 119px" Text="Display All" />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Style="z-index: 1;" Text="Add" Height="26px" Width="55px" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Style="z-index: 1;" Text="Edit" Height="26px" Width="55px" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Style="z-index: 1; right: 249px" Text="Delete" Height="26px" Width="55px" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>
