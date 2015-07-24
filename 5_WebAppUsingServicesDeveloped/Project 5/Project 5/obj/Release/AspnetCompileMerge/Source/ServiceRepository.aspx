<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ServiceRepository.aspx.cs" Inherits="Project_5.ServiceRepository" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
              
    <br /><br /><br /><br />
    
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
<td>1) First Login as staff2 <a href="StaffLogin.aspx">http:/webstrar49.fulton.asu.edu/page8/StaffLogin.aspx</a><br />username: staff2 <br />password: staff2 <br /><br />
2) Navigate to Top10Words Page <a href="Staff2Pages/Top10Words.aspx">http:/webstrar49.fulton.asu.edu/page8/Staff2Pages/Top10Words.aspx</a>  </td> 
<td> Analyze the website at a the given url and return the 10 most frequently appeared in that webpage</td>
</tr>

<tr>
<td> NewFocusService
Inputs: String 
Output: String Array
</td>
<td>1) First Login as staff1 <a href="StaffLogin.aspx">http:/webstrar49.fulton.asu.edu/page8/StaffLogin.aspx</a><br />username: staff1 <br />password: staff1 <br /><br />
2) Navigate to NewsFocus Page <a href="Staff1Pages/NewsFocus.aspx">http:/webstrar49.fulton.asu.edu/page8/Staff1Pages/NewsFocus.aspx</a>  </td> 
<td> Take some words as input and gives the top urls corresponding to the words given</td>
</tr>



<tr>
<td> CurruncyConversionService
Input: Float, String, String
Output: Float
</td>
<td>1) First Login as student <a href="Account/Login.aspx">http:/webstrar49.fulton.asu.edu/page8/Account/Login.aspx</a><br />username: student1 <br />password: student1 <br /><br />
2) Navigate to Payment Page <a href="StudentPages/Payment.aspx">http:/webstrar49.fulton.asu.edu/page8/StudentPages/Payment.aspx</a>  </td> 
<td> Takes the Float in Dollars and converts this amount equivalent in other currency</td>
</tr>


<tr>
<td>ValidateCreditCardService
Input: String
Output: Boolean
 </td>

<td> 
    
      <table class="table">



<tr>
<td>1) First Login as student <a href="Account/Login.aspx">http:/webstrar49.fulton.asu.edu/page8/Account/Login.aspx</a><br />username: student1 <br />password: student1 <br /><br />
2) Navigate to Payment Page <a href="StudentPages/Payment.aspx">http:/webstrar49.fulton.asu.edu/page8/StudentPages/Payment.aspx</a>  </td> 
</tr>


                </table>
    </td>
<td> Takes the encrypted Credit Card Number and validates the credit card and return boolean value whether it is valid or not</td>
</tr>

<tr>
    <td>Encryption And Decryption DLL</td>
    <td>1) First Login as staff1 <a href="StaffLogin.aspx">http:/webstrar49.fulton.asu.edu/page8/StaffLogin.aspx</a><br />username: staff1 <br />password: staff1 <br /><br />
2) Navigate to StaffEncDec page<br />
        <a href="StaffPages/EncDec.aspx">http:/webstrar49.fulton.asu.edu/page8/Staff1Pages/EncDec.aspx</a>  </td>
    <td><strong>Encryption</strong><br />
        Takes a String as input and gives Encryped value of it.<br />
        <br />
        <strong>Decryption</strong><br />
        Takes Encrypted String and gives Original String as output</td>
</tr>

          
<tr>
    <td>Image Verification Service</td>
    <td> <a href="Account/Register.aspx">http:/webstrar49.fulton.asu.edu/page8/Account/Register.aspx</a></td>
    <td>• Gives random charecters based on required length.<br />
        • Gives an url to image with these random charecters&nbsp; </td>
</tr>

                </table>
            </asp:Content>

