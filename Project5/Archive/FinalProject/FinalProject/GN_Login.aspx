<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GN_Login.aspx.cs" Inherits="FinalProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
<title>Login Page</title>
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

		<!-- Body. Start modifying from here -->
		
		<form id='login' runat="server" >
			<div class="form-group">
				<label for="uname">User Name</label>
                 <asp:TextBox runat="server" type="text"  class="form-control" id="unameTextBox" placeholder="Enter your username"/>
				
			</div>
			<div class="form-group">
				<label for="pwd">Password</label>
                 <asp:TextBox runat="server"  type="password" class="form-control" id="pwdTextBox" placeholder="Enter your password"/>
				
			</div>
            <div class="form-group">
				<label for="User Type" >UserType&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
                 &nbsp;<select id="userTypeSelect" runat="server" class="form-inline">
                     <option>Student</option>
                     <option>Staff</option>
                 </select>
                
				
			</div>

			<asp:button ID="loginButton" runat="server" Class="btn btn-default" OnClick="loginButton_click">Login</asp:button>
		</form>
		<!-- All modifications should end here -->

		
	</div>
</body>
</html>
