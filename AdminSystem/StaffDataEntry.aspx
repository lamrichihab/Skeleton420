<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_StaffDataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
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
            <h1>Staff Data Entry</h1>
            <div class="form-group">
                <asp:Label ID="lblEmployeeID" runat="server" Text="Employee ID" AssociatedControlID="txtEmployeeID" />
                <asp:TextBox ID="txtEmployeeID" runat="server" TextMode="Number" />
                <asp:Button ID="BtnFind" runat="server" Text="Find" OnClick="BtnFind_Click" CssClass="findButton" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblFullName" runat="server" Text="Full Name" AssociatedControlID="txtFullName" />
                <asp:TextBox ID="txtFullName" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblRole" runat="server" Text="Role" AssociatedControlID="txtRole" />
                <asp:TextBox ID="txtRole" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblContactPhone" runat="server" Text="Contact Phone" AssociatedControlID="txtContactPhone" />
                <asp:TextBox ID="txtContactPhone" runat="server" TextMode="Phone" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblContactEmail" runat="server" Text="Contact Email" AssociatedControlID="txtContactEmail" />
                <asp:TextBox ID="txtContactEmail" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblDepartment" runat="server" Text="Department" AssociatedControlID="txtDepartment" />
                <asp:TextBox ID="txtDepartment" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblIsActive" runat="server" Text="Active" AssociatedControlID="chkIsActive" />
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
            </div>
        </div>
    </form>
</body>
</html>
