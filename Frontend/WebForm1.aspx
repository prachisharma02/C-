<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Frontend.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar">  <ul>
            <li>Home</li>
            <li>About</li>
            <li>Contact</li>
            <li><asp:DropDownList runat="server">
                <asp:ListItem Value="">Please Select</asp:ListItem>  
            <asp:ListItem>College Task </asp:ListItem>  
            <asp:ListItem>Office Task</asp:ListItem>  
            <asp:ListItem>Self-Care</asp:ListItem>  
            <asp:ListItem>your Work</asp:ListItem>  
            </asp:DropDownList></li>
        </ul>
    </nav>

  
      

        <div class="container">
             <h1 style="text-align:center">To-Do List</h1>
             <ul id="todo-list"></ul>
            <div class="todo-form">          
             <asp:CheckBox ID="CheckBox1" runat="server" Text="Read About ADO.NET" /><br/>
             <asp:CheckBox ID="CheckBox2" runat="server" Text="Install IIS" />  <br/>
             <asp:CheckBox ID="CheckBox3" runat="server" Text="Install SSME" /> <br/> 
             <asp:CheckBox ID="CheckBox4" runat="server" Text="Create a user interface" /><br/><br/>  
             <asp:TextBox runat="server"></asp:TextBox>
             <button type="submit">Add Task</button>
            </div>
             <br /><br />
             <asp:Calendar ID="MyCalendar" runat="server" SelectionMode="Day"></asp:Calendar>
        </div>
    </form>
</body>
</html>
