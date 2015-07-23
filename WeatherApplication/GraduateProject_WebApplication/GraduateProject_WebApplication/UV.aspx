<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UV.aspx.cs" Inherits="GraduateProject_WebApplication.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
<title>Weather</title>
<script type="text/javascript" src="Scripts/vendor/jquery.js"></script>
<script type="text/javascript"
	src="Scripts/vendor/bootstrap/bootstrap.js"></script>
<script type="text/javascript"
	src="Scripts/scripts.js"></script>

<link href="css/vendor/bootstrap/css/bootstrap.min.css"
	rel="stylesheet" type="text/css"/>
<link href="css/vendor/bootstrap/css/bootstrap-theme.min.css"
	rel="stylesheet" type="text/css"/>
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
						
						<h3 class='text-center'>Weather Information Based on ZipCode</h3> 
						<ul class="nav navbar-nav">
							<li><a href="Weather.aspx"><h4> Temperature of your location </h4> <span
									class="sr-only">(current)</span></a></li>
							<li><a href="UV.aspx"><h4>UV Index of your location</h4> <span
									class="sr-only">(current)</span></a></li>
                            <li><a href="Wind.aspx"><h4>Wind Speeds at your location </h4> <span
									class="sr-only">(current)</span></a></li>
						</ul>
					</div>			
				</div>
				<!-- /.container-fluid -->
						</nav>
		</header>
        </div>
	<div class='container'>		
		<!-- Body. Start modifying from here -->

        <form id="form3" runat="server">
			    <div class="form-group">
				<label for="zipcode">ZIP CODE</label>                       				          
                 <asp:TextBox runat="server" type="number" id="uv_zipcodeTextBox1"   style="margin-top: 0px" placeholder="Enter zipcode here" class="form-control"  />
			    </div>
                <div class="form-group">
                <asp:Button ID="FindUVIndexButton" runat="server"  Text="Find UV Index of the Location" class="btn btn-default" OnClick="FindUVIndexButton_Click"/>
                    <br />
                    <br />
                    <asp:Label ID="UV_IndexOutput" runat="server"></asp:Label>
                </div>
                
		</form>


		<!-- All modifications should end here -->

		<footer class='row'>
			<p class='text-center'></p>
		</footer>
	</div>
</body>
</html>
