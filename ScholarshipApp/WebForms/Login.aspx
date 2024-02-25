<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="WebForms_Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Home</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width" />
    <link href="../Content/css/styles.css" rel="stylesheet" />
</head>
<body>

    <div class="container">
        <div class="center">
            <h1>Login</h1>
            <form id="form1" runat="server">
                <div class="txt_field">
                    <asp:TextBox ID="txtUsername" runat="server" required="required"></asp:TextBox>
                    <span></span>
                    <label>Username</label>
                </div>
                <div class="txt_field">
                    <asp:TextBox ID="txtPassword" runat="server" required="required"></asp:TextBox>
                    <span></span>
                    <label>Password</label>
                </div>
                <div class="pass">Forget Password?</div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" />
                <div class="signup_link">
                    Not a Member ? <a href="Registration.aspx">Signup</a>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
