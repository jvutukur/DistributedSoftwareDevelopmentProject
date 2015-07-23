<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GN_Register.aspx.cs" Inherits="FinalProject.Register" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
<title>Register Page / Member Page</title>
<script type="text/javascript" src="js/vendor/jquery.js"></script>
<script type="text/javascript" src="js/vendor/bootstrap/bootstrap.js"></script>
<script type="text/javascript" src="js/scripts.js"></script>

<link href="css/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css"/>
<link href="css/vendor/bootstrap/css/bootstrap-theme.min.css" rel="stylesheet" type="text/css"/>
<link href="css/styles.css" rel="stylesheet" type="text/css"/>

</head>
<body>
    <div class='container'>
		<header>
			<nav class="navbar navbar-default">
				<div class="container-fluid">
					<!-- Brand and toggle get grouped for better mobile display -->
					<div class="navbar-header">
						<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
							<span class="sr-only">Toggle navigation</span> <span class="icon-bar"></span> <span class="icon-bar"></span> <span class="icon-bar"></span>
						</button>

					</div>

					<!-- Collect the nav links, forms, and other content for toggling -->
					<div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
						
						<h3 class='text-center'><b>PAYMENT PORTAL</b></h3>
                        <ul class="nav navbar-nav">
							<li><a href="index.aspx"><h4> Home Page / Public Page </h4> <span
									class="sr-only">(current)</span></a></li>
							<li><a href="GN_Register.aspx"><h4>Register Page/ Member Page</h4> <span
									class="sr-only">(current)</span></a></li>
                            <li><a href="GN_Login.aspx"><h4>Login Page</h4> <span
									class="sr-only">(current)</span></a></li>
						</ul>
					</div>
					<!-- /.navbar-collapse -->
				</div>
				<!-- /.container-fluid -->
			</nav>
		</header>
        <form id="register" runat="server">
            
            <div class="form-group">
			<center><label for="heading" class="center-block">Enter details in the below fields and click CREATE ACCOUNT to create a STUDENT Account</label></center>
                	<label for="fname">First Name</label>
                 <asp:TextBox runat="server" type="text"  class="form-control" id="firstNameTextBox" placeholder="Enter your name here"/>
				
			</div>
            <div class="form-group">
                <label for="email ID"> Email ID </label>
                <asp:TextBox runat="server" type="email" class="form-control" id="emailTextBox" placeholder="Enter email id here" /> 
			</div>

			<div class="form-group">
                <label for="username"> User Name </label>
                <asp:TextBox runat="server" type="text" class="form-control" id="usernameTextBox" placeholder="Enter the required username here" /> 
			</div>
            <div class="form-group">
                <label for="password"> Password </label>
                <asp:TextBox runat="server" type="text" class="form-control" id="passwordTextBox" placeholder="Enter the required username here" /> 
			</div>
            <div class="form-group">
                <asp:Button ID="createAccount" runat="server" Text="CREATE ACCOUNT" class="btn btn-default" OnClick="createAccount_Click" />
            </div>
            <asp:label ID="registerOutput" runat="server"></asp:label>
        </form>

        </div>
</html>
