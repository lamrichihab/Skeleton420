<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>    
    <form id="form1" runat="server">
        <div>
            This is the Order page.
        </div>
        <p>
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtOrderId" runat="server" style="width: 150px;" TextMode="Number" />
        </p>
        <p>
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtCustomerId" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblEmployeeId" runat="server" Text="Employee ID" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtEmployeeId" runat="server" style="width: 150px;" />
        </p>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtOrderDate" runat="server" style="width: 150px;" TextMode="Date" />
        </p>
        <p>
            <asp:Label ID="lblRequiredDate" runat="server" Text="Required Date" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtRequiredDate" runat="server" style="width: 150px;" TextMode="Date" />
        </p>
        <p>
            
            <asp:Label ID="lblShipped" runat="server" Text="Shipped" style="display: inline-block; width: 120px;" />
            <asp:CheckBox ID="chkShipped" runat="server" />
            
        </p>
        <p>
            &nbsp;</p>
        <p>
           
            <asp:Button ID="btnCancel" runat="server"  style="z-index: 1; left: 189px; top: 325px; position: absolute; height: 26px; width: 53px;" Text="Cancel" />
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 129px; top: 324px; position: absolute" Text="Ok" />
        </p>
    </form>
</body>
</html>
