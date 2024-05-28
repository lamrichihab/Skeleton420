<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 62px; top: 91px; position: absolute; width: 401px" Text="Are you sure you want to delete this record ?"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnNo" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 258px; top: 149px; position: absolute; width: 70px; height: 30px; right: 1182px" Text="No" />
        </p>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 89px; top: 148px; position: absolute; height: 30px; width: 70px" Text="Yes" />
        </p>
    </form>
</body>
</html>
