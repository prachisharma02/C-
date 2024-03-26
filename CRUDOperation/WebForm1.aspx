<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CRUDOperation.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        #div1{
            margin: 50px auto ; height:fit-content; width:500px; padding:30px; background-color:antiquewhite 
        }
        .button{
            height:30px;
            width:100px;
            border:0.5px solid grey;
                border-radius:7px;
                background-color:chocolate;
                color:wheat
            
        }
    </style>
    <form id="form1" runat="server"> 
        <div ID="div1">
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
            <tr>
                <td>&nbsp</td>
                <td>&nbsp</td>
            </tr>
             <tr>
     
     <td colspan="2">        <asp:GridView ID="grid" runat="server"></asp:GridView>
</td>
 </tr>
        </table>
            <br/>
             <br/>
 

            
                     <asp:Button ID="Button1" CssClass="button" runat="server" onclick="Button1_Click" Text="Insert" />
                     <asp:Button ID="Button2" CssClass="button" runat="server" onclick="Button2_Click" Text="Delete" />
                     <asp:Button ID="Button3"  CssClass="button" runat="server" onclick="Button3_Click" Text="Update" />
                     <asp:Button ID="Button4" CssClass="button" runat="server" onclick="Button4_Click" Text="Show details" />

            </div>
    </form>
</body>
</html>
