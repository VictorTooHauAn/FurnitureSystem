<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AFurniture.aspx.cs" Inherits="FurnitureFrontOffice.findFurniture" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCategory" runat="server" Text="Category" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TextBox1" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TextBox2" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblWoodType" runat="server" Text="Wood type" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TextBox3" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblColour" runat="server" Text="Colour" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TextBox4" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblSize" runat="server" Text="Size" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TextBox5" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblStockNo" runat="server" Text="Pieces left" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TextBox6" runat="server" Width="127px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TextBox7" runat="server" Width="127px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
