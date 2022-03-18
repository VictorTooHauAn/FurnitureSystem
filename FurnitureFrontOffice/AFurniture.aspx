<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AFurniture.aspx.cs" Inherits="FurnitureFrontOffice.findFurniture" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFurnitureId" runat="server" Text="Code" Width="100px"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtFrnitureId" runat="server" Width="127px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            <br />
            <%-- show the error if a record was not found --%>
            <% if (lblError.Visible == true)
                {%>
            <asp:Label ID="lblError" runat="server" Text="Error" ForeColor="Red"></asp:Label>
            <br />
            <%} %>
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
            <asp:TextBox ID="txtPrice" runat="server" Width="127px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
