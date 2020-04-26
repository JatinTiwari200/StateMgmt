<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateEx2.aspx.cs" Inherits="StateMgmt.ViewStateEx2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
    Name:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSetViewState" runat="server" onclick="btnSetViewState_Click" 
        Text="Set ViewState" />
    <asp:Button ID="btnGetViewState" runat="server" onclick="btnGetViewState_Click" 
        Text="Get ViewState" />

        </div>
    </form>
</body>
</html>
