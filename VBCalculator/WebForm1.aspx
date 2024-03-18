<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="VBCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="margin:100px auto; background-color:burlywood; padding:30px; width:500px; height:130px">
    <form id="form1" runat="server">
         <div style="margin:auto">
        <asp:Label runat="server">Num1</asp:Label>
        <asp:TextBox ID="txtNum1" runat="server" TextMode="Number"></asp:TextBox> <br />
 <br />
        <asp:Label runat="server">Num2</asp:Label>
        <asp:TextBox ID="txtNum2" runat="server" TextMode="Number"></asp:TextBox>
      <br />
 <br />
                     <asp:Label runat="server" Text="Result"></asp:Label>

      <asp:TextBox ID="TextBox3" runat="server" TextMode="Number" ></asp:TextBox>
         <br />
         <br />
      <asp:Button ID="Add" runat="server" onclick="Add_Click" Text="Add" />
      <asp:Button ID="Subtract" runat="server" onclick="Subtract_Click" Text="Subtract" />     
      <asp:Button ID="Multiply" runat="server" onclick="Multiply_Click" Text="Multiply" />
      <asp:Button ID="Divide" runat="server" onclick="Divide_Click" Text="Divide" />
      <asp:Button ID="Modulus" runat="server" onclick= "Modulus_Click" Text="Modulus" />
              <br />
 <br />
<asp:RequiredFieldValidator ID="rfvNum2" runat="server" ControlToValidate="txtNum2" ErrorMessage="Please enter a number for Num2." ForeColor="Red" />
              <br />
 <br />
<asp:RequiredFieldValidator ID="rfvNum1" runat="server" ControlToValidate="txtNum1" ErrorMessage="Please enter a number for Num1." ForeColor="Red" />

    </div>
    </form>
        </div>
</body>
</html>
