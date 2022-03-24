<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FurnitureEdit.aspx.cs" Inherits="FurnitureFrontOffice.FurnitureEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCategory" runat="server" Text="Category" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtCategory" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtName" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblWoodType" runat="server" Text="Wood type" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtWoodType" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblColour" runat="server" Text="Colour" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtColour" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblSize" runat="server" Text="Size" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtSize" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblStockNo" runat="server" Text="Pieces left" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtStockNo" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtPrice" runat="server" Width="127px"></asp:TextBox><br />
            <br />
            <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnEdit" runat="server" Height="26px" Text="Edit" Width="61px" OnClick="btnEdit_Click" style="margin-bottom: 0px" />
            <asp:Button ID="btnCancel" runat="server" Style="z-index: 1;" Text="Cancel" Height="26px" Width="61px" OnClick="btnCancel_Click" />

        </div>
    </form>
</body>
</html>
