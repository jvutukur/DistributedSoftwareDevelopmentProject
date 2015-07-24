<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryItPage.aspx.cs" Inherits="TryItPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <center><strong>Validate The XML File Based on XSD File</strong><br /></center>
        <br />
        URL of WSDL file is:&nbsp;&nbsp; http://localhost:64938/Service1.svc<br />
        Method Names are: Verification<br />
        Parameter Types are: String(xmlurl), String(xsdurl)<br />
        Return Type is: String (Error Message or Success Message)<br />
        <br />
        Enter Url for the Xml Instance File&nbsp;
        <asp:TextBox ID="xmlurlTextBox" runat="server" Width="711px"></asp:TextBox>
        <br />
        <br />
        Enter Url for the XML Schema File
        <asp:TextBox ID="xsdurlTextBox" runat="server" Width="706px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ValidateButton" runat="server" OnClick="ValidateButton_Click" Text="Validate" />
        <br />
        <asp:TextBox ID="ValidateOutput" runat="server" Enabled="False" Rows="10" TextMode="MultiLine" Width="1102px"></asp:TextBox>
        <br />
        --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------<br />
        
        <center><strong>Transform the XML file to Html File based on XSL File<br />
            </strong><br /></center>
        URL of WSDL file is:&nbsp;&nbsp; http://localhost:64938/Service1.svc<br />
        Method Names are: Transformation<br />
        Parameter Types are: String(xmlurl), String(xslurl)<br />
        Return Type is: String (Error Message or Html code for the xml)<br />
        <br />
        Enter Url for the Xml Instance File&nbsp;
        <asp:TextBox ID="xmlurlTransformTextBox" runat="server" Width="711px"></asp:TextBox>
        <br />
        <br />
        Enter Url for the XSL File&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="xslurlTextBox" runat="server" Width="706px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="TransformButton" runat="server" Height="26px" OnClick="TransformButton_Click" Text="Transform" />
        <br />
        <br />
        <asp:TextBox ID="TransformOutput" runat="server" Enabled="False" Rows="10" TextMode="MultiLine" Width="1124px"></asp:TextBox>
        <br />
    
    </div>
    </form>
</body>
</html>
