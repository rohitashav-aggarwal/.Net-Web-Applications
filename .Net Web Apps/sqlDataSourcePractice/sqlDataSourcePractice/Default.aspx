<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sqlDataSourcePractice.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="InvoiceNumber" DataValueField="InvoiceNumber">
                <asp:ListItem>ID</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:HalloweenConnectionString %>" SelectCommand="SELECT [InvoiceNumber] FROM [Invoices]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HalloweenConnectionString %>" SelectCommand="SELECT [InvoiceNumber], [CustEmail], [OrderDate], [SalesTax], [Total] FROM [Invoices] WHERE ([InvoiceNumber] = @InvoiceNumber)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="InvoiceNumber" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="InvoiceNumber" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="InvoiceNumber" HeaderText="InvoiceNumber" InsertVisible="False" ReadOnly="True" SortExpression="InvoiceNumber" />
                    <asp:BoundField DataField="CustEmail" HeaderText="CustEmail" SortExpression="CustEmail" />
                    <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" />
                    <asp:BoundField DataField="SalesTax" HeaderText="SalesTax" SortExpression="SalesTax" />
                    <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
