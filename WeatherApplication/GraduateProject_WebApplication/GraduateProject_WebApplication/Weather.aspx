<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weather.aspx.cs" Inherits="GraduateProject_WebApplication.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
<title>Weather</title>
<script type="text/javascript" src="Scripts/vendor/jquery.js"></script>
<script type="text/javascript"
	src="Scripts/vendor/bootstrap/bootstrap.js"></script>

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
						
						<h3 class='text-center'>Weather Updates Based on ZipCode</h3> 
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
		<header>
			
		</header>

		<!-- Body. Start modifying from here -->
        <form id="form4" runat="server">
			    <div class="form-group">
				<label for="zipcode1">ZIP CODE</label>                       				          
                 <asp:TextBox runat="server" type="number" id="weather_zipcodeTextBox1"   style="margin-top: 0px" placeholder="Enter zipcode here" class="form-control"  />
			    </div>
                <div class="form-group">
                <asp:Button ID="FindweatherButton" runat="server"  Text="Get Weather Report For Next 5 Days of Your Location" class="btn btn-default" OnClick="GetWeatherButton_Click"/>
                  </div>
                      <asp:Label ID="weatherOutput" runat="server"></asp:Label>
            
                    <asp:Table ID="Table1"  runat="server" Class="table"   GridLines="None" Visible="false">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="date0"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="condition0"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="min0"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="max0"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                        
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="date1"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="condition1"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="min1"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="max1"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                        
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="date2"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="condition2"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="min2"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="max2"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        
                        <asp:TableRow runat="server">
                        
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="date3"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="condition3"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="min3"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="max3"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                        
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="date4"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="condition4"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="min4"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="max4"></asp:Label></asp:TableCell>

                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="date5"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="condition5"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="min5"></asp:Label></asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="max5"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
            
            
                
		</form>


		<!-- All modifications should end here -->

		<footer class='row'>
			<p class='text-center'></p>
		</footer>
	</div>
</body>
</html>
