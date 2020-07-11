<%@ Page Title="Online School Registration System" Language="C#" Async="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EDUnited._Default" MaintainScrollPositionOnPostBack="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="jumbotron">
        <h1><%: System.Configuration.ConfigurationManager.AppSettings["SchoolName"] %></h1>
        <p class="lead">Online School Registration System</p>
    </div>

    <div class="titlebar">
        <p class="lead">Student Registration</p>
        <p>
            This form is to be completed by the parent, sponsor or legal guardian of all students entering this school system. All new or re-registering students must submit verification of the following at the time of enrollment:
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
            <asp:TextBox ID="tbxStudentFirstName" runat="server" CssClass="tbxnormal" ToolTip="Enter student's legal first name" placeholder="First"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredFirstName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxStudentFirstName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxStudentMiddleName" runat="server" CssClass="tbxnormal" ToolTip="Enter student's legal middle name" placeholder="Middle"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxStudentLastName" runat="server" CssClass="tbxnormal" ToolTip="Enter student's legal last name" placeholder="Last"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredLastName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxStudentLastName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Gender:
            </p>
        </div>
        <div class="col-md-9">
            <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal" CssClass="rbl" ControlToValidate="rblGender">
                <asp:ListItem Selected="True">Male</asp:ListItem>
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
            <asp:TextBox ID="tbxDOB" runat="server" CausesValidation="True" MaxLength="10" CssClass="date" TextMode="Date" placeholder="MM/DD/YYYY"></asp:TextBox>            
             <asp:RequiredFieldValidator ID="valRequiredDOB" runat="server" ErrorMessage="* Required" ControlToValidate="tbxDOB" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
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
            <asp:DropDownList ID="ddlRace" runat="server" CssClass="ddl" DataSourceID="raceXmlDataSource" DataTextField="name" DataValueField="value">
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
                <asp:ListItem Value="true">Yes</asp:ListItem>
                <asp:ListItem Selected="True" Value="false">No</asp:ListItem>
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
            <asp:DropDownList ID="ddlLanguageSpokenInHome" runat="server" CssClass="ddl" DataSourceID="languageXmlDataSource" DataTextField="name" DataValueField="value">
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
            <asp:DropDownList ID="ddlLanguageSpokenByChild" runat="server" CssClass="ddl" DataSourceID="languageXmlDataSource" DataTextField="name" DataValueField="value">
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
            <asp:TextBox ID="tbxPhysicalAddressStreet" runat="server" CssClass="tbxnormal" placeholder="Street"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredPhysicalAddressStreet" runat="server" ErrorMessage="* Required" ControlToValidate="tbxPhysicalAddressStreet" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxPhysicalAddressCity" runat="server" CssClass="tbxnormal" placeholder="City"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredPhysicalAddressCity" runat="server" ErrorMessage="* Required" ControlToValidate="tbxPhysicalAddressCity" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="ddlPhysicalAddressState" runat="server" CssClass="ddl" DataSourceID="stateXmlDataSource" DataTextField="name" DataValueField="value">               
            </asp:DropDownList>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxPhysicalAddressZipcode" runat="server" CssClass="tbxnormal onlynumbers" placeholder="Zipcode" MaxLength="5"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredPhysicalAddressZipcode" runat="server" ErrorMessage="* Required" ControlToValidate="tbxPhysicalAddressZipcode" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
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
            <asp:TextBox ID="tbxMailingAddressStreet" runat="server" CssClass="tbxnormal" placeholder="Street"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredMailingAddressStreet" runat="server" ErrorMessage="* Required" ControlToValidate="tbxMailingAddressStreet" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxMailingAddressCity" runat="server" CssClass="tbxnormal" placeholder="City"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredMailingAddressCity" runat="server" ErrorMessage="* Required" ControlToValidate="tbxMailingAddressCity" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-3">
            <asp:DropDownList ID="ddlMailingAddressState" runat="server" CssClass="ddl" DataSourceID="stateXmlDataSource" DataTextField="name" DataValueField="value">
                
            </asp:DropDownList>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxMailingAddressZipcode" runat="server" CssClass="tbxnormal onlynumbers" placeholder="Zipcode" MaxLength="5"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredMailingAddressZipcode" runat="server" ErrorMessage="* Required" ControlToValidate="tbxMailingAddressZipcode" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
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
            <asp:TextBox ID="tbxGuard1FirstName" runat="server" CssClass="tbxnormal" placeholder="First"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredGuard1FirstName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxGuard1FirstName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxGuard1MiddleName" runat="server" CssClass="tbxnormal" placeholder="Middle"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredGuard1MiddleName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxGuard1MiddleName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxGuard1LastName" runat="server" CssClass="tbxnormal" placeholder="Last"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredGuard1LastName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxGuard1LastName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Relationship:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard1Relationship" runat="server" CssClass="tbxnormal"> </asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredGuard1Relationship" runat="server" ErrorMessage="* Required" ControlToValidate="tbxGuard1Relationship" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Cellphone #:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard1CellNum" runat="server" CausesValidation="True" MaxLength="10" CssClass="phonenum onlynumbers" placeholder="(###) ###-####"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredGuard1CellNum" runat="server" ErrorMessage="* Required" ControlToValidate="tbxGuard1CellNum" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard1CellNum" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[\\(]{0,1}([0-9]){3}[\\)] {0,1}[ ]?([^0-1]){1}([0-9]){2}[ ]?[-]?[ ]?([0-9]){4}[ ]*((x){0,1}([0-9]){1,5}){0,1}$" ControlToValidate="tbxGuard1CellNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RegularExpressionValidator>
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
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard1WorkNum" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[\\(]{0,1}([0-9]){3}[\\)] {0,1}[ ]?([^0-1]){1}([0-9]){2}[ ]?[-]?[ ]?([0-9]){4}[ ]*((x){0,1}([0-9]){1,5}){0,1}$" ControlToValidate="tbxGuard1WorkNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Email:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard1Email" runat="server" CausesValidation="True" CssClass="tbxnormal" placeholder="my@email.com"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredGuard1Email" runat="server" ErrorMessage="* Required" ControlToValidate="tbxGuard1Email" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator> 
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard1Email" runat="server" ErrorMessage="Please enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tbxGuard1Email" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RegularExpressionValidator>
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
                Relationship:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxGuard2Relationship" runat="server" CssClass="tbxnormal"></asp:TextBox>
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
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard2CellNum" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[\\(]{0,1}([0-9]){3}[\\)] {0,1}[ ]?([^0-1]){1}([0-9]){2}[ ]?[-]?[ ]?([0-9]){4}[ ]*((x){0,1}([0-9]){1,5}){0,1}$" ControlToValidate="tbxGuard2CellNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RegularExpressionValidator>
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
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard2WorkNum" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[\\(]{0,1}([0-9]){3}[\\)] {0,1}[ ]?([^0-1]){1}([0-9]){2}[ ]?[-]?[ ]?([0-9]){4}[ ]*((x){0,1}([0-9]){1,5}){0,1}$" ControlToValidate="tbxGuard2WorkNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RegularExpressionValidator>
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
            <asp:RegularExpressionValidator ID="valExpressionMaskGuard2Email" runat="server" ErrorMessage="Please enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tbxGuard2Email" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RegularExpressionValidator>
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
            <asp:TextBox ID="tbxEmergencyContact1FirstName" runat="server" CssClass="tbxnormal" placeholder="First"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredEmergencyContact1FirstName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxEmergencyContact1FirstName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator> 
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxEmergencyContact1MiddleName" runat="server" CssClass="tbxnormal" placeholder="Middle"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredEmergencyContact1MiddleName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxEmergencyContact1MiddleName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator> 
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxEmergencyContact1LastName" runat="server" CssClass="tbxnormal" placeholder="Last"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredEmergencyContact1LastName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxEmergencyContact1LastName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator> 
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Phone #:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxEmergencyContact1PhoneNum" runat="server" CausesValidation="True" MaxLength="10" CssClass="phonenum onlynumbers" placeholder="(###) ###-####"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredEmergencyContact1PhoneNum" runat="server" ErrorMessage="* Required" ControlToValidate="tbxEmergencyContact1PhoneNum" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>           
            <asp:RegularExpressionValidator ID="valExpressionMaskEmergCont1Phone" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[\\(]{0,1}([0-9]){3}[\\)] {0,1}[ ]?([^0-1]){1}([0-9]){2}[ ]?[-]?[ ]?([0-9]){4}[ ]*((x){0,1}([0-9]){1,5}){0,1}$" ControlToValidate="tbxEmergencyContact1PhoneNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Relationship:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxEmergencyContact1Relationship" runat="server" CssClass="tbxnormal"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredEmergencyContact1Relationship" runat="server" ErrorMessage="* Required" ControlToValidate="tbxEmergencyContact1Relationship" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator> 
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
            <asp:TextBox ID="tbxEmergencyContact2FirstName" runat="server" CssClass="tbxnormal" placeholder="First"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredEmergencyContact2FirstName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxEmergencyContact2FirstName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator> 
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxEmergencyContact2MiddleName" runat="server" CssClass="tbxnormal" placeholder="Middle"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredEmergencyContact2MiddleName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxEmergencyContact2MiddleName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator> 
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="tbxEmergencyContact2LastName" runat="server" CssClass="tbxnormal" placeholder="Last"></asp:TextBox> <asp:RequiredFieldValidator ID="valRequiredEmergencyContact2LastName" runat="server" ErrorMessage="* Required" ControlToValidate="tbxEmergencyContact2LastName" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator> 
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Phone #:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxEmergencyContact2PhoneNum" runat="server" CausesValidation="True" MaxLength="10" CssClass="phonenum onlynumbers" placeholder="(###) ###-####"></asp:TextBox> <asp:RequiredFieldValidator ID="valRelationshipEmergencyContact2PhoneNum" runat="server" ErrorMessage="* Required" ControlToValidate="tbxEmergencyContact2PhoneNum" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator>           
             <asp:RegularExpressionValidator ID="valExpressionMaskEmergCont2Phone" runat="server" ErrorMessage="Phone number not in the format (###) ###-####" ValidationExpression="^[\\(]{0,1}([0-9]){3}[\\)] {0,1}[ ]?([^0-1]){1}([0-9]){2}[ ]?[-]?[ ]?([0-9]){4}[ ]*((x){0,1}([0-9]){1,5}){0,1}$" ControlToValidate="tbxEmergencyContact2PhoneNum" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Relationship:
            </p>
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="tbxEmergencyContact2Relationship" runat="server" CssClass="tbxnormal"></asp:TextBox> <asp:RequiredFieldValidator ID="valRelationshipEmergencyContact2Relationship" runat="server" ErrorMessage="* Required" ControlToValidate="tbxEmergencyContact2Relationship" ForeColor="Red" SetFocusOnError="True" Font-Size="Larger"></asp:RequiredFieldValidator> 
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
                <asp:ListItem Value="true">Yes</asp:ListItem>
                <asp:ListItem Selected="True" Value="false">No</asp:ListItem>
            </asp:RadioButtonList>            
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                If yes, briefly describe:
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
                <asp:ListItem Value="true">Yes</asp:ListItem>
                <asp:ListItem Selected="True" Value="false">No</asp:ListItem>
            </asp:RadioButtonList>            
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <p>
                Currently have a 504?
            </p>
        </div>
        <div class="col-md-9">
            <asp:RadioButtonList ID="rbl504" runat="server" RepeatDirection="Horizontal" CssClass="rbl">
                <asp:ListItem Value="true">Yes</asp:ListItem>
                <asp:ListItem Selected="True" Value="false">No</asp:ListItem>
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
                <asp:ListItem Value="true">Yes</asp:ListItem>
                <asp:ListItem Selected="True" Value="false">No</asp:ListItem>
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
            <asp:Button ID="cmdUploadDocs" runat="server" Text="Upload" CssClass="button" OnClick="cmdUploadDocs_Click" CausesValidation="false" />
            <asp:Button ID="cmdRemove" runat="server" Text="Remove" CssClass="button" OnClick="cmdRemove_Click" CausesValidation="false"/>
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
            <asp:Button ID="cmdSubmitReg" runat="server" Text="Submit Registration" CssClass="button" OnClick="cmdSubmitReg_Click" />
            <asp:XmlDataSource ID="stateXmlDataSource" runat="server" DataFile="~/App_Data/States.xml"></asp:XmlDataSource>
            <asp:XmlDataSource ID="languageXmlDataSource" runat="server" DataFile="~/App_Data/Languages.xml"></asp:XmlDataSource>
            <asp:XmlDataSource ID="raceXmlDataSource" runat="server" DataFile="~/App_Data/Race.xml"></asp:XmlDataSource>
        </div>
    </div>
    <div class="titlebar">
    </div>
</asp:Content>
