<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>Account</p>
        <asp:Label Text="Tai Khoan" runat="server" />
        <p> <input id="Text1" type="text" /></p>
        <p>Passwork</p>
        <p><input id="Password1" type="password" /></p>
    </form>
    <p><input id="Button1" type="button" value="Login" /></p>
</body>
</html>
