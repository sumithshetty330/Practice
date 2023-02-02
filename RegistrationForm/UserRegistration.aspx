<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="RegistrationForm.UserRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
<div class="col-md-4 col-md-offset-4">
<h1 style="width: 520px">Registration Form</h1>
</div>
</header>
    <div class="panel-body">
    <div class="row">
    <div class="col-md-4 col-md-offset-1">
    <div class="form-group">
    <asp:Label runat="server" AssociatedControlID="txtUserName"><b>User Name</b></asp:Label><br />
    <asp:TextBox runat="server" required="required" Enabled="true" Font-Names="BrandName" ID="txtUserName" CssClass="form-control input-sm" placeholder="User Name"></asp:TextBox>
    
    
    <div class="row">
    <div class="col-md-4 col-md-offset-1">
    <div class="form-group">
    <asp:Label runat="server" AssociatedControlID="txtAge"><b>Age</b></asp:Label><br />
    <asp:TextBox runat="server" required="required" Enabled="true" Font-Names="BrandName" ID="txtAge" CssClass="form-control input-sm" placeholder="Age" Width="778px"></asp:TextBox>

   
    <div class="row">
    <div class="col-md-4 col-md-offset-1">
    <div class="form-group">
    <asp:Label runat="server" AssociatedControlID="txtEmailID" Width="97px"><b>Email ID</b></asp:Label><br />
    <asp:TextBox runat="server" required="required" Enabled="true" Font-Names="BrandName" ID="txtEmailID" CssClass="form-control input-sm" placeholder="Email ID" Width="778px"></asp:TextBox>

    <div class="row">
    <div class="col-md-4 col-md-offset-1">
    <div class="form-group">
    <asp:Label runat="server" AssociatedControlID="txtPassword" Width="73px"><b>Password</b></asp:Label><br />
    <asp:TextBox runat="server" required="required" Enabled="true" Font-Names="BrandName" ID="txtPassword" CssClass="form-control input-sm" placeholder="Password" Width="778px"></asp:TextBox>

    <div class="row">
    <div class="col-md-4 col-md-offset-1">
    <div class="form-group">
    <asp:Label runat="server" AssociatedControlID="txtCNFPWD" Width="151px"><b>Confirm Password</b></asp:Label><br />
    <asp:TextBox runat="server" required="required" Enabled="true" Font-Names="BrandName" ID="txtCNFPWD" CssClass="form-control input-sm" placeholder="Confirm Password" Width="778px"></asp:TextBox>
    <div class="row"
        <div class="col-md-8 col-md-offset-2">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnButton" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnButton_Click" />
    </div>
    </div>
    </div>
    </div>
    </div>
</section>
</div>
</div>
</section>
</section>
</asp:Content>





