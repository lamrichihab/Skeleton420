<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Stock Data Entry</h1>
        </div>
        <p>
            <asp:Label ID="lblProductID" runat="server" Text="Product ID" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtProductID" runat="server" style="width: 150px;" TextMode="Number" />
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="findButton" />
        </p>
        <p>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtProductName" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblCategory" runat="server" Text="Category" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtArrivedOn" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblQuantityInStock" runat="server" Text="Quantity in Stock" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtQuantityInStock" runat="server" style="width: 150px;" TextMode="Number" />
        </p>
        <p>
            <asp:Label ID="lblSize" runat="server" Text="Size" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtSize" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblSupplierID" runat="server" Text="Supplier ID" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtSupplierID" runat="server" style="width: 150px;" TextMode="Number" />
        </p>
        <p>
            <asp:Label ID="lblAvailable" runat="server" Text="Available" style="display: inline-block; width: 120px;" />
            <asp:CheckBox ID="chkAvailable" runat="server" />
        </p>
        <!-- Error message label -->
        <p>
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Visible="False" />
        </p>
        <!-- OK and Cancel buttons -->
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Button ID="btnReturn" runat="server" Text="Return" Width="77px" OnClick="btnReturn_Click" />

        </p>
    </form>
</body>
</html>
