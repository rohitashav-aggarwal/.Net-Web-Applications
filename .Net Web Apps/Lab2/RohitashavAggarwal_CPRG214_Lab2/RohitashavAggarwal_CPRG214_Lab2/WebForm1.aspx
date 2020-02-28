<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RohitashavAggarwal_CPRG214_Lab2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    Select a Technician to see the incidents associated with them:<br />
    <br />
    Technician:
    <asp:DropDownList ID="ddlTechnicians" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="TechID"></asp:DropDownList>
    <br />
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetTechnicians" TypeName="RohitashavAggarwal_CPRG214_Lab2.TechnicianDB"></asp:ObjectDataSource>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource2" DataKeyNames="IncidentID" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" OnRowUpdating="GridView1_RowUpdating" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="IncidentID" HeaderText="IncidentID" ReadOnly="True" SortExpression="IncidentID" />
            <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
            <asp:BoundField DataField="ProductCode" HeaderText="ProductCode" ReadOnly="True" SortExpression="ProductCode" />
            <asp:BoundField DataField="TechnicianID" HeaderText="TechnicianID" ReadOnly="True" SortExpression="TechnicianID" />
            <asp:BoundField DataField="DateOpen" HeaderText="DateOpen" ReadOnly="True" SortExpression="DateOpen" />
            <asp:BoundField DataField="DateClose" HeaderText="DateClose" SortExpression="DateClose" DataFormatString="{0:G}" />
            <asp:BoundField DataField="Title" HeaderText="Title" ReadOnly="True" SortExpression="Title" />
            <asp:BoundField DataField="Decription" HeaderText="Decription" SortExpression="Decription" />
            <asp:CommandField ButtonType="Button" ShowCancelButton="False" ShowEditButton="True" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
    <br />

    <br />
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetIncidents" TypeName="RohitashavAggarwal_CPRG214_Lab2.IncidentDB" DataObjectTypeName="RohitashavAggarwal_CPRG214_Lab2.Incident" UpdateMethod="UpdateIncidents">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlTechnicians" Name="TechnicianID" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
    * Note: Only DateClose and Description are editable.<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; If the DateClose is less than DateOpen, it will be set to null.<br />
</asp:Content>
