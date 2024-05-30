<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWarning" runat="server" Text="420 Main Menu"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnCustomerData" runat="server" Height="35px" OnClick="btnCustomer_Click" Text="Customer" Width="80px" />
            &nbsp;
            <asp:Button ID="btnStockData" runat="server" Height="35px" OnClick="btnStockData_Click" Text="Stock" Width="80px" />
            <asp:Button ID="btnStaffData" runat="server" style="z-index: 1; left: 204px; top: 53px; position: absolute; width: 80px; height: 35px" Text="Staff" OnClick="btnStaffData_Click" />
            <asp:Button ID="btnSupplierData" runat="server" OnClick="btnSupplierData_Click" style="z-index: 1; top: 52px; position: absolute; width: 80px; height: 35px; left: 319px" Text="Supplier" />
            <br />
        </div>
    </form>
</body>
</html>

