<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionDemo1.aspx.cs" Inherits="StateMgmt.SessionDemo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             EmpId: 
        <asp:TextBox ID="txtEmpId" runat="server" />
        <br />
        EmpName:<asp:TextBox ID="txtEmpName" runat="server" />
        <br />
        Salary:<asp:TextBox ID="txtSalary" runat="server" />
        <br />
        <asp:Button ID="btnCreateSession" runat="server" Text="Create Session" 
            onclick="btnCreateSession_Click" />
        <br />
        <asp:Button ID="btnRedirect" runat="server" Text="Redirect" 
            onclick="btnRedirect_Click" />

        </div>
    </form>
</body>
</html>
