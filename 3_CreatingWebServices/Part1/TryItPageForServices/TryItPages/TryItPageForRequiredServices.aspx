<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryItPageForRequiredServices.aspx.cs" Inherits="TryItPages.EncryptDecryptTryItPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 
        
        <b ><center>This is a TryIt page for Required Services</center>
        
        <u>Top10Words Service</u><br />
        </b>
        <br />
        About This Service :  This 
        service will give the top 10 words found in a web page<br />
        <br />
        URL of WSDL file is:&nbsp;&nbsp; http://webstrar49.fulton.asu.edu/page0/Service1.svc<br />
        <br />
        Method Names are: Top10Words<br />
        Parameter Types are: Url of webpage as a string<br />
        Return Type is: Array of Strings which contains top 10 words in the website <br />
        <br />
        Enter the Url of the website here&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Url_TextBox" runat="server" style="margin-top: 0px" Width="255px" Height="16px"></asp:TextBox>
       
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="FindTop10WordsButton" runat="server"  Text="Find Top10Words in the mentioned url" OnClick="FindTop10WordsButton_Click" /><br /><br />
        <asp:TextBox ID="Top10WordsOutputTextBox" runat="server" Height="151px" Rows="12" TextMode="MultiLine" Width="380px" Enabled="False"></asp:TextBox>
&nbsp;<br />
    
    
        
        <b><u>NewsFocusService</u><br />
        </b>
        <br />
        <strong>About This Service : </strong> This 
        service will give the top 10 words found in a web page<br />
        <br />
        URL of WSDL file is:&nbsp;&nbsp; http://webstrar49.fulton.asu.edu/page0/Service1.svcc<br />
        <br />
        Method Names are: NewsFocus<br />
        Parameter Types are: String which contains words<br />
        Return Type is: Array of Strings which contains top 25 urls related to the search <br />
        <br />
        Enter the words related to which you need news updates&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="SerchWordsTextBox" runat="server" style="margin-top: 0px" Width="255px" Height="16px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="GetNewsButton" runat="server"  Text="Get News" OnClick="GetNewsButton_Click" /><br /><br />
        <asp:TextBox ID="NewsFocusOutputTextBox" runat="server" Height="180px" Rows="12" TextMode="MultiLine" Width="740px" Enabled="False"></asp:TextBox>
&nbsp;<br />
    
    </form>
</body>
</html>
