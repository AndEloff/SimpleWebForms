<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebControls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="SSD" Text ="Soild State Drive?" runat="server"/>
        <asp:CheckBox ID="SixteenGB" Text="16GB?" runat="server" />
        <asp:CheckBox ID="DualMonitor" Text="Dual Monitor?" runat="server" />
        <hr />
        <asp:RadioButton ID="Male" Text="Male" GroupName ="Sex" runat="server" Checked ="true" />
        <asp:RadioButton ID="Female" Text="Female" GroupName="Sex" runat="server" />
        <hr />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Text ="Power Windows" Value ="Feature1" />
            <asp:ListItem Text ="Power Seats" Value ="Feature2" />
            <asp:ListItem Text ="Fog Lights" Value ="Feature3" />
            <asp:ListItem Text ="Winter Package" Value ="Feature4" />
        </asp:CheckBoxList>
        <hr />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Text ="Under 30" Value ="Young" Selected ="True" />
            <asp:ListItem Text ="30 - 60" Value ="Young"/>
            <asp:ListItem Text ="Over 60" Value ="Young"/>
        </asp:RadioButtonList>
        <hr />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="Batman" Value ="Batman" />
            <asp:ListItem Text="Superman" Value ="Superman" />
            <asp:ListItem Text="Spiderman" Value ="Spiderman" />
            <asp:ListItem Text="Static Shock" Value ="Static Shock" />
            <asp:ListItem Text="Dare Devil" Value ="Dare Devil" />
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <asp:Label ID="Msg2" runat="server" Text=""></asp:Label>
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
