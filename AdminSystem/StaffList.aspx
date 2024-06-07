<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
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
        .form-group input[type="button"],
        .form-group button,
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
        .user-info {
            text-align: right;
            margin-bottom: 20px;
            font-size: 14px;
        }
        .listbox-container {
            margin-bottom: 20px;
        }
        .listbox-container asp:ListBox {
            width: 100%;
            height: 300px;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-container">
        <div class="user-info">
            <asp:Label ID="lblUserName" runat="server" Text="Username"></asp:Label>
        </div>
        <h1>Staff Management</h1>
        <div class="listbox-container">
            <asp:ListBox ID="lstStaffList" runat="server" Height="258px" Width="573px"></asp:ListBox>
        </div>
        <div class="button-group">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="inline" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" CssClass="inline" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" CssClass="inline" />
        </div>
        <div class="form-group spacer">
            <asp:Label ID="lblStatement" runat="server" Text="Filter by Department"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" />
        </div>
        <div class="button-group spacer">
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" CssClass="inline" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" CssClass="inline" />
            <asp:Button ID="btnReturn" runat="server" Text="Return to Main Menu" CssClass="inline" OnClick="btnReturn_Click" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblError" runat="server" CssClass="error-label"></asp:Label>
        </div>
    </form>
</body>
</html>
