<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_5.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />



    <ul>
        <li>1a)<a href="http://webstrar49.fulton.asu.edu/page8/Default.aspx"> Default.aspx</a>  is the <b> Public page</b>.</li>
        <li>1b) ~/StudentPages/Payment.aspx is the <b>Member Page</b>. Steps to test them</li>
        <ol>
           <li>Login as student from  <a href="http://webstrar49.fulton.asu.edu/page8/Account/Login.aspx">~/Account/Login.aspx</a> webpage. Credentials are username: <b>student1</b> password: <b>student1</b> </li>
            <li> Payment page will be displayed. Enter the amount, required currency, credit card number and submit. Transaction will be stored in xml in server.</li>
            <li> Url to check the data in xml file is <a href="AppDataPayments.xml">Payments.xml</a></li>
        </ol>
        <li>1c) Two Staff pages are Staff1(NewsFocus) and Staff2(Top10Words)</li>
        <ol>
            <li>Steps to test Staff1(NewsFocus)</li>            
            <ol>
                <li>Login as Staff form <a href="http://webstrar49.fulton.asu.edu/page8/StaffLogin.aspx">Staff Login page </a>. Credentials are username: <b>staff1</b> password: <b>staff1</b></li>
                <li>Now Click on <b>Staff1NewsFocus</b> button on top navigation bar</li>
                <li>Give input as <b>arizona</b>. Ouput will be displayed in the same page</li>
                <li>Now Click on Staff2Top10Words button on the top navigation bar. Staff 1 is not having access to this page. So will be navigated to Login page</li>
                <li> Click <b>logoff</b> button on top navigation bar</li>
            </ol>
        </ol>
        <ol>
            <li>Steps to test Staff2(Top10Words)</li>            
            <ol>
            <li>Login as Staff form <a href="http://webstrar49.fulton.asu.edu/page8/StaffLogin.aspx">Staff Login page </a>. Credentials are username: <b>staff2</b> password: <b>staff2</b></li>
                <li>Now Click on Staff2Top10Words button on the top navigation bar. </li>
                <li>Give input as <b>http://www.asu.edu</b>. Ouput will be displayed in the same page</li>
                <li>Now Click on <b>Staff1NewsFocus</b> button on top navigation bar.Staff 2 is not having access to this page. So will be navigated to Login page</li>
                <li> Click <b>logoff</b> button on top navigation bar</li>            
            </ol>
        </ol>
        <p>-------------------------------------------------------------------------------------------------------------------------</p>

        <li>2) Local Component Layer </li>
        <ol><li> User Control
            <ol>
                <li> Implemented Image Verfication using user control for Student Registration. (StudentRegisterUserControl.ascx)</li>
                <li> Fragment Cache time for this user control is 30secs</li>
            </ol>
            </li>
            <li>DLL class Library Modules
                <ol>
                    <li>Used DLL for Encryption, Decryption. Used Encryption DLL in <b>StaffRegistration.aspx.cs</b> and Used Decryption DLL in <b>StaffLogin.aspx.cs</b></li>
                </ol>
            </li>
        </ol>
        
        <p>-------------------------------------------------------------------------------------------------------------------------</p>
        <li>3) Remote Service Layer</li>
        <ol>
            <li>Service Discovered From Public Repository
                <ol>
                    <li>Image Vefication Service</li>
                </ol>
            </li>
            <li>Services Developed by me (Used some external services in some of them)
                <ol>
                    <li>Currency Conversion Service</li>
                    <li>Validate Credit Card Number Service</li>
                    <li>News Focus Service</li>
                    <li>Top10WordsService</li>
                </ol>
            </li>
        </ol>
         <p>-------------------------------------------------------------------------------------------------------------------------</p>
        <li> 4) Data Management Layer</li>
        <ol>
            <li> Used Default Data Base for student login</li>
            <li>Used Xml file to store credentials of staff. And Used Encryption DLL while saving passwords in Xml File</li>
        </ol>
        <p>-------------------------------------------------------------------------------------------------------------------------</p>
        
    </ul>

</asp:Content>
