<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="CRUDOperation.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
    <link rel="stylesheet" href="StyleSheet1.css" />

</head>
<body>

        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

    <form id="form1" runat="server">
            <nav runat="server">
        <nav class="navbar navbar-expand-lg bg-dark">
  <div class="container-fluid">
    <a class="navbar-brand navtext" href="WebForm3.aspx">BIOGRAPHY</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link  navtext" aria-current="page" href="WebForm1.aspx">ADD STUDENT</a>
        </li>
        <li class="nav-item">
          <a class="nav-link navtext" href="WebForm5.aspx">EDIT DETAILS</a>
        </li>
        <li class="nav-item">
          <a class="nav-link navtext" href="WebForm4.aspx">SHOW ALL DETAILS</a>
        </li>
       
      </ul>
    </div>
  </div>
</nav>
    </nav>
        <div class="showlist">
            <h4>Student List</h4>
<asp:GridView ID="grid" runat="server" OnRowEditing="grid_RowEditing" CssClass="myGrid" AutoGenerateColumns="False">
    <Columns>
     <asp:TemplateField HeaderText="ID">
      <ItemTemplate >
 <asp:Label ID="Label2" runat="server" Text='<%# Bind("id") %>'></asp:Label>  
 </ItemTemplate>
     </asp:TemplateField>
        <asp:TemplateField HeaderText="Name">
            <EditItemTemplate>  
            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>  
            </EditItemTemplate>
            <ItemTemplate >
            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Name") %>'></asp:Label>  
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Phone No">
            <ItemTemplate>
                <%# Eval("PhoneNo") %>
            </ItemTemplate>
            
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Email">
            <ItemTemplate>
                <%# Eval("Email") %>
            </ItemTemplate>
           
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Password">
            <ItemTemplate>
                <%# Eval("Password") %>  </ItemTemplate>
           
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Actions">
            <ItemTemplate>
                <asp:Button ID="Button3" CssClass="edit" runat="server" Text="Edit" OnClick="Button3_Click" CommandArgument='<%# Eval("Name") %>' />
                <asp:Button ID="Button2"  CssClass="delete" onclick="Button2_Click" runat="server"  Text="Delete"  />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</div>
<footer>
    <p>Made by Prachi Sharma</p>
</footer>

    </form>
    
</body>
</html>
