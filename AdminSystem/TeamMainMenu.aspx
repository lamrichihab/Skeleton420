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
            <br />
        </div>
    </form>
</body>
</html>

