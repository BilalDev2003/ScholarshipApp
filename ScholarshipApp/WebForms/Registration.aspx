<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Home</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width" />
    <link href="../Content/css/styles.css" rel="stylesheet" />
	
    <%--Toaster Message References--%>
    <link href="../Content/toaster/toastr.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
	<script src="../Content/toaster/toastr.js"></script>

</head>
<body>

    <div class="container">
        <div class="center">
            <h1>Register</h1>
            <form id="form1" runat="server">
                <div class="txt_field">
                    <asp:TextBox ID="txtUsername" runat="server" required="required"></asp:TextBox>
                    <span></span>
                    <label>Enter Username</label>
                </div>


                <div class="txt_field">
                    <asp:TextBox ID="txtEmail" runat="server" required="required"></asp:TextBox>
                    <span></span>
                    <label>Enter Email</label>
                </div>


                <div class="txt_field">
                    <asp:TextBox ID="txtPassword" runat="server" required="required"></asp:TextBox>
                    <span></span>
                    <label>Enter Password</label>
                </div>


                <div class="txt_field">
                    <asp:TextBox ID="txtMobile" runat="server" required="required"></asp:TextBox>
                    <span></span>
                    <label>Enter Mobile</label>
                </div>

                <asp:Button ID="btnSignup" runat="server" Text="Signup" OnClick="btnSignup_Click" />
                <div class="signup_link">
                    Back to Login ? <a href="Login.aspx">Log in</a>
                </div>
            </form>
        </div>
    </div>
</body>
</html>

