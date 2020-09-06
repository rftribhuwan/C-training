<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Day12BusTicketBooking.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Bus Ticket Booking<br />
            <br />
            Select Source:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Pune</asp:ListItem>
                <asp:ListItem>Mumbai</asp:ListItem>
                <asp:ListItem>Delhi</asp:ListItem>
                <asp:ListItem>Bengaluru</asp:ListItem>
                <asp:ListItem>Jaipur</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Select Destination:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Mumbai</asp:ListItem>
                <asp:ListItem>Delhi</asp:ListItem>
                <asp:ListItem>Bengaluru</asp:ListItem>
                <asp:ListItem>Jaipur</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Select Date:&nbsp;&nbsp;&nbsp;
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            Time:&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>9AM</asp:ListItem>
                <asp:ListItem>12Noon</asp:ListItem>
                <asp:ListItem>3PM</asp:ListItem>
                <asp:ListItem>6PM</asp:ListItem>
                <asp:ListItem>9PM</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:Button ID="ProceedButton" runat="server" OnClick="ProceedButton_Click" Text="Proceed" />
            <br />
        </div>
    </form>
</body>
</html>
