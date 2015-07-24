<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="Payment.aspx.cs" Inherits="Project_5.StudentPages.Payment" Async="true" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<br />
    <br />
    <br />
                  
            <div class="form-group">
                <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
            </div>
    <h4>Makey Payment Page. Using CurrencyConversion, Validate Credit Card Service</h4>
    <hr/>
            <div class="form-group">
                          <label for="College ID">Enter your college ID</label>
                <asp:TextBox ID="collegeIDTextBox" runat="server" type="number" class="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
            <asp:Button runat="server" ID="LoadAvailbleCurrenciesButton" Text="FindTheCurrenciesWhichWeSupport" CssClass="btn btn-primary" OnClick="LoadAvailbleCurrenciesButton_Click" />                
            </div>

            <div class="form-group">
             <asp:TextBox runat="server" type="text" id="LoadAvailableCurrenciesTextBox" TextMode="MultiLine" Rows="2" CssClass="form-control" enabled="False"/>
                </div>

        <div class="form-group">
        <label for="enteramount" >Enter the amount you want to pay</label>
                        <div class="input-group">
                    <div class="input-group-addon">$</div>
                    <asp:TextBox ID="AmountInDollarsTextBox" runat="server" type="number" class="form-control"></asp:TextBox>
                    <div class="input-group-addon">eg:150</div>
                </div>
        </div>
            
            
            
        
        <div class="form-group">
         <label for="requiredcurrency">Enter the currency in which you want to pay</label>
            <div class="input-group">
                <asp:TextBox ID="ToCurrencyTextBox" runat="server" type="text" class="form-control"></asp:TextBox>
                <div class="input-group-addon">example of Valid Currency is INR</div>
                </div>
      </div>
        <div class="form-group">
            <asp:Button ID="ConvertAmountButton" runat="server" Text="ConvertAmount To required Currency" CssClass="btn btn-primary" OnClick="ConvertAmountButton_Click" />
        </div>    
            
            <div class="form-group">
                                <asp:TextBox ID="CurrencyConveterOutputAmountTextBox" runat="server" rows="1" type="text" class="form-control" TextMode="MultiLine" Enabled="False" CssClass="form-control"></asp:TextBox>
            </div>
            
            <div class="form-group">
                           <label for="Enter the CreditCardNumber">Enter the CreditCardNumber</label>
                <div class="input-group">
        <asp:TextBox ID="PlainText_TextBox1" runat="server" CssClass="form-control" type="number"></asp:TextBox>
    <div class="input-group-addon">example of valid card Number 5243017734757255</div>
               
                    </div>
            </div>


            <div class="form-group">
                <asp:Button ID="EncryptionButtonInValidateCard" runat="server"  Text="Encrypt" OnClick="EncryptionButtonInValidateCard_Click"  CssClass="btn btn-primary"/>
            </div>

           
                 
            <div class="form-group">
                <label for="Encrypted Credit Card Number">Encrypted Credit Card Number</label>
                <asp:TextBox ID="cipherTextBox" runat="server" CssClass="form-control" type="text" Enabled="False"></asp:TextBox>
            </div>
           
             <div class="form-group">
                <asp:Button ID="ValidateCardButton" runat="server"  Text="ValidateCardNumberFromEncryptedCardNumber" OnClick="ValidateCardNumberButton_Click" CssClass="btn btn-primary"/>
            </div> 
            <div class="form-group">
                <asp:TextBox ID="ValidateCardOutput" runat="server"  Enabled="False" TextMode="MultiLine" Rows="1" CssClass="form-control"></asp:TextBox>
            </div>
            
                 
            <div class="form-group">
                <asp:Button ID="makePaymentButton" runat="server"  Text="MakePayment" CssClass="btn btn-primary" OnClick="makePaymentButton_Click" />
            </div>
                 
            
                 
            
            
            
        


       






    
</asp:Content>