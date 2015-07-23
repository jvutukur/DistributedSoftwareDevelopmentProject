<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FinalProject.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
<title>Home Page / Public Page</title>
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

    <form id="form1" runat="server">
    
			<div class="form-group">
				
                <asp:BulletedList runat="server">
                    <asp:ListItem> Give Brief Explanation of Project.</asp:ListItem> 
                    <asp:ListItem> This Application has 3 types of users 1)Student 2)Staff1 3)Staff2</asp:ListItem> 
                </asp:BulletedList>
                <table class="table">
                    <tr>
<th>Service Name, with input and output types </th>
<th> TryIt link </th>
<th> Service Description </th>
</tr>

<tr>
<td> Top10WordsService
Inputs: String
Outputs: String Array
</td>
<td> <a href="http://webstrar49.fulton.asu.edu/page1/TryItPageForRequiredServices.aspx">http://webstrar49.fulton.asu.edu/page1/TryItPageForRequiredServices.aspx </a></td>
<td> Analyze the website at a the given url and return the 10 most frequently appeared in that webpage</td>
</tr>

<tr>
<td> NewFocusService
Inputs: String 
Output: String Array
</td>
<td>  <a href="http://webstrar49.fulton.asu.edu/page1/TryItPageForRequiredServices.aspx">http://webstrar49.fulton.asu.edu/page1/TryItPageForRequiredServices.aspx </a></td>
<td> Take some words as input and gives the top urls corresponding to the words given</td>
</tr>



<tr>
<td> EncryptionService (Restful Service)
Input: String
Output: String
</td>
<td> <a href="http://webstrar49.fulton.asu.edu/page5/TryItPage.aspx">http://webstrar49.fulton.asu.edu/page5/TryItPage.aspx </a> </td>
<td>Takes the input string and does encryption and returns encrypted String </td>
</tr>



<tr>
<td> DecryptionService
Input: String
Output: String
</td>

<td><a href="http://webstrar49.fulton.asu.edu/page5/TryItPage.aspx">http://webstrar49.fulton.asu.edu/page5/TryItPage.aspx </a>  </td>
<td>Takes the encrypted String and returns original string </td>
</tr>


<tr>
<td> CurruncyConversionService
Input: Float, String, String
Output: Float
</td>
 
<td><a href="http://webstrar49.fulton.asu.edu/page5/TryItPage.aspx">http://webstrar49.fulton.asu.edu/page5/TryItPage.aspx </a>  </td>
<td> Takes the Float in Dollars and converts this amount equivalent in other currency</td>
</tr>


<tr>
<td>ValidateCreditCardService
Input: String
Output: Boolean
 </td>

<td> <a href="http://webstrar49.fulton.asu.edu/page5/TryItPage.aspx">http://webstrar49.fulton.asu.edu/page5/TryItPage.aspx </a> </td>
<td> Takes the encrypted Credit Card Number and validates the credit card and return boolean value whether it is valid or not</td>
</tr>
                </table>
            </div>
				</form>
        </div>
    
</body>
</html>
