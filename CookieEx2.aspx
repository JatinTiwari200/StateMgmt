<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieEx2.aspx.cs" Inherits="StateMgmt.CookieEx2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GetProductId" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="GetProductName" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="GetUnitPrice" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="GetAllCookies" />
        </div>
    </form>
</body>
</html>
