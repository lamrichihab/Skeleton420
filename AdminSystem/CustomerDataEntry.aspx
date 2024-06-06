<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .container {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .container h1 {
            text-align: center;
            margin-bottom: 20px;
        }
        .form-group {
            display: flex;
            align-items: center;
            margin-bottom: 15px;
        }
        .form-group label {
            flex: 0 0 150px;
            font-weight: bold;
        }
        .form-group input,
        .form-group .aspNetDisabledTextBox {
            flex: 1;
            padding: 8px;
            font-size: 14px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        .form-group input[type="checkbox"] {
            width: auto;
        }
        .form-group .findButton {
            margin-left: 10px;
            padding: 8px 16px;
        }
        .button-group {
            text-align: center;
            margin-top: 20px;
        }
        .button-group button {
            margin: 0 10px;
            padding: 10px 20px;
            font-size: 16px;
        }
        .error-message {
            color: red;
            text-align: center;
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Customer Data Entry</h1>
            <div class="form-group">
                <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" AssociatedControlID="txtCustomerID" />
                <asp:TextBox ID="txtCustomerID" runat="server" TextMode="Number" />
                <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="findButton" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblFullName" runat="server" Text="Full Name" AssociatedControlID="txtFullName" />
                <asp:TextBox ID="txtFullName" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address" AssociatedControlID="txtEmailAddress" />
                <asp:TextBox ID="txtEmailAddress" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number" AssociatedControlID="txtPhoneNumber" />
                <asp:TextBox ID="txtPhoneNumber" runat="server" TextMode="Phone" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address" AssociatedControlID="txtShippingAddress" />
                <asp:TextBox ID="txtShippingAddress" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblAccountCreationDate" runat="server" Text="Account Creation Date" AssociatedControlID="txtAccountCreationDate" />
                <asp:TextBox ID="txtAccountCreationDate" runat="server" TextMode="Date" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblIsActive" runat="server" Text="Is Active" AssociatedControlID="chkIsActive" />
                <asp:CheckBox ID="chkIsActive" runat="server" />
            </div>
            <!-- Error message label -->
            <div class="error-message">
                <asp:Label ID="lblError" runat="server" Text="" Visible="False" />
            </div>
            <!-- OK and Cancel buttons -->
            <div class="button-group">
                <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
