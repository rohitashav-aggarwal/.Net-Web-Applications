<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MultiplePages.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>I am Form 2</h1>
        <div>
            Your name is&nbsp;
            <asp:Label ID="lblName" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnGoBack" runat="server" OnClick="btnGoBack_Click" PostBackUrl="~/WebForm1.aspx" Text="Go Back" />
        </div>
    </form>
</body>
</html>
