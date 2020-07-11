﻿<%@ Page Title="Online School Registration System - File Decryptor" Language="C#" Async="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Decryption.aspx.cs" Inherits="EDUnited.Decryption" MaintainScrollPositionOnPostBack="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1><%: System.Configuration.ConfigurationManager.AppSettings["SchoolName"] %></h1>
        <p class="lead">Online School Registration System</p>
    </div>

    <div class="titlebar">
        <p class="lead">File Decryptor</p>
        <p>
            This form is to be used by the hosting school system to decrypt the submissions made for registration.
        </p>
    </div> 
    <div class="row">
        <div class="col-md-3">
            <p>
                Choose file to decrypt:
            </p>

        </div>
        <div class="col-md-9">
            <asp:FileUpload ID="fuSupportingDocs" runat="server" AllowMultiple="False"  /> 
            <asp:RegularExpressionValidator ID="valExpressionFileUpload" runat="server" ControlToValidate="fuSupportingDocs" ErrorMessage="Only encrypted zip files are supported" ValidationExpression="(.*_enc\.([Zz][Ii][Pp])$)" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
         <div class="col-md-3">
        </div>
        <div class="col-md-9">
            <asp:Button ID="cmdDecryptFiles" runat="server" Text="Decrypt Files" CssClass="button" OnClick="cmdDecryptFiles_Click" />
        </div>
    </div>    
    <div class="titlebar">
    </div>
</asp:Content>
