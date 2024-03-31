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
      <button class="btn navtext" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasExample" aria-controls="offcanvasExample">
                SHOW</button>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link  navtext" aria-current="page" href="WebForm1.aspx">ADD STUDENT</a>
        </li>
       
        <li class="nav-item">
          <a class="nav-link navtext" href="WebForm4.aspx">SHOW ALL DETAILS</a>
        </li>
       
      </ul>
    </div>
         <asp:TextBox ID="txtSearch" style="width:300px" runat="server"  placeholder="Search..." CssClass="form-control"></asp:TextBox>
   <asp:Button ID="btnSearch" style="margin:0 250px 0 10px" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="BtnSearch_Click" />
    
  </div>
</nav>
    </nav>
        <div class="norec">
        <asp:Label  runat="server" ID="table"></asp:Label>
            </div>
 <table class="table">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Phone No</th>
            <th>Email</th>
            <th>Password</th>
            
        </tr>
    </thead>
    <tbody >        <asp:Literal ID="litTableBody" runat="server"></asp:Literal>

    </tbody>
</table>
        <div class="showlist">
           
          



 <h4>Student List</h4>
            
<asp:Button ID="Button1" CssClass="add"   onclick="Button1_Click" runat="server"  Text="ADD STUDENT"  />


<div class="offcanvas offcanvas-start" tabindex="-1" id="offcanvasExample" aria-labelledby="offcanvasExampleLabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasExampleLabel">Offcanvas</h5>
    <button type="button" class="btn-close text-reset" data-bs-dismiss="offcanvas" aria-label="Close"></button>
  </div>
  <div class="offcanvas-body">
    <div> List of Students</div>
    <div class="dropdown mt-3" runat="server" id="offcanvasBody">
    </div>
  </div>
</div>


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
 <table >
    <thead>
        <tr>   
            <th> 
                <asp:TextBox ID="TextBox2"  class="local"   style="width:120px" runat="server" placeholder="Name..." oninput="handleInputChange(this)"></asp:TextBox>
           <button runat="server" id="btnRun" onserverclick="Namefind" class="btn btn-mini" title="Search">
    <i class="fa-solid fa-magnifying-glass" style="color:black"></i> 
</button></th>
            <th> 
                <asp:TextBox ID="TextBox3" class="local"   style="width:100px" runat="server" placeholder="Phone No..."></asp:TextBox>
                       <button runat="server" id="Button4" onserverclick="Numfind" class="btn btn-mini" title="Search">
    <i class="fa-solid fa-magnifying-glass" style="color:black"></i> 
</button>
            </th>
            <th> 
    <asp:TextBox ID="TextBox4" class="local"   style="width:200px" runat="server" placeholder="Email..."></asp:TextBox>
    <button runat="server" id="Button6" onserverclick="Efind" class="btn btn-mini" title="Search">
    <i class="fa-solid fa-magnifying-glass" style="color:black"></i> 
</button>
</th>             
</tr>
    </thead>
    <tbody>
        <asp:Literal ID="Literal3" runat="server"></asp:Literal>

    </tbody>
</table>
<table >
    <tbody>
        <asp:Literal ID="Literal4" runat="server"></asp:Literal>
    </tbody>
</table>

<table>
     <tbody>
    <asp:Literal ID="Literal5" runat="server"></asp:Literal>
</tbody>
    </table>

             <div class="norec">
 <asp:Label  runat="server" ID="Label3"></asp:Label>
     </div>
                        <div class="norec">
<asp:Label  runat="server" ID="Label4"></asp:Label>
    </div>
                        <div class="norec">
<asp:Label  runat="server" ID="Label5"></asp:Label>
    </div>

</div>
<footer>
    <p>Made by Prachi Sharma</p>
</footer>

    </form>
    
</body>
</html>
