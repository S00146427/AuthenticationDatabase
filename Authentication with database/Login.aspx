<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Authentication_with_database.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Not Registered?"></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server"></asp:HyperLink>
        <br /><br />

        <asp:Label ID="lblLogin" runat="server" Text="LOGIN" Font-Bold="true"></asp:Label>

        <br /><br />

        <asp:Label ID="lblName" runat="server" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUName" runat="server"></asp:TextBox>

        <br /><br />

        <asp:Label ID="lblPass" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPasswd" runat="server" TextMode="Password"></asp:TextBox>

        <br /><br />

        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

        <br /><br />

        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

    </div>
    </form>
</body>
</html>
