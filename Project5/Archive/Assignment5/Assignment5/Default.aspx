<%@ Page Title="PublicPage" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment5.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <br /><br /><br /><br />
   
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
</asp:Content>

			
	