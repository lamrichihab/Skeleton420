﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier List</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            background-color: #3D4D55;
        }
        .container {
            max-width: 600px;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #3D4D55;
            box-shadow: 0 2px 4px rgba(0,0,0,0.1);
        }
        .form-group {
            margin-bottom: 20px;
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
            width: calc(100% - 20px);
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 3px;
            box-sizing: border-box;
            margin-top: 5px;
        }
        .button-group {
            text-align: center;
        }
        .button-group input[type="button"],
        .button-group button {
            width: 100px;
            padding: 10px 15px;
            margin: 0 10px;
            border: none;
            border-radius: 3px;
            background-color: #A79E9C;
            color: #fff;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }
        .button-group input[type="button"]:hover,
        .button-group button:hover {
            background-color: #B58863;
        }
        .error-label {
            color: red;
            margin-top: 10px;
            display: block;
            font-size: 14px;
        }
        .spacer {
            margin-top: 20px;
        }
        .return-button {
            text-align: center;
            margin-top: 20px;
        }
        .return-button a {
            text-decoration: none;
            color: #B58863;
            font-weight: bold;
            transition: color 0.3s ease;
        }
        .return-button a:hover {
            color: #B58863;
        }
    </style>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
             <div class="user-info">
                <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label>
             </div>
            <div class="form-group">
                <label for="lstSupplierList">Supplier List</label>
                <asp:ListBox ID="lstSupplierList" runat="server" Style="height: 210px; width: 100%"/>
            </div>
            <div class="button-group">
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="Button1_Click" />
            </div>
            <div class="form-group spacer">
                <label for="txtFilter">Filter by Supplier Name</label>
                <asp:TextBox ID="txtFilter" runat="server" ></asp:TextBox>
                <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
                <asp:Button ID="btnClearFilter" runat="server" OnClick="Button1_Click1" Text="Clear Filter" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblError" runat="server" CssClass="error-label"></asp:Label>
            </div>
            <div class="return-button">
                <asp:Button ID="btnReturn" runat="server" Text="Return to Main Menu" OnClick="btnReturn_Click" />
            </div>
        </form>
    </div>
</body>
</html>
