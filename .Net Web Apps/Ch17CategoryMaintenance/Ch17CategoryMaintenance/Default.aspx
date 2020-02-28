<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ch17CategoryMaintenance.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ch17: Category Maintenance</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
<div class="container">
    <header class="jumbotron"><%-- image set in site.css --%></header>
    <main>
    <form id="form1" runat="server" class="form-horizontal">

        <div class="row">
            <div class="col-xs-12 table-responsive">
                <h1>Category Maintenance</h1>
                <asp:GridView ID="GridView1" runat="server"
                    AutoGenerateColumns="False" DataKeyNames="CategoryID"
                    DataSourceID="ObjectDataSource1"
                    OnPreRender="GridView1_PreRender"
                    OnRowDeleted="GridView1_RowDeleted"
                    OnRowUpdated="GridView1_RowUpdated" 
                    CssClass="table table-bordered table-condensed table-hover">
                    <Columns>
                        <asp:BoundField DataField="CategoryID" HeaderText="ID"
                            ReadOnly="True">
                            <ItemStyle CssClass="col-xs-1" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ShortName" HeaderText="Short Name"
                            SortExpression="ShortName">
                            <ItemStyle CssClass="col-xs-3" />
                        </asp:BoundField>
                        <asp:BoundField DataField="LongName" HeaderText="Long Name"
                            SortExpression="LongName">
                            <ItemStyle CssClass="col-xs-5" />
                        </asp:BoundField>
                        <asp:CommandField ButtonType="Link" CausesValidation="false"
                            ShowEditButton="true">
                            <ItemStyle CssClass="col-xs-1 text-danger" />
                        </asp:CommandField>
                        <asp:CommandField ButtonType="Link" CausesValidation="false"
                            ShowDeleteButton="true">
                            <ItemStyle CssClass="col-xs-1" />
                        </asp:CommandField>
                    </Columns>
                    <HeaderStyle CssClass="bg-halloween" />
                    <AlternatingRowStyle CssClass="altRow" />
                    <EditRowStyle CssClass="warning" />
                </asp:GridView>
                <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" 
                    DataObjectTypeName="Category" DeleteMethod="DeleteCategory" 
                    InsertMethod="InsertCategory" 
                    OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetCategories" TypeName="CategoryDB" 
                    UpdateMethod="UpdateCategory" 
                    ConflictDetection="CompareAllValues" 
                    OnDeleted="ObjectDataSource1_GetAffectedRows" 
                    OnUpdated="ObjectDataSource1_GetAffectedRows">
                    <UpdateParameters>
                        <asp:Parameter Name="original_Category" Type="Object"></asp:Parameter>
                        <asp:Parameter Name="category" Type="Object"></asp:Parameter>
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-6">
                <p>To create a new category, enter the category information 
                    and click Insert</p>
                <p><asp:Label ID="lblError" runat="server" EnableViewState="false" 
                        CssClass="text-danger"></asp:Label></p>

                <asp:DetailsView ID="DetailsView1" runat="server"
                    AutoGenerateRows="false" DataSourceID="ObjectDataSource1" 
                    DefaultMode="Insert" OnItemInserted="DetailsView1_ItemInserted" 
                    CssClass="table table-bordered table-condensed">
                    <Fields>
                        <asp:BoundField DataField="CategoryID" HeaderText="Category ID:"></asp:BoundField>
                        <asp:BoundField DataField="ShortName" HeaderText="Short Name:"></asp:BoundField>
                        <asp:BoundField DataField="LongName" HeaderText="Long Name:"></asp:BoundField>
                        <asp:CommandField ButtonType="Link" ShowInsertButton="true" />
                    </Fields>
                    <RowStyle BackColor="#f5f5f5" />
                    <CommandRowStyle BackColor="#8c8c8c" ForeColor="white" />
                </asp:DetailsView>
            </div>  
        </div>

    </form>
    </main>
</div>
</body>
</html>
