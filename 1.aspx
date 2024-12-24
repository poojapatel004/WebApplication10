<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1.aspx.cs" Inherits="WebApplication10._1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Sum of 3 numbers</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="no1" runat="server" Text="Enter no 1:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 71px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="no2" runat="server" Text="Enter no 2:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 73px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="no3" runat="server" Text="Enter no 3:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 74px" Width="157px"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Button ID="Button1" runat="server" Height="49px" OnClick="Button1_Click1" Text="Sum" Width="109px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
&nbsp;</p>
        <p style="margin-left: 120px">
            <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
        </p>
    </form>
</body>
</html>
