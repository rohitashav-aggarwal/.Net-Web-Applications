<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RohitashavAggarwal_CPRG214_Lab1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" runat="server" media="screen" href="~/Styles/TempConv.css" />
</head>
<body>
    <header>
        <asp:Image ID="Image1" alt ="Temperature Logo" src="Images/Temperature.jfif" runat="server" Height="149px" Width="175px" />
        <h3>Temperature Converter</h3>
    </header>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFrom" runat="server" Text="From"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTo" runat="server" Text="To"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownListFrom" runat="server">
                <asp:ListItem Selected="True">Celsius</asp:ListItem>
                <asp:ListItem>Farenheit</asp:ListItem>
                <asp:ListItem>Kelvin</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownListTo" runat="server">
                <asp:ListItem Selected="True">Farenheit</asp:ListItem>
                <asp:ListItem>Celsius</asp:ListItem>
                <asp:ListItem>Kelvin</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
        </div>

        <div>
            Input Temperature:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtInput" runat="server" Height="18px" Width="165px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidatorInput" runat="server" ControlToValidate="txtInput" Display="Dynamic" ErrorMessage="Input value must be between 1000 and -1000" ForeColor="#FF0066" MaximumValue="1000" MinimumValue= "-1000" Type="Double"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtInput" Display="Dynamic" ErrorMessage="Field must not be empty" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            <br />
            <br />
        </div>

        <div>

            Output Temperature:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOutput" runat="server" Width="165px" Height="18px" style="margin-left: 0px"></asp:TextBox>
            <br />
            <br />
            <br />

        </div>
        <div>
            <asp:Button ID="btnConvert" runat="server" Text="Convert" OnClick="btnConvert_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" Text="Clear" Width="83px" OnClick="btnClear_Click" CausesValidation ="false" />
        </div>
    </form>
</body>
</html>
