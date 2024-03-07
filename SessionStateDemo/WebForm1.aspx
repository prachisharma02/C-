<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SessionStateDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <p>Provide Following Details</p>  
    <table class="auto-style1">  
        <tr>  
            <td class="auto-style2">Email</td>  
            <td>  
                <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2">Password</td>  
            <td>  
                <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2"> </td>  
            <td>  
                <asp:Button ID="login" runat="server" Text="Login" OnClick="Login_Click" />  
            </td>  
        </tr>  
    </table>  
    <br />  
    
        </div>
    </form>
</body>
</html>
