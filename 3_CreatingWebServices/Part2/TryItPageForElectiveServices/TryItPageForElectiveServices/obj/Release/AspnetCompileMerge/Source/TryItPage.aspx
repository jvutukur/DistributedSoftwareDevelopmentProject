<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryItPage.aspx.cs" Inherits="TryItPageForElectiveServices.TryItPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1"   runat="server">
 
        
        <b ><center>This is a TryIt page for Elective Services</center>
        
        <u>Currency Converter Service</u></b><br />
        About This Service : This Service will convert amount in US Dollars to amount in any one of the mentioned currencies<br />
        URL of WSDL file is:&nbsp;&nbsp;      http://webstrar49.fulton.asu.edu/page2/Service1.svc<br />
        Method Names are: CurrencyConversion<br />
        Parameter Types are: String (amount in Dollars), String (Currency ID to which this amount has to be converted)<br />
        Return Type is: double (amount in selected currency)<br />
         <br />
         <table>
         <tr><td>&nbsp;<asp:Button ID="LoadAvailbleCurrenciesButton" runat="server"  Text="FindTheCurrenciesWhichWeSupport" Width="266px" OnClick="LoadAvailbleCurrenciesButton_Click"  /></td>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <td><asp:TextBox ID="LoadAvailableCurrenciesTextBox" runat="server" Height="96px" Rows="15" TextMode="MultiLine" Width="330px" Enabled="False" style="margin-top: 0px; margin-left: 41px;"></asp:TextBox></td>
        </tr></table><br />
         Enter the amount you want to pay&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $
        <asp:TextBox ID="AmountInDollarsTextBox" runat="server" style="margin-top: 0px" Width="129px" Height="16px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;eg:150<br />
         <br />
         Enter the currency in which you want to pay&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ToCurrencyTextBox" runat="server" style="margin-top: 0px" Width="129px" Height="16px"></asp:TextBox>
        &nbsp;&nbsp; eg: INR&nbsp;<asp:Button ID="ConvertAmountButton" runat="server"  Text="ConvertAmount To required Currency" Width="266px" OnClick="ConvertAmountButton_Click" />
         <br />
         <br />
        <asp:TextBox ID="CurrencyConveterOutputAmountTextBox" runat="server" Height="72px" Rows="1
            " TextMode="MultiLine" Width="380px" Enabled="False"></asp:TextBox>
&nbsp;<br />
         ------------------------------------------------------------------------------------------------------------------------------------------<br />
    
    
        
        <b><u>EncryptionService</u></b><br />
        <strong>About This Service : </strong> This service will take String as input and will encrypt this string and will return the encrypted string<br />
         URL of WSDL file is: http://webstrar49.fulton.asu.edu/page3/Service1.svc<br />
        Method Names are: encrypt <br />
        Parameter Types are: String (eg: 5243017734757255)<br />
         Return Type is:
         String (eg: qa{wtbxswgxqsazq)
        <br />
         Enter the String which needs to be encrypted&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="PlainText_TextBox" runat="server" style="margin-top: 0px" Width="255px" Height="16px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="EncryptionButton" runat="server"  Text="Encrypt" OnClick="EncryptionButton_Click" /><br /><br />
        <asp:TextBox ID="EncryptionOutput" runat="server" Height="35px" Rows="12" TextMode="MultiLine" Width="740px" Enabled="False"></asp:TextBox>
&nbsp;<br />
    
         <p>
         ------------------------------------------------------------------------------------------------------------------------------------------<br />
    
    
        
        <b><u>DecyptionService</u></b><br />
        <strong>About This Service : </strong> This service will take encrypted String as input and will decrypt this string and will return the original plain text<br />
         URL of WSDL file is: http://webstrar49.fulton.asu.edu/page2/Service1.svc<br />
        Method Names are: decryption<br />
        Parameter Types are: String (eg: qa{wtbxswgxqsazq) <br />
         Return Type is:
             String (eg: 5243017734757255)<br />
             Enter the String which needs to be Decrypted&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Cipher_TextBox" runat="server" style="margin-top: 0px" Width="255px" Height="16px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="DecryptionButton" runat="server"  Text="Decrypt" OnClick="DecryptionButton_Click" /><br /><br />
        <asp:TextBox ID="DecryptionOutput" runat="server" Height="35px" Rows="12" TextMode="MultiLine" Width="740px" Enabled="False"></asp:TextBox>
&nbsp;</p>
         <p>
         --------------------------------------------------------------------------------------------------------------------------------------------------------------<br />
    
    
        
        <b><u>ValidateCardNumberService</u></b><br />
        <strong>About This Service : </strong> This service will take String as input (encrypted credit card number) and will tell whether card number is valid or not. First Enter Credit Card number in the text box and then click encrypt. Then text will contain encrypted card number. Now click validate Card Number<br />
         URL of WSDL file is: http://webstrar49.fulton.asu.edu/page4/Service1.svc<br />
        Method Names are: validateCreditCardNumber<br />
        Parameter Types are: 
             String (Encrypte card number) Here input eg is 5243017734757255<br />
         Return Type is:
             String (Card Type eg: Master)
        <br />
             Enter the CreditCardNumber&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="PlainText_TextBox1" runat="server" style="margin-top: 0px" Width="255px" Height="16px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="EncryptionButtonInValidateCard" runat="server"  Text="Encrypt" OnClick="EncryptionButtonInValidateCard_Click"  /><br /><br />
        &nbsp;
        <asp:Button ID="ValidateCardButton" runat="server"  Text="ValidateCardNumber" OnClick="ValidateCardNumberButton_Click" />
         </p>
         <p>
        <asp:TextBox ID="ValidateCardOutput" runat="server" Height="35px" Rows="12" TextMode="MultiLine" Width="740px" Enabled="False"></asp:TextBox>
         </p>
    
    </form>
</body>
</html>
