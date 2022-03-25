<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDefault.aspx.cs" Inherits="FurnitureFrontOffice.CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

 p.MsoNormal
	{margin-top:0cm;
	margin-right:0cm;
	margin-bottom:10.0pt;
	margin-left:0cm;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomer" runat="server" Height="210px" Width="300px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Height="36px" Text="Add" Width="69px" OnClick="btnAdd_Click1" />
            <asp:Button ID="btnDelete" runat="server" Height="36px" Text="Delete" Width="69px" />
            <asp:Button ID="btnUpdate" runat="server" Height="36px" Text="Update" Width="69px" />
            <p align="center" class="MsoNormal" style="text-align:center">
                &nbsp;</p>

<!--EndFragment-->
</div>
    </form>
</body>
</html>
