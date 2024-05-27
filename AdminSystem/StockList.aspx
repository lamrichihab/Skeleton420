<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Stock Management</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        .form-container {
            max-width: 500px;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #f9f9f9;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input[type="text"],
        .form-group input[type="button"],
        .form-group button,
        .form-group select {
            width: 100%;
            padding: 10px;
            box-sizing: border-box;
        }
        .form-group .inline {
            display: inline-block;
            width: auto;
        }
        .button-group {
            text-align: center;
        }
        .button-group input[type="button"],
        .button-group button {
            width: auto;
            padding: 10px 15px;
            margin: 5px;
        }
        .error-label {
            color: red;
            margin-top: 10px;
            display: block;
        }
        .spacer {
            margin-top: 10px;
        }
        .user-info {
            text-align: right;
            margin-bottom: 20px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server" class="form-container">
        <div class="user-info">
            <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label>
        </div>
        <div class="form-group">
            <asp:ListBox ID="lstStockList" runat="server" Height="316px" Width="364px"></asp:ListBox>
        </div>
        <div class="button-group">
            <asp:Button ID="btnAdd" runat="server" Height="30px" OnClick="btnAdd_Click" Text="Add" Width="60px" class="inline" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Height="30px" Width="60px" class="inline" />
            <asp:Button ID="btnDelete" runat="server" Height="30px" OnClick="btnDelete_Click" Text="Delete" Width="60px" class="inline" />
        </div>
        <div class="form-group spacer">
            <asp:Label ID="lblStatement" runat="server" Text="Enter the name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" Height="18px" Width="340px"></asp:TextBox>
        </div>
        <div class="button-group spacer">
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" class="inline" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" class="inline" />
            <asp:Button ID="btnReturn" runat="server" Text="Return to Main Menu" Width="168px" OnClick="btnReturn_Click" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblError" runat="server" Width="420px" CssClass="error-label"></asp:Label>
        </div>
    </form>
</body>
</html>
