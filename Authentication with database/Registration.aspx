<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Authentication_with_database.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br /><br />

        <asp:Label ID="lblName" runat="server" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

        <br /><br />

        <asp:Label ID="lblPass" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

        <br /><br />

        <asp:Button ID="btnReg" runat="server" Text="Register" OnClick="btnReg_Click"/>

        <br /><br />

        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

    </div>
    </form>
</body>
</html>
