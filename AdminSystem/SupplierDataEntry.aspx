<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_SupplierDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Supplier Data Entry</h1>
        </div>
        <p>
            <asp:Label ID="lblSupplierID" runat="server" Text="Supplier ID" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtSupplierID" runat="server" style="width: 150px;" TextMode="Number" />
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 311px; top: 70px; position: absolute; width: 57px" Text="Find" />
        </p>
        <p>
            <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtSupplierName" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblContactName" runat="server" Text="Contact Name" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtContactName" runat="server" style="width: 150px;" />
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
            <asp:Label ID="lblAddress" runat="server" Text="Address" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtAddress" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:CheckBox ID="chkIsActive" runat="server" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Visible="False" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
