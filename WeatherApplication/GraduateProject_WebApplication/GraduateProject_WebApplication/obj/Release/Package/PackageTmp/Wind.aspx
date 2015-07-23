<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wind.aspx.cs" Inherits="GraduateProject_WebApplication.index" %>

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
         <form id="form5" runat="server">
			    <div class="form-group">
				<label for="zipcode3">ZIP CODE</label>                       				          
                 <asp:TextBox runat="server" type="number" id="wind_zipcodeTextBox1"   style="margin-top: 0px" placeholder="Enter zipcode here" class="form-control"  />
			    </div>
             			    <div class="form-group">
                     <label for="Countrycode">COUNTRY CODE (eg: US , IN )</label>                       				          
                 <asp:TextBox runat="server" type="text" id="countrycodeTextbox"   style="margin-top: 0px" placeholder="Enter country code here" class="form-control"  />
                                 </div>
                            <div class="form-group">
                <asp:Button ID="FindwindButton" runat="server"  Text="Get Wind speed at Your Location" class="btn btn-default" OnClick="GetWindButton_Click"/>
                  </div>

             <asp:Label ID="windOutput" runat="server"></asp:Label>
               <asp:Table ID="Table2"  runat="server" Class="table"   GridLines="None" Visible="false">
                        <asp:TableRow runat="server">

                            <asp:TableCell runat="server">LOCATION</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="location"></asp:Label></asp:TableCell>                            

                        </asp:TableRow>
                        <asp:TableRow runat="server">                        
                            <asp:TableCell runat="server">LATITUDE</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="latitude"></asp:Label></asp:TableCell>                            
                        </asp:TableRow>
                   <asp:TableRow runat="server">                        
                            <asp:TableCell runat="server">LONGITUDE</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="longitude"></asp:Label></asp:TableCell>                            
                        </asp:TableRow>
                   <asp:TableRow runat="server">                        
                            <asp:TableCell runat="server">WIND SPEED</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="windspeed"></asp:Label></asp:TableCell>                            
                        </asp:TableRow>
                   <asp:TableRow runat="server">                        
                            <asp:TableCell runat="server">WIND DIRECTION</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label  runat="server" ID="winddirection"></asp:Label></asp:TableCell>                            
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
