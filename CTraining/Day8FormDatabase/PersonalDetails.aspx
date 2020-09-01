<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalDetails.aspx.cs" Inherits="Day8FormDatabase.PersonalDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Id" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
            <br />
            <br />
            First Name&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="Gender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Department :&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="Department" runat="server">
                <asp:ListItem Value="R&amp;D"></asp:ListItem>
                <asp:ListItem Value="Client Services"></asp:ListItem>
                <asp:ListItem>Human Resouces</asp:ListItem>
                <asp:ListItem>Finance</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Projects&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:CheckBoxList ID="Projects" runat="server">
                <asp:ListItem>Website</asp:ListItem>
                <asp:ListItem>Desktop</asp:ListItem>
                <asp:ListItem>Cloud</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Address" runat="server"></asp:TextBox>
            <br />
            <br />
            City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="City" runat="server">
                <asp:ListItem>Pune</asp:ListItem>
                <asp:ListItem>Mumbai</asp:ListItem>
                <asp:ListItem>Delhi</asp:ListItem>
                <asp:ListItem>Bengaluru</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Rate us&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="Rating" runat="server">
                <asp:ListItem>Excellent</asp:ListItem>
                <asp:ListItem>Very Good</asp:ListItem>
                <asp:ListItem>Good</asp:ListItem>
                <asp:ListItem>Bad</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <br />
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
