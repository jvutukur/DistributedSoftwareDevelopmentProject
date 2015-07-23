<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="NewsFocus.aspx.cs" Inherits="Project_5.Staff1Pages.NewsFocus" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    
    <title><%: Page.Title %></title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

</head>
    <body>
        <form runat="server" name="staffform" >
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see http://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="respond" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>

            <div class="navbar navbar-default navbar-fixed-top">
            
                <h3 class='text-center'>PAYMENT PORTAL && SEARCH PORTAL </h3>
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                            
                            <li><a runat="server" href="~/StaffPages/EncDec">StaffEncDec</a></li>
                        <li><a runat="server" href="~/Staff1Pages/NewsFocus">Staff1NewsFocus</a></li>                        
                            <li><a runat="server" href="~/Staff2Pages/Top10Words">Staff2Top10Words</a></li>
                    </ul>
                    <asp:LoginView runat="server" ViewStateMode="Disabled">
                        
                        <LoggedInTemplate>
                            <ul class="nav navbar-nav navbar-right">
                                <li><a runat="server" title="Manage your account">Welcome <%: Context.User.Identity.GetUserName()  %> !</a></li>
                                <li>
                                    <asp:LoginStatus runat="server" LogoutAction="Redirect" LogoutText="Log off" LogoutPageUrl="~/" OnLoggingOut="Unnamed_LoggingOut" />
                                </li>
                            </ul>
                        </LoggedInTemplate>
                    </asp:LoginView>
                </div>
            </div>
            <br /><br /><br /><br />
            <div class="container body-content">
            <div class="form-group">
                <h4> NewsFocus </h4>
                <hr />
                    <label for="enterword"> Enter the words related to which you need news updates</label>
                <asp:TextBox runat="server" ID="SerchWordsTextBox" CssClass="form-control"></asp:TextBox>
                </div>
                
                <div class="form-group">
                    <asp:Button ID="GetNewsButton" runat="server" Text="Get News" OnClick="GetNewsButton_Click" CssClass="btn btn-primary" />
                    
                </div>
                <div class="form-group">
                
                    <asp:TextBox runat="server" type="text" id="NewsFocusOutputTextBox" TextMode="MultiLine" Rows="17" CssClass="form-control"/>
                </div>

            </div>
            
            
        
            </form>
    </body>
    </html>
