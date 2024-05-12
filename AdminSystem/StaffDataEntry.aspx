<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_StaffDataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Staff Data Entry</h1>
        </div>
        <p>
            <asp:Label ID="lblEmployeeID" runat="server" Text="Employee ID" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtEmployeeID" runat="server" style="width: 150px;" TextMode="Number" />
        </p>
        <p>
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtFullName" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblRole" runat="server" Text="Role" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtRole" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblContactPhone" runat="server" Text="Contact Phone" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtContactPhone" runat="server" style="width: 150px;" TextMode="Phone" />
        </p>
        <p>
            <asp:Label ID="lblContactEmail" runat="server" Text="Contact Email" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtContactEmail" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblDepartment" runat="server" Text="Department" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtDepartment" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:CheckBox ID="chkIsActive" runat="server" Text="Active" />
        </p>
        <!-- Error message label -->
        <p>
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Visible="False" />
        </p>
        <!-- OK and Cancel buttons -->
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
