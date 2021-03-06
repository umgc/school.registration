﻿<%@ Page Title="Online School Registration System" Language="C#" Async="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EDUnited._Default" MaintainScrollPositionOnPostBack="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="jumbotron">
        <h1><%: System.Configuration.ConfigurationManager.AppSettings["SchoolName"] %></h1>
        <p class="lead">Online School Registration System</p>
    </div>

    <div class="titlebar">
        <p class="lead">Student Registration</p>
        <p>
            This form is to be completed by the parent, sponser or legal guardian of all students entering this school system. All new or re-registering students must submit verification of the following at the time of enrollment:
        </p>
        <ul>
            <li>Proof of residency</li>
            <li>Age</li>
            <li>Immunizations</li>
        </ul>
    </div>

    <div class="titlebar">
        <h4>Student Information</h4>
    </div>

    <div class="row">
        <div class="col-md-3">
            <p>
                Student's Legal Name:
            </p>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxStudentFirstName" runat="server" CssClass="tbxnormal" ToolTip="Enter student's legal first name" placeholder="First"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxStudentMiddleName" runat="server" CssClass="tbxnormal" ToolTip="Enter student's legal middle name" placeholder="Middle"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxStudentLastName" runat="server" CssClass="tbxnormal" ToolTip="Enter student's legal last name" placeholder="Last"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Gender:
            </p>
        </div>
        <div class="col-md-9">
            <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal" CssClass="rbl">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Date of Birth:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxDOB" runat="server" CausesValidation="True" MaxLength="8" CssClass="date onlynumbers" placeholder="MM/DD/YYYY"></asp:TextBox>
            <asp:RegularExpressionValidator ID="valExpressionMaskDOB" runat="server" ErrorMessage="Date of birth format MM/DD/YYYY" ValidationExpression="^[0-9]{8,8}$" ControlToValidate="tbxDOB" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Birthplace:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxBirthplace" runat="server" CssClass="tbxnormal"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Enrolling Grade:
            </p>
        </div>
        <div class="col-md-9">
            <asp:DropDownList ID="ddlEnrollingGrade" runat="server" CssClass="ddl">
                <asp:ListItem>Pre-K</asp:ListItem>
                <asp:ListItem>Kindergarten</asp:ListItem>
                <asp:ListItem>1st Grade</asp:ListItem>
                <asp:ListItem>2nd Grade</asp:ListItem>
                <asp:ListItem>3rd Grade</asp:ListItem>
                <asp:ListItem>4th Grade</asp:ListItem>
                <asp:ListItem>5th Grade</asp:ListItem>
                <asp:ListItem>6th Grade</asp:ListItem>
                <asp:ListItem>7th Grade</asp:ListItem>
                <asp:ListItem>8th Grade</asp:ListItem>
                <asp:ListItem>9th Grade</asp:ListItem>
                <asp:ListItem>10th Grade</asp:ListItem>
                <asp:ListItem>11th Grade</asp:ListItem>
                <asp:ListItem>12th Grade</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="titlebar">
        <h4>Ethnicity</h4>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Race:
            </p>
        </div>
        <div class="col-md-9">
            <asp:DropDownList ID="ddlRace" runat="server" CssClass="ddl">
                <asp:ListItem>American Indian or Alaska Native</asp:ListItem>
                <asp:ListItem>Asian</asp:ListItem>
                <asp:ListItem>Black or African American</asp:ListItem>
                <asp:ListItem>Native Hawaiian or Pacific Islander</asp:ListItem>
                <asp:ListItem>White</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Student Hispanic or Latino?
            </p>
        </div>
        <div class="col-md-9">
            <asp:RadioButtonList ID="rblHispanicLatinoQuestion" runat="server" RepeatDirection="Horizontal" CssClass="rbl">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div class="titlebar">
        <h4>Primary Language</h4>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Spoken in the Home:
            </p>
        </div>
        <div class="col-md-9">
            <asp:DropDownList ID="ddlLanguageSpokenInHome" runat="server" CssClass="ddl">
                <asp:ListItem>English</asp:ListItem>
                <asp:ListItem>Spanish</asp:ListItem>
                <asp:ListItem>Chinese</asp:ListItem>
                <asp:ListItem>Vietnamese</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Spoken by the Child:
            </p>
        </div>
        <div class="col-md-9">
            <asp:DropDownList ID="ddlLanguageSpokenByChild" runat="server" CssClass="ddl">
                <asp:ListItem>English</asp:ListItem>
                <asp:ListItem>Spanish</asp:ListItem>
                <asp:ListItem>Chinese</asp:ListItem>
                <asp:ListItem>Vietnamese</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="titlebar">
        <h4>Residency</h4>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Physical Address:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxPhysicalAddressStreet" runat="server" CssClass="tbxnormal" placeholder="Street"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxPhysicalAddressCity" runat="server" CssClass="tbxnormal" placeholder="City"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="ddlPhysicalAddressState" runat="server" CssClass="ddl">
                <asp:ListItem Value="AK">Alaska</asp:ListItem>

                <asp:ListItem Value="AZ">Arizona</asp:ListItem>

                <asp:ListItem Value="AR">Arkansas</asp:ListItem>

                <asp:ListItem Value="CA">California</asp:ListItem>

                <asp:ListItem Value="CO">Colorado</asp:ListItem>

                <asp:ListItem Value="CT">Connecticut</asp:ListItem>

                <asp:ListItem Value="DE">Delaware</asp:ListItem>

                <asp:ListItem Value="FL">Florida</asp:ListItem>

                <asp:ListItem Value="GA">Georgia</asp:ListItem>

                <asp:ListItem Value="HI">Hawaii</asp:ListItem>

                <asp:ListItem Value="ID">Idaho</asp:ListItem>

                <asp:ListItem Value="IL">Illinois</asp:ListItem>

                <asp:ListItem Value="IN">Indiana</asp:ListItem>

                <asp:ListItem Value="IA">Iowa</asp:ListItem>

                <asp:ListItem Value="KS">Kansas</asp:ListItem>

                <asp:ListItem Value="KY">Kentucky</asp:ListItem>

                <asp:ListItem Value="LA">Louisiana</asp:ListItem>

                <asp:ListItem Value="ME">Maine</asp:ListItem>

                <asp:ListItem Value="MD">Maryland</asp:ListItem>

                <asp:ListItem Value="MA">Massachusetts</asp:ListItem>

                <asp:ListItem Value="MI">Michigan</asp:ListItem>

                <asp:ListItem Value="MN">Minnesota</asp:ListItem>

                <asp:ListItem Value="MS">Mississippi</asp:ListItem>

                <asp:ListItem Value="MO">Missouri</asp:ListItem>

                <asp:ListItem Value="MT">Montana</asp:ListItem>

                <asp:ListItem Value="NE">Nebraska</asp:ListItem>

                <asp:ListItem Value="NV">Nevada</asp:ListItem>

                <asp:ListItem Value="NH">New Hampshire</asp:ListItem>

                <asp:ListItem Value="NJ">New Jersey</asp:ListItem>

                <asp:ListItem Value="NM">New Mexico</asp:ListItem>

                <asp:ListItem Value="NY">New York</asp:ListItem>

                <asp:ListItem Value="NC">North Carolina</asp:ListItem>

                <asp:ListItem Value="ND">North Dakota</asp:ListItem>

                <asp:ListItem Value="OH">Ohio</asp:ListItem>

                <asp:ListItem Value="OK">Oklahoma</asp:ListItem>

                <asp:ListItem Value="OR">Oregon</asp:ListItem>

                <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>

                <asp:ListItem Value="RI">Rhode Island</asp:ListItem>

                <asp:ListItem Value="SC">South Carolina</asp:ListItem>

                <asp:ListItem Value="SD">South Dakota</asp:ListItem>

                <asp:ListItem Value="TN">Tennessee</asp:ListItem>

                <asp:ListItem Value="TX">Texas</asp:ListItem>

                <asp:ListItem Value="UT">Utah</asp:ListItem>

                <asp:ListItem Value="VT">Vermont</asp:ListItem>

                <asp:ListItem Value="VA">Virginia</asp:ListItem>

                <asp:ListItem Value="WA">Washington</asp:ListItem>

                <asp:ListItem Value="WV">West Virginia</asp:ListItem>

                <asp:ListItem Value="WI">Wisconsin</asp:ListItem>

                <asp:ListItem Value="WY">Wyoming</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxPhysicalAddressZipcode" runat="server" CssClass="tbxnormal onlynumbers" placeholder="Zipcode" MaxLength="5"></asp:TextBox>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-md-3">
            <p>
                Mailing Address:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxMailingAddressStreet" runat="server" CssClass="tbxnormal" placeholder="Street"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxMailingAddressCity" runat="server" CssClass="tbxnormal" placeholder="City"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="ddlMailingAddressState" runat="server" CssClass="ddl">
                <asp:ListItem Value="AK">Alaska</asp:ListItem>

                <asp:ListItem Value="AZ">Arizona</asp:ListItem>

                <asp:ListItem Value="AR">Arkansas</asp:ListItem>

                <asp:ListItem Value="CA">California</asp:ListItem>

                <asp:ListItem Value="CO">Colorado</asp:ListItem>

                <asp:ListItem Value="CT">Connecticut</asp:ListItem>

                <asp:ListItem Value="DE">Delaware</asp:ListItem>

                <asp:ListItem Value="FL">Florida</asp:ListItem>

                <asp:ListItem Value="GA">Georgia</asp:ListItem>

                <asp:ListItem Value="HI">Hawaii</asp:ListItem>

                <asp:ListItem Value="ID">Idaho</asp:ListItem>

                <asp:ListItem Value="IL">Illinois</asp:ListItem>

                <asp:ListItem Value="IN">Indiana</asp:ListItem>

                <asp:ListItem Value="IA">Iowa</asp:ListItem>

                <asp:ListItem Value="KS">Kansas</asp:ListItem>

                <asp:ListItem Value="KY">Kentucky</asp:ListItem>

                <asp:ListItem Value="LA">Louisiana</asp:ListItem>

                <asp:ListItem Value="ME">Maine</asp:ListItem>

                <asp:ListItem Value="MD">Maryland</asp:ListItem>

                <asp:ListItem Value="MA">Massachusetts</asp:ListItem>

                <asp:ListItem Value="MI">Michigan</asp:ListItem>

                <asp:ListItem Value="MN">Minnesota</asp:ListItem>

                <asp:ListItem Value="MS">Mississippi</asp:ListItem>

                <asp:ListItem Value="MO">Missouri</asp:ListItem>

                <asp:ListItem Value="MT">Montana</asp:ListItem>

                <asp:ListItem Value="NE">Nebraska</asp:ListItem>

                <asp:ListItem Value="NV">Nevada</asp:ListItem>

                <asp:ListItem Value="NH">New Hampshire</asp:ListItem>

                <asp:ListItem Value="NJ">New Jersey</asp:ListItem>

                <asp:ListItem Value="NM">New Mexico</asp:ListItem>

                <asp:ListItem Value="NY">New York</asp:ListItem>

                <asp:ListItem Value="NC">North Carolina</asp:ListItem>

                <asp:ListItem Value="ND">North Dakota</asp:ListItem>

                <asp:ListItem Value="OH">Ohio</asp:ListItem>

                <asp:ListItem Value="OK">Oklahoma</asp:ListItem>

                <asp:ListItem Value="OR">Oregon</asp:ListItem>

                <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>

                <asp:ListItem Value="RI">Rhode Island</asp:ListItem>

                <asp:ListItem Value="SC">South Carolina</asp:ListItem>

                <asp:ListItem Value="SD">South Dakota</asp:ListItem>

                <asp:ListItem Value="TN">Tennessee</asp:ListItem>

                <asp:ListItem Value="TX">Texas</asp:ListItem>

                <asp:ListItem Value="UT">Utah</asp:ListItem>

                <asp:ListItem Value="VT">Vermont</asp:ListItem>

                <asp:ListItem Value="VA">Virginia</asp:ListItem>

                <asp:ListItem Value="WA">Washington</asp:ListItem>

                <asp:ListItem Value="WV">West Virginia</asp:ListItem>

                <asp:ListItem Value="WI">Wisconsin</asp:ListItem>

                <asp:ListItem Value="WY">Wyoming</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxMailingAddressZipcode" runat="server" CssClass="tbxnormal onlynumbers" placeholder="Zipcode" MaxLength="5"></asp:TextBox>
        </div>
    </div>
    <div class="titlebar">
        <h4>Parent/Sponsor/Guardian</h4>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Father/Guardian Name:
            </p>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxGuard1FirstName" runat="server" CssClass="tbxnormal" placeholder="First"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxGuard1MiddleName" runat="server" CssClass="tbxnormal" placeholder="Middle"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxGuard1LastName" runat="server" CssClass="tbxnormal" placeholder="Last"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Cellphone #:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard1CellNum" runat="server" CausesValidation="True" MaxLength="10" CssClass="phonenum onlynumbers" placeholder="(###) ###-####"></asp:TextBox>
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard1CellNum" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[0-9]{10,10}$" ControlToValidate="tbxGuard1CellNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Employer:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard1Employer" runat="server" CssClass="tbxnormal"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Work #:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard1WorkNum" runat="server" CausesValidation="True" MaxLength="10" CssClass="phonenum onlynumbers" placeholder="(###) ###-####"></asp:TextBox>        
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard1WorkNum" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[0-9]{10,10}$" ControlToValidate="tbxGuard1WorkNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Email:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard1Email" runat="server" CausesValidation="True" CssClass="tbxnormal" placeholder="my@email.com"></asp:TextBox>  
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard1Email" runat="server" ErrorMessage="Please enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tbxGuard1Email" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-md-3">
            <p>
                Mother/Guardian Name:
            </p>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxGuard2FirstName" runat="server" CssClass="tbxnormal" placeholder="First"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxGuard2MiddleName" runat="server" CssClass="tbxnormal" placeholder="Middle"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxGuard2LastName" runat="server" CssClass="tbxnormal" placeholder="Last"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Cellphone #:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard2CellNum" runat="server" CausesValidation="True" MaxLength="10" CssClass="phonenum onlynumbers" placeholder="(###) ###-####"></asp:TextBox>           
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard2CellNum" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[0-9]{10,10}$" ControlToValidate="tbxGuard2CellNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Employer:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard2Employer" runat="server" CssClass="tbxnormal"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Work #:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard2WorkNum" runat="server" CausesValidation="True" MaxLength="10" CssClass="phonenum onlynumbers" placeholder="(###) ###-####"></asp:TextBox>           
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard2WorkNum" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[0-9]{10,10}$" ControlToValidate="tbxGuard2WorkNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Email:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard2Email" runat="server" CausesValidation="True" CssClass="tbxnormal" placeholder="my@email.com"></asp:TextBox>      
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard2Email" runat="server" ErrorMessage="Please enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tbxGuard2Email" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="titlebar">
        <h4>Emergency Contact Information</h4>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Emergency Contact #1:
            </p>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxEmergencyContact1FirstName" runat="server" CssClass="tbxnormal" placeholder="First"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxEmergencyContact1MiddleName" runat="server" CssClass="tbxnormal" placeholder="Middle"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxEmergencyContact1LastName" runat="server" CssClass="tbxnormal" placeholder="Last"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Phone #:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxEmergencyContact1PhoneNum" runat="server" CausesValidation="True" MaxLength="10" CssClass="phonenum onlynumbers" placeholder="(###) ###-####"></asp:TextBox>          
            <asp:RegularExpressionValidator ID="valExpressionMaskEmergCont1Phone" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[0-9]{10,10}$" ControlToValidate="tbxEmergencyContact1PhoneNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Relationship:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxEmergencyContact1Relationship" runat="server" CssClass="tbxnormal"></asp:TextBox>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-md-3">
            <p>
                Emergency Contact #2:
            </p>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxEmergencyContact2FirstName" runat="server" CssClass="tbxnormal" placeholder="First"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxEmergencyContact2MiddleName" runat="server" CssClass="tbxnormal" placeholder="Middle"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxEmergencyContact2LastName" runat="server" CssClass="tbxnormal" placeholder="Last"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Phone #:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxEmergencyContact2PhoneNum" runat="server" CausesValidation="True" MaxLength="10" CssClass="phonenum onlynumbers" placeholder="(###) ###-####"></asp:TextBox>          
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[0-9]{10,10}$" ControlToValidate="tbxEmergencyContact2PhoneNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Relationship:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxEmergencyContact2Relationship" runat="server" CssClass="tbxnormal"></asp:TextBox>
        </div>
    </div>
    <div class="titlebar">
        <h4>Additional Information</h4>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Diagnosed Health Condition:
            </p>
        </div>
        <div class="col-md-9">
            <asp:RadioButtonList ID="rblDiagHealth" runat="server" RepeatDirection="Horizontal" CssClass="rbl">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                If Yes, Briefly Describe:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxDiagHealth" runat="server" CssClass="tbxnormal"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Currently have an IEP?
            </p>
        </div>
        <div class="col-md-9">
            <asp:RadioButtonList ID="rblIEP" runat="server" RepeatDirection="Horizontal" CssClass="rbl">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Currently have an 504?
            </p>
        </div>
        <div class="col-md-9">
            <asp:RadioButtonList ID="rbl504" runat="server" RepeatDirection="Horizontal" CssClass="rbl">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Allergies?:
            </p>
        </div>
        <div class="col-md-9">
            <asp:RadioButtonList ID="rblAllergies" runat="server" RepeatDirection="Horizontal" CssClass="rbl">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div class="titlebar">
        <h4>Supporting Documentation</h4>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Upload supporting documents:
            </p>

        </div>
        <div class="col-md-9">
            <asp:FileUpload ID="fuSupportingDocs" runat="server" AllowMultiple="True" /> 
        </div>
    </div>
    <div class="row">
         <div class="col-md-3">
        </div>
        <div class="col-md-9">
            <asp:Button ID="cmdUploadDocs" runat="server" Text="Upload" CssClass="button" OnClick="cmdUploadDocs_Click" />
            <asp:Button ID="cmdRemove" runat="server" Text="Remove" CssClass="button" OnClick="cmdRemove_Click"/>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        </div>
        <div class="col-md-9">
            <asp:ListBox ID="lbLoadedDocs" runat="server" CssClass="listbox"></asp:ListBox>
        </div>
    </div>    
    <hr />
    <div class="row">
        <div class="col-md-12">
            <p>
                The information submitted on this form and all included attachments is accurate, complete and true to the best of my knowledge.
I understand that falsification of any information submitted shall be cause for denial of enrollment.
Furthermore, I understand I am responsible for reporting to the school principal if the student has a change of address or
becomes a non-resident and that I am liable for any fees that may be incured therein. 
            </p>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:Button ID="cmdSubmitReg" runat="server" Text="Submit Registration" CssClass="button" />
        </div>
    </div>
    <div class="titlebar">
    </div>
</asp:Content>
