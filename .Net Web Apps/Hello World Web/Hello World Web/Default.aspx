<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hello_World_Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--h1>Hello World</h1>--%>
        <asp:Label ID="lblGreeting" runat="server" Text="Hello World!" Font-Bold="True" Font-Size="XX-Large" ForeColor="#660066"></asp:Label>
        <div>

            <asp:Image ID="Image1" runat="server" Height="174px" ImageAlign="Middle" ImageUrl="~/Images/mountains.jpeg" Width="326px" />
            <br />
            <br />
            <asp:Button ID="btnChange" runat="server" OnClick="btnChange_Click" Text="Change Image" />
            <br />
            <br />
            What is your name? <asp:TextBox ID="txtName" runat="server" Width="192px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnGreet" runat="server" BackColor="#FFCCFF" OnClick="btnGreet_Click" Text="Greet Me" Width="85px" />
            <br />
            <br />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" Width="85px" />

        </div>
    </form>
</body>
</html>
