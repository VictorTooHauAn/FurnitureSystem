<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FurnitureList.aspx.cs" Inherits="FurnitureFrontOffice.FurnitureList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: bisque">
    <form id="form1" runat="server">
        <div>
            <h1>A list of all furniture categories</h1>
            <p>Select a furniture to edit or delete </p>
            <asp:ListBox ID="lstFurniture" runat="server" Style="z-index: 1; height: 197px; width: 327px"></asp:ListBox>
            <br />
            <asp:Label ID="lblError" runat="server" Style="z-index: 1; width: 393px"></asp:Label>

            <br />
            <br />
            <asp:Label ID="lblName" runat="server" Style="z-index: 1; width: 317px" Text="Enter a furniture category to filter by"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server" Style="z-index: 1; " Width="243px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" Height="26px" Style="z-index: 1; width: 119px" Text="Filter" OnClick="btnApply_Click" />
            <asp:Button ID="btnDisplayAll" runat="server" Height="26px" Style="z-index: 1; width: 119px" Text="Display All" OnClick="btnDisplayAll_Click" />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Style="z-index: 1;" Text="Add new" Height="26px" Width="81px" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Style="z-index: 1;" Text="Edit" Height="26px" Width="55px" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Style="z-index: 1; right: 249px" Text="Delete" Height="26px" Width="55px" OnClick="btnDelete_Click" />
            <br />
            <br />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
