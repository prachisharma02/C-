<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewStateDemo.WebForm1" %>
<%--rajor syntax--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="margin: 0 auto; height:300px;width:500px ;background-color:#e8b1a0; border-radius:7px">
    <form id="form1" runat="server">
        <h1 style="text-align: center; padding:20px; margin-top:200px">ViewState Demo using C#</h1>
       <p style="text-align: center; margin-top:30px">
            UserName: <asp:TextBox ID="TextBox1" runat="server" style="width: 200px; height:20px ; border: 2px solid #ccc;"></asp:TextBox>

            <br />
           <br />
            Password: <asp:TextBox ID="TextBox2" runat="server" style="width: 200px;height:20px; border: 2px solid #ccc; "></asp:TextBox>
            <br />
           <br />

            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Restore" />
        </p>
    </form>
        </div>
</body>
</html>
