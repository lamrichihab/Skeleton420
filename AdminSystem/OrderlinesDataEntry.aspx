<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderlinesDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is the Order lines Data Entry page.
        </div>
        <p>
            <asp:Label ID="lblProductId" runat="server" Text="Product ID" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtProductId" runat="server" style="width: 158px;" TextMode="Number" height="22px" />
        </p>
        <p>
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtOrderId" runat="server" style="width: 158px;" height="22px" />
        </p>
        <p>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtQuantity" runat="server" style="width: 158px;" height="22px" />
        </p>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text="Price" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtPrice" runat="server" style="width: 158px;" TextMode="Phone" height="22px" />
        </p>
        <p>
            <asp:Label ID="lblLocation" runat="server" Text="Location" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtLocation" runat="server" style="width: 158px;" height="22px" />
        </p>
        <p>
            <asp:Label ID="lblOrderStatus" runat="server" Text="Order status" style="display: inline-block; width: 120px;" />
            <asp:TextBox ID="txtOrderStatus" runat="server" style="width: 150px;"  />
        </p>
        <p>
            

           
                <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 214px; top: 361px; position: absolute; height: 26px; width: 78px;" Text="Cancel" />
    <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 118px; top: 362px; position: absolute" Text="Ok" height="26px" width="78px" />
</p>
<p>
    &nbsp;</p>
    </form>
</body>
</html>

