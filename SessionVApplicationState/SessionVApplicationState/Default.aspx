<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionVApplicationState.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="NameLabel" runat="server" Text="Enter Your Name: "></asp:Label>
        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="EmailLabel" runat="server" Text="Enter Your Email: "></asp:Label>
        <asp:TextBox ID="UserEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="SaveBtn" runat="server" Text="Save" OnClick="SaveBtn_Click" />
        <asp:Button ID="RetrieveBtn" runat="server" Text="Retrieve" OnClick="RetrieveBtn_Click" />
    
        <br />
        <asp:Label ID="NameAndEmail" runat="server" Text=""></asp:Label>
    
        <br />
        <asp:Label ID="RetrieveNameAndEmail" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
