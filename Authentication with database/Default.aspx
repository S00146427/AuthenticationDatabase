<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Authentication_with_database.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label>Welcome to the WebSite</label>
        <br /><br />
        
        <asp:Label ID="Label2" runat="server" Text="The Authentication Cookie looks like this ----"></asp:Label>
        <asp:Label ID="lblAuthCookie" runat="server" Text="Label"></asp:Label>

        <br /><br />

        <asp:Label ID="Label1" runat="server" Text="UserName is ----"></asp:Label>
        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>

         <br /><br />

        <asp:Label ID="Label4" runat="server" Text="The Authentication Cookie Path is ----"></asp:Label>
        <asp:Label ID="lblCookiePath" runat="server" Text="Label"></asp:Label>

        <br /><br />
        
        <asp:Button ID="BtnSignOut" runat="server" Text="SignOut" />

        
    </div>
    </form>
</body>
</html>
