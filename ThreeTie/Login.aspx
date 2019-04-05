<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ThreeTie.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        UserID:<asp:TextBox ID="txtuserid" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ReqfVal1" runat="server" ControlToValidate="txtuserid" ForeColor="Red" ErrorMessage="Enter the UserID"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="ReExp1" runat="server" ControlToValidate="txtuserid" ErrorMessage="UserId should be in correct Format" ForeColor="Green" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        Password:<asp:TextBox ID="txtpassword" TextMode="Password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ReqfVal2" runat="server" ControlToValidate="txtpassword" ForeColor="Red" ErrorMessage="Enter the password"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="ReExp2" runat="server" ControlToValidate ="txtpassword" ErrorMessage="Password Should Contain 7-9 character" ForeColor="Green" ValidationExpression="^[a-zA-Z0-9\s]{7,10}$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
