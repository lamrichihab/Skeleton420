<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .container {
            display: flex;
            flex-direction: column;
            align-items: center;
            margin-top: 50px;
        }
        .button-group {
            display: flex;
            gap: 10px;
            margin-top: 20px;
        }
        .button-group .btn {
            width: 100px;
            height: 40px;
            font-size: 16px;
        }
        .header {
            font-size: 24px;
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="lblWarning" runat="server" CssClass="header" Text="420 Main Menu"></asp:Label>
            <div class="button-group">
                <asp:Button ID="btnCustomerData" runat="server" CssClass="btn" OnClick="btnCustomer_Click" Text="Customer" />
                <asp:Button ID="btnStockData" runat="server" CssClass="btn" OnClick="btnStockData_Click" Text="Stock" />
                <asp:Button ID="btnStaffData" runat="server" CssClass="btn" OnClick="btnStaffData_Click" Text="Staff" />
                <asp:Button ID="btnSupplierData" runat="server" CssClass="btn" OnClick="btnSupplierData_Click" Text="Supplier" />
            </div>
        </div>
    </form>
</body>
</html>
