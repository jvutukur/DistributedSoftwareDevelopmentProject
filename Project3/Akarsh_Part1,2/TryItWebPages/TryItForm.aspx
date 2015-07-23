<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryItForm.aspx.cs" Inherits="TryItWebPages.TryItForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p><b>Get the Weather Data</b></p>
        <p>This API is used to get the weather forecast details for 5 days of particular place</p>
        <strong>URL of the Service:-</strong><pre><a href="http://localhost:51455/Service1.svc?wsdl">http://localhost:51455/Service1.svc?wsdl</a></pre>
        <asp:Label ID="Label1" runat="server" Text="Enter the zip Code"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Weather Data" />
        <asp:BulletedList ID="BulletedList1" runat="server" Enabled="false">
        </asp:BulletedList>

        <br />
        <br />

        <p><b>Get the Wind Data</b></p>
        <p>This API is used to get the wind intensity of particular place</p>
        <strong>URL of the Service:-</strong><pre><a href="http://localhost:52135/Service1.svc?wsdl">http://localhost:52135/Service1.svc?wsdl</a></pre>
        <asp:Label ID="Label2" runat="server" Text="Enter the Latitude"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Enter the Longitude"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get Wind Data" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="The Wind Output"></asp:Label>
        </p>

         <br />
        <br />

        <p><b>Get the Solar Intensity of given Area</b></p>
        <p>This API is used to get the Solar Intensity of particular place</p>
        <strong>URL of the Service:-</strong><pre><a href="http://localhost:57100/Service1.svc?wsdl">http://localhost:57100/Service1.svc?wsdl</a></pre>
        <asp:Label ID="Label5" runat="server" Text="Enter the zip Code"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Get Solar Intensity" />
        <p>
            <asp:Label ID="Label6" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
