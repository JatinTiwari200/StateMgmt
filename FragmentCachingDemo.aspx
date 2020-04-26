<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FragmentCachingDemo.aspx.cs" Inherits="StateMgmt.FragmentCachingDemo" %>

<%@ Register src="WebUserControlDemo.ascx" tagname="WebUserControlDemo" tagprefix="uc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" BorderStyle="Solid" Font-Bold="False" ForeColor="Lime" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <uc1:WebUserControlDemo ID="WebUserControlDemo1" runat="server" />
        </div>
    </form>
</body>
</html>
