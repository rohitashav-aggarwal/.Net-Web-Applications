<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MultiplePages.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>I am Form 1</h1>
        <div>
            Enter your name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnGo" runat="server" OnClick="btnGo_Click" PostBackUrl="~/WebForm2.aspx" Text="Go" />
            <br />
            <br />
            <asp:Button ID="btnSAIT" runat="server" OnClick="btnSAIT_Click" Text="Go to SAIT" />
        </div>
    </form>
</body>
</html>
