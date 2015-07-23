<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAccountTryIt.aspx.cs" Inherits="TryItWebPages.UserAccountTryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 639px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p><b>Create Account Service</b></p>
        <p>This API is used to create account</p>
        <strong>URL of the Service:-</strong><pre><a href="http://localhost:62112/Service1.svc?wsdl">http://localhost:62112/Service1.svc?wsdl</a></pre>
        <p>Enter the account details</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label3" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label4" runat="server" Text="Passwrod"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label6" runat="server" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        <p>
             <asp:Button ID="Button1" runat="server" Text="Create Account" OnClick="Button1_Click" />
        </p>
        <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
        <br />
        <br />

        <p><b>Login Service</b></p>
        <p>This API is used to Login</p>
        <strong>URL of the Service:-</strong><pre><a href="http://localhost:62112/Service1.svc?wsdl">http://localhost:62112/Service1.svc?wsdl</a></pre>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
         <p>
             <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" />
        </p>
        <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
        <br />
        <br />

        <p><b>Edit Account Service</b></p>
        <p>This API is used to Edit account using email Id as the key</p>
        <strong>URL of the Service:-</strong><pre><a href="http://localhost:62112/Service1.svc?wsdl">http://localhost:62112/Service1.svc?wsdl</a></pre>
        <p>Enter the account details to edit</p>
        <p>
            <asp:Label ID="Label9" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label10" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label11" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label12" runat="server" Text="Passwrod"></asp:Label>
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label13" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label14" runat="server" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        </p>
        <p>
             <asp:Button ID="Button3" runat="server" Text="Edit Account" OnClick="Button3_Click" />
        </p>

        <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
