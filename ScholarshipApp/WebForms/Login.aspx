<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <title>Home</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width" />
    <link href="../Content/css/styles.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</head>
<body>

    <div class="container">
        <div class="center">
            <h1>Login</h1>
            <form id="form1" runat="server">
                <div class="txt_field">
                    <asp:TextBox ID="txtUserEmail" runat="server" required="required"></asp:TextBox>
                    <span></span>
                    <label>User Email</label>
                </div>
                <div class="txt_field">
                    <asp:TextBox ID="txtPassword" runat="server" required="required" TextMode="Password"></asp:TextBox>
                    <span></span>
                    <label>Password</label>
                </div>
                <div class="pass">Forget Password?</div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                <div class="signup_link">
                    Not a Member ? <a href="Registration.aspx">Signup</a>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
