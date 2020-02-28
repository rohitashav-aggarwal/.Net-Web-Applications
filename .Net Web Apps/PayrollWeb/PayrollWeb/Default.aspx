<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PayrollWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payroll Calculator</title>
    <meta name="viewport" content="width=device-width,initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body >
    
   <div class="container">
     <header class="jumbotron ">
        <img id="logo" alt="Calculator logo" src="Images/PayrollLogo.jpg" class="img-rounded img-responsive"/>
        <h1>Payroll Calculator</h1>
        </header> 
    <main>
     <form id="form1" runat="server" class="form-horizontal" role="form">
        <div class="form-group row">
                <label class="control-label col-md-3" for="hoursworked">Hours Worked:</label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtHours" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
               <div class="col-md-6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtHours" ErrorMessage="Hours worked is required." ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="Hours need to be a number 0 to 80." ForeColor="#993399" Type="Double" ControlToValidate="txtHours" Display="Dynamic" MaximumValue="80" MinimumValue="0"></asp:RangeValidator>
               </div>
        </div>

        <div class="form-group horizontal row has-success has-feedback">
            <label class="control-label col-md-3" for="hourlyrate">Hourly Rate:</label>
            <div class="col-md-3">
               <div class="input-group">
                   <div class="prepend"><span class="input-group-text">$</span></div>
                   <asp:TextBox ID="txtRate" runat="server" CssClass="form-control"></asp:TextBox>
               </div>
            </div>
                <div class="col-md-6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Hourly rate is required." ForeColor="Red" ControlToValidate="txtRate" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtRate" Display="Dynamic" ErrorMessage="Hourly rate should be 0-1000" ForeColor="#993399" MaximumValue="1000" MinimumValue="0" Type="Currency"></asp:RangeValidator>
               </div>
        </div>

       <div class="form-group horizontal row">  
                <label class="control-label col-md-3" for="payamount">Pay Amount:</label>
                <div class="col-md-3">
                    <asp:Label ID="lblPay" runat="server" CssClass="text-info"></asp:Label>
                </div>
      </div>
     
       <div class="form-group">
                <div class="col-md-offset-3 col-md-9">
                    <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" CssClass="btn btn-primary" />
                    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" CssClass="btn btn-primary" CausesValidation="False" />
                </div>
       </div>
    </form>
   </main>
  </div>

</body>
</html>
