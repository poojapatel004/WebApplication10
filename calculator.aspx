<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="WebApplication10.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:TextBox ID="tx" runat="server" Height="69px" Width="452px"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="seven" runat="server" Height="80px" Text="7" Width="80px" OnClick="seven_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="eight" runat="server" Height="80px" Text="8" Width="80px" OnClick="eight_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="nine" runat="server" Height="80px" Text="9" Width="80px" OnClick="nine_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="plus" runat="server" Height="80px" Text="+" Width="80px" OnClick="plus_Click" />
        <p>
            <asp:Button ID="four" runat="server" Text="4" Width="80px" Height="80px" OnClick="four_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="five" runat="server" Text="5" Height="80px" OnClick="five_Click" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="six" runat="server" Text="6" Height="80px" OnClick="six_Click" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="minus" runat="server" Text="-" Height="80px" OnClick="minus_Click" Width="80px" />
        </p>
        <p>
            <asp:Button ID="one" runat="server" Text="1" Height="80px" OnClick="one_Click" Width="80px" />
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:Button ID="two" runat="server" Text="2" Height="80px" OnClick="two_Click" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="three" runat="server" Text="3" Height="80px" OnClick="three_Click" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="multipy" runat="server" OnClick="Button12_Click" Text="*" Height="80px" Width="80px" />
        </p>
        <p>
            <asp:Button ID="clear" runat="server" Text="Clear" Height="80px" OnClick="clear_Click" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="zero" runat="server" Text="0" Height="80px" OnClick="zero_Click" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="division" runat="server" Text="/" Height="80px" OnClick="division_Click" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="answer" runat="server" Text="=" Height="80px" OnClick="answer_Click" Width="80px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
