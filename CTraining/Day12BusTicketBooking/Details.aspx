<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Day12BusTicketBooking.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone Number:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="PhoneNumber" runat="server"></asp:TextBox>
            <br />
            <br />
            Email Id:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
                <asp:Button ID="Button2" runat="server" Text="24" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="23" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" Text="22" OnClick="Button4_Click" />
                <br class="auto-style1" />
                <asp:Button ID="Button5" runat="server" Text="21" OnClick="Button5_Click" />
                <asp:Button ID="Button6" runat="server" Text="20" OnClick="Button6_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button7" runat="server" Text="19" OnClick="Button7_Click" />
                <br class="auto-style1" />
                <asp:Button ID="Button8" runat="server" Text="18" OnClick="Button8_Click" />
                <asp:Button ID="Button9" runat="server" Text="17" OnClick="Button9_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button10" runat="server" Text="16" OnClick="Button10_Click" />
                <br class="auto-style1" />
                <asp:Button ID="Button11" runat="server" Text="15" OnClick="Button11_Click" />
                <asp:Button ID="Button12" runat="server" Text="14" OnClick="Button12_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button13" runat="server" Text="13" OnClick="Button13_Click" />
                <br class="auto-style1" />
                <asp:Button ID="Button14" runat="server" Text="12" OnClick="Button14_Click" />
                <asp:Button ID="Button15" runat="server" Text="11" OnClick="Button15_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button16" runat="server" Text="10" OnClick="Button16_Click" />
                <br class="auto-style1" />
                <asp:Button ID="Button17" runat="server" Text="09" OnClick="Button17_Click" />
                <asp:Button ID="Button18" runat="server" Text="08" OnClick="Button18_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button19" runat="server" Text="07" OnClick="Button19_Click" />
                <br class="auto-style1" />
                <asp:Button ID="Button20" runat="server" Text="06" OnClick="Button20_Click" />
                <asp:Button ID="Button21" runat="server" Text="05" OnClick="Button21_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button22" runat="server" Text="04" OnClick="Button22_Click" />
                <br class="auto-style1" />
                <asp:Button ID="Button23" runat="server" Text="03" OnClick="Button23_Click" />
                <asp:Button ID="Button24" runat="server" Text="02" OnClick="Button24_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button25" runat="server" Text="01" OnClick="Button25_Click" />
                <br />
            <br />
            Quantity:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Quantity" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TotalPrice" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button26" runat="server" OnClick="Button26_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
