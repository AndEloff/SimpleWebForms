<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SecondWebProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Your Birthdate:"></asp:Label><br />
        <asp:TextBox ID="Birthdate" runat="server"></asp:TextBox>
    </div>
        <p>
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        </p>
        <p>
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
