<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="StaffRegistataion.aspx.cs" Inherits="Project_5.StaffRegistataion" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br /><br />
    <div class="form-horizontal">
     <div class="form-group">
                <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
            </div>
        <h4>Staff Registration. Using Encryption DLL and saving Encrypted pwd in xml file</h4>
        <hr />
 <div class="form-group">
     <label for="Enterusername" >Enter the required username</label>
     <asp:TextBox ID="usernametextbox" runat="server" CssClass="form-control" type="text"></asp:TextBox>
     </div>

    <div class="form-group">
     <label for="Enterpassword" >Enter the password</label>
     <asp:TextBox ID="pwd1tb" runat="server" CssClass="form-control" type="password"></asp:TextBox>
     </div>

    <div class="form-group">
     <label for="ReEnterpassword" >Re-Enter the password</label>
     <asp:TextBox ID="pwd2tb" runat="server" CssClass="form-control" type="password"></asp:TextBox>
     </div>

    <div class="form-group">
     <label for="emaillabel" >Enter your Email</label>
     <asp:TextBox ID="emailTB" runat="server" CssClass="form-control" type="email"></asp:TextBox>
     </div>
    
     <div class="form-group">
            <label  ID="CapcheImage" class="col-md-2 control-label">Capcha</label>
            
            <div class="col-md-10">
                
                   <asp:Image ID="Image1" runat="server" />
<asp:Button runat="server" OnClick="getOtherImageButton_Click" Text="Reload Capcha" CssClass="btn btn-default" />
<asp:TextBox ID="capchaValueTB" runat="server" Visible="false"></asp:TextBox>
                    
            </div>
                
        </div>
        
            <div class="form-group">
            <label  ID="Label1" class="col-md-2 control-label">Enter Charecters in Capcha</label>
            <div class="col-sm-10">
                <asp:TextBox ID="ImageverificationTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
         <asp:Button ID="registerbutton" runat="server"  Text="Register As Staff" CssClass="btn btn-primary" OnClick="registerbutton_Click" />
            </div>
        </div>

        </div>
</asp:Content>