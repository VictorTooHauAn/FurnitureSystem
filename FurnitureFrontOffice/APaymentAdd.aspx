<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APaymentAdd.aspx.cs" Inherits="FurnitureFrontOffice.APaymentAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 592px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 266px;
        }
        .auto-style4 {
            height: 23px;
            width: 266px;
        }
        .auto-style5 {
            height: 30px;
        }
        .auto-style6 {
            height: 31px;
        }
        .auto-style7 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1"> 
<tr> 
    <td> &nbsp;<strong>&nbsp; &nbsp;Add Form:</strong></td>
</tr>
<tr>
    <td class="auto-style3">           
        PaymentID<strong>:</strong></td>
      <td>           
          <asp:TextBox ID="txtPaymentID" runat="server"></asp:TextBox>
    </td>
</tr>
        
<tr>
    <td class="auto-style3">           
        CustomerUserID:</td>
      <td>           
          <asp:TextBox ID="txtCustomerUserID" runat="server"></asp:TextBox>
    </td>
</tr>
        
<tr>
    <td class="auto-style4">           
        EmailAddress:</td>
      <td class="auto-style2">           
          <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
    </td>
</tr>
        <tr> 
            <td class="auto-style5"> Amount:</td>
            <td class="auto-style5"> 
                <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr> 
            <td class="auto-style7"> DateOfPayment:</td>
            <td class="auto-style7"> 
                <asp:TextBox ID="txtDateOfPayment" runat="server"></asp:TextBox>
             </td>
        </tr>
         <tr> 
            <td> TypeOfPayment:</td>
            <td> 
                <asp:TextBox ID="txtTypeOfPayment" runat="server"></asp:TextBox>
             </td>
        </tr>
         <tr> 
            <td class="auto-style6"> </td>
            <td class="auto-style6"> </td>
        </tr>
    </table>
    </form>
</body>
</html>
