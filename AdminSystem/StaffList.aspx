<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 7px; top: 33px; position: absolute; height: 210px; width: 393px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" Text="Add" Style="z-index: 1; left: 10px; top: 250px; position: absolute; right: 873px;" OnClick="btnAdd_Click" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnEdit" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 82px; top: 251px; position: absolute; height: 35px; width: 53px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 297px; position: absolute"></asp:Label>
    </form>
</body>
</html>
