<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierViewer.aspx.cs" Inherits="_1_SupplierViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Supplier Information</h1>
            <!-- Call the function from the code-behind to get supplier info -->
            <%= GetSupplierInfo() %>
        </div>
    </form>
</body>
</html>
