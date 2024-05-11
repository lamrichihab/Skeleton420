﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Viewer</title>
</head>
<body>
    <div>
        <h1>Stock Information</h1>
        <!-- Call the function from the code-behind to get stock info -->
        <%= GetStockInfo() %>
    </div>
</body>
</html>
