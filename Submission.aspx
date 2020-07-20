<%@ Page Title="Online School Registration System - Submission Successful" Language="C#" Async="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Submission.aspx.cs" Inherits="EDUnited.Submission" MaintainScrollPositionOnPostBack="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1><%: System.Configuration.ConfigurationManager.AppSettings["SchoolName"] %></h1>
        <p class="lead">Online School Registration System</p>
    </div>

    <div class="titlebar">
        <p class="lead">Submission Successful</p>
        <p>
            Your registration submission has been sent.  If there are any questions processsing the registration or we have additional questions, we will contact you.
        </p>
    </div>        
    <div class="titlebar">
    </div>
</asp:Content>
