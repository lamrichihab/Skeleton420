<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form2" runat="server">
    <div>
    </div>
    <asp:ListBox ID="lstCustomerList" runat="server" Height="316px" Width="364px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged"></asp:ListBox>
    <br />
    <br />
    <asp:Button ID="btnAdd" runat="server" Height="35px" OnClick="btnAdd_Click" Text="Add" Width="80px" />
&nbsp;
       <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Height="36px" Width="81px" />
&nbsp;
       <asp:Label ID="lblError" runat="server" Width="420px"></asp:Label>
    </form>
</body>
</html>
