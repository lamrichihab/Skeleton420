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
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 210px; width: 393px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" Text="Add" Style="z-index: 1; left: 10px; top: 250px; position: absolute;" OnClick="btnAdd_Click" />
    </form>
</body>
</html>
