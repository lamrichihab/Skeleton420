﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWarning" runat="server" Text="Are you sure yo want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
&nbsp;<asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
    </form>
</body>
</html>

