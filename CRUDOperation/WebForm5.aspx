<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="CRUDOperation.WebForm5" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
<link rel="stylesheet" href="StyleSheet1.css" />
</head>
<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <style>
       
    </style>
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
    
        <div id="div1">
            <h5>EDIT DETAILS</h5>
           <form id="form1" runat="server"> 
                  <div class="mb-3">
        <label  class="form-label">Student ID</label>
        <asp:TextBox ID="TextBox5"  class="tbox"  runat="server"></asp:TextBox>
       <asp:HiddenField runat="server"  ID="tb5"/>
</div>
                <div class="mb-3">
                  
  <label for="exampleInputEmail1" class="form-label">Name</label>
  <asp:TextBox ID="TextBox1"  class="tbox"  runat="server"></asp:TextBox>
</div>
                <div class="mb-3">
  <label for="exampleInputEmail1" class="form-label">Phoneno</label>
  <asp:TextBox ID="TextBox2" runat="server" class="tbox" TextMode="Number"></asp:TextBox>
</div>
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
    <asp:TextBox ID="TextBox3" class="tbox" runat="server" TextMode="Email"></asp:TextBox>
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
<asp:TextBox  ID="TextBox4" class="tbox" runat="server" TextMode="Password"></asp:TextBox>  </div>    
               <asp:Button ID="Button3" CssClass="button" runat="server" onclick="Button3_Click" Text="Update" />
               <asp:Button ID="Button2" CssClass="button" runat="server" onclick="Button2_Click" Text="Delete" />
                </form>
</div>
<div>
             <br/>
             <br/>
                     
   
    <footer>
        <p>Made by Prachi Sharma</p>
    </footer>
</div>
</body>
</html>
