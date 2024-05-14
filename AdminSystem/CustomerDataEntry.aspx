<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry</title>
    <style>
        .findButton {
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Customer Data Entry</h1>
        </div>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtCustomerID" runat="server" style="width: 150px;" TextMode="Number" />
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="findButton" />
        </p>
        <p>
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtFullName" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtEmailAddress" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtPhoneNumber" runat="server" style="width: 150px;" TextMode="Phone" />
        </p>
        <p>
            <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtShippingAddress" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblAccountCreationDate" runat="server" Text="Account Creation Date" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtAccountCreationDate" runat="server" style="width: 150px;" TextMode="Date" />
        </p>
        <p>
            <asp:Label ID="lblIsActive" runat="server" Text="Is Active" style="display: inline-block; width: 120px;" />
            <asp:CheckBox ID="chkIsActive" runat="server" />
        </p>
        <!-- Error message label -->
        <p>
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Visible="False" />
        </p>
        <!-- OK and Cancel buttons -->
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
