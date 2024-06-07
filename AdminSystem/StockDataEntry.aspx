<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Data Entry</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .form-container {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .form-container h1 {
            text-align: center;
            margin-bottom: 20px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        .form-group input[type="text"],
        .form-group input[type="number"],
        .form-group input[type="date"],
        .form-group select {
            width: 100%;
            padding: 10px;
            font-size: 14px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }
        .form-group .inline {
            display: inline-block;
            width: auto;
        }
        .button-group {
            text-align: center;
            margin-top: 20px;
        }
        .button-group input[type="button"],
        .button-group button {
            width: auto;
            padding: 10px 20px;
            margin: 5px;
            font-size: 14px;
        }
        .error-label {
            color: red;
            margin-top: 10px;
            display: block;
            text-align: center;
        }
        .spacer {
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-container">
        <h1>Stock Data Entry</h1>
        <div class="form-group">
            <label for="txtProductID">Product ID</label>
            <asp:TextBox ID="txtProductID" runat="server" CssClass="form-control" TextMode="Number" />
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="btn btn-primary" />
        </div>
        <div class="form-group">
            <label for="txtProductName">Product Name</label>
            <asp:TextBox ID="txtProductName" runat="server" CssClass="form-control" />
        </div>
        <div class="form-group">
            <label for="txtArrivedOn">Account Creation Date</label>
            <asp:TextBox ID="txtArrivedOn" runat="server" CssClass="form-control" TextMode="Date" />
        </div>
        <div class="form-group">
            <label for="txtQuantityInStock">Quantity in Stock</label>
            <asp:TextBox ID="txtQuantityInStock" runat="server" CssClass="form-control" TextMode="Number" />
        </div>
        <div class="form-group">
            <label for="txtSize">Size</label>
            <asp:TextBox ID="txtSize" runat="server" CssClass="form-control" />
        </div>
        <div class="form-group">
            <label for="txtSupplierID">Supplier ID</label>
            <asp:TextBox ID="txtSupplierID" runat="server" CssClass="form-control" TextMode="Number" />
        </div>
        <div class="form-group">
            <label for="chkAvailable">Available</label>
            <asp:CheckBox ID="chkAvailable" runat="server" CssClass="form-control" />
        </div>
        <!-- Error message label -->
        <div class="form-group">
            <asp:Label ID="lblError" runat="server" CssClass="error-label"></asp:Label>
        </div>
        <!-- OK and Cancel buttons -->
        <div class="button-group">
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" CssClass="btn btn-success" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="btn btn-danger" />
            <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" CssClass="btn btn-secondary" />
        </div>
    </form>
</body>
</html>
