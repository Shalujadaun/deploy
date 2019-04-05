<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="ThreeTie.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        UserID :<asp:TextBox ID="txtuserid"  runat="server"></asp:TextBox>
       
        <asp:RequiredFieldValidator ID="RefVal1" runat="server" controltovalidate="txtuserid" ErrorMessage="Enter the Userid" ForeColor="Red"></asp:RequiredFieldValidator>
        <br /> 
        <asp:RegularExpressionValidator ID="ReExp1" runat="server" ControlToValidate="txtuserid" ErrorMessage="Enter the correct format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ></asp:RegularExpressionValidator>  
  
        <br />
        <br />
        Password: <asp:TextBox ID="txtpassword"  TextMode="Password" runat="server" ></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="RefVal2" runat="server" controltovalidate="txtpassword"  ErrorMessage="Enter the password" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="ReExp2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Password length must be between 7 to 10 characters" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9\s]{7,10}$" ></asp:RegularExpressionValidator>  

         
        <br />
        <br />
        Confirm Password: <asp:TextBox ID="txtConfirmpassword"  TextMode="Password" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RefVal3" runat="server" controltovalidate="txtConfirmpassword" ErrorMessage="Enter password again" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:CompareValidator ID="CmpVal" runat="server" Display="Static" ControlToCompare="txtpassword" ControlToValidate="txtConfirmpassword" ErrorMessage="Password and confirm password must be same"  ForeColor="Red"></asp:CompareValidator>
     
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  Text="Signup" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <p>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

        </p>
    </form>
</body>
</html>
