<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="Day12BusTicketBooking.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="form1" runat="server">  
        <table style="width: 50%; text-align: center; background-color: skyblue;">  
            <tr>  
                <td>
                    <asp:PlaceHolder ID="DBDataPlaceHolder" runat="server"></asp:PlaceHolder>  
                </td>  
            </tr>  
        </table>  
    </form>  
</body>
</html>
