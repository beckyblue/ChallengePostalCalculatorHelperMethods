﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width:
            <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="checkChanged"></asp:TextBox>
            <br />
            Height:
            <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="checkChanged"></asp:TextBox>
            <br />
            Length:
            <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="checkChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundRadioButton" runat="server" GroupName="methodGroup" OnCheckedChanged="checkChanged" Text="Ground" />
            <br />
            <asp:RadioButton ID="airRadioButton" runat="server" GroupName="methodGroup" OnCheckedChanged="checkChanged" Text="Air" />
            <br />
            <asp:RadioButton ID="nextDayRadioButton" runat="server" GroupName="methodGroup" OnCheckedChanged="checkChanged" Text="Next Day" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
