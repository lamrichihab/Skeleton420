<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerViewer.aspx.cs" Inherits="_1Viewer" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Viewer</title>
</head>
<body>
    <div>
        <h1>Customer Information</h1>
        <!-- Call the function from the code-behind to get customer info -->
        <%= GetCustomerInfo() %>
    </div>
</body>
</html>
