<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CRUDOperation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:GridView runat="server"></asp:GridView>
    <form id="form1" runat="server"> 
        <div>
  
           
           
            &nbsp;
        <div>&nbsp;</div>
        <div>&nbsp;</div>
        <table>
            <tr>
                <td><asp:Label runat="server" Text="Enter name "></asp:Label></td>
                <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label runat="server" Text="Enter phone no  "></asp:Label> </td>
                <td><asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label runat="server" Text="Enter emailaddress "></asp:Label> </td>
                <td><asp:TextBox ID="TextBox3" runat="server" TextMode="Email"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label runat="server" Text="Enter passsowrd "></asp:Label></td>
                <td><asp:TextBox  ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
        </table>
        <asp:GridView runat="server"></asp:GridView>
            
                     <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
             <asp:Button runat="server" Text="insert"></asp:Button>
             <asp:Button runat="server" Text="update"></asp:Button>
            </div>
    </form>
</body>
</html>
