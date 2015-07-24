<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="Project_5.StaffLogin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <br /><br /><br /><br />
         <div class="form-group">
                <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
            </div>

    <div class="form-group">
        <center><h4> STAFF LOGIN. Using Decryption DLL and Decrypting the pwd in xml file and comparing it with given pwd.
            <br />Staff1NewsFocus is only available to staff1
            <br />Staff2Top10Words is only available to staff2
        </h4></center>
        <hr />
    </div>
     <div class="form-group">
        <label for="usernamelabel">UserName</label>
        <asp:TextBox ID="usernametb" runat="server" CssClass="form-control"></asp:TextBox>
         </div>
    <div class="form-group">
        <label for="pwd">Password</label>
        <asp:TextBox ID="pwdtb" runat="server" CssClass="form-control" type="password"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="loginbutton" Text="Login" runat="server" CssClass="btn btn-primary" OnClick="loginbutton_Click" />
    </div>
</asp:Content>
