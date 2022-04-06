<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paymentlst.aspx.cs" Inherits="FurnitureFrontOffice.paymentlst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 696px;
            height: 399px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        &nbsp;&nbsp;&nbsp;
            &nbsp;
            <br />
            <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="EmailAddress" DataValueField="EmailAddress" Height="259px" Width="394px"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:p2622897ConnectionString4 %>" SelectCommand="SELECT [EmailAddress] FROM [tblPayment]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Please Enter Payment No."></asp:Label>
            <br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="183px"></asp:TextBox>
            <br />
&nbsp;<asp:Button ID="Button4" runat="server" BackColor="#66CCFF" Font-Bold="True" Text="Apply" Width="75px" />
&nbsp;
            <asp:Button ID="Button5" runat="server" BackColor="#66CCFF" Font-Bold="True" Text="Display" Width="59px" />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" BackColor="#99FF66" Font-Bold="True" Text="Add " />
&nbsp;&nbsp;
            <asp:Button ID="btneEdit" runat="server" BackColor="#FF9966" Font-Bold="True" Text="Edit" Width="53px" />
&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" BackColor="Red" Font-Bold="True" Text="Delete" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
