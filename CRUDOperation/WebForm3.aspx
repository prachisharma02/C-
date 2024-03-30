<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="CRUDOperation.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
</head>
<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="StyleSheet1.css" />
    <form id="form1" runat="server">
        <div>
                
        <nav class="navbar navbar-expand-lg bg-dark">
  <div class="container-fluid">
    <a class="navbar-brand navtext" href="#">BIOGRAPHY</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link  navtext" aria-current="page" href="WebForm1.aspx">ADD STUDENT</a>
        </li>
        <li class="nav-item">
          <a class="nav-link navtext" href="#">EDIT DETAILS</a>
        </li>
        <li class="nav-item">
          <a class="nav-link navtext" href="WebForm4.aspx">SHOW ALL DETAILS</a>
        </li>
      </ul>
    </div>
  </div>
</nav>

   <div class="welcome">
<h1>WELCOME</h1>
            <p>Learning & building web application using ASP.net</p>
    </div>
        </div>
    </form>
</body>
</html>
