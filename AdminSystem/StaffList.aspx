<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div></div>
        <asp:ListBox ID="lstStaffList" runat="server" 
            Style="z-index: 1; left: 23px; top: 45px; position: absolute; height: 210px; width: 393px" 
          ></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" Text="Add" 
            Style="z-index: 1; left: 19px; top: 283px; position: absolute; width: 40px; height: 30px;" 
            OnClick="btnAdd_Click" />
        <asp:Label ID="lblError" runat="server" 
            Style="z-index: 1; left: 10px; top: 423px; position: absolute"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="BtnEdit_Click" 
            Style="z-index: 1; top: 284px; position: absolute; height: 30px; width: 40px; right: 1355px;" 
            Text="Edit" />
        <asp:Label ID="lbDepartment" runat="server" 
            Style="z-index: 1; left: 60px; top: 337px; position: absolute; height: 23px; right: 1332px" 
            Text="Enter a Department"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" 
            Style="z-index: 1; left: 198px; top: 336px; position: absolute; width: 135px"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" 
            Style="z-index: 1; left: 124px; top: 380px; position: absolute; height: 25px; width: 90px" 
            Text="Apply Filter" />
        <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click" 
            Style="z-index: 1; top: 282px; position: absolute; height: 30px; width: 40px; left: 217px" 
            Text="Delete" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="Button1_Click1" 
            Style="z-index: 1; top: 380px; position: absolute; height: 25px; width: 88px; left: 254px" 
            Text="Clear Filter" />
    </form>
</body>
</html>
