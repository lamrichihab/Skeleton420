<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffViewer.aspx.cs" Inherits="_1_StaffViewer" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Viewer</title>
</head>
<body>
    <div>
        <h1>Staff Information</h1>
        <!-- Call the function from the code-behind to get staff info -->
        <%= GetStaffInfo() %>
    </div>
</body>
</html>
