<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="B2CSite.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录</title>
    <script src="https://code.jquery.com/jquery-2.2.4.js"></script>
    <link href="APP_CSS/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="login-form">
         <h1>Login</h1>

            <div class="txtb">
                <%--<input type="text"/>--%><asp:TextBox ID="txtUName" runat="server"></asp:TextBox>
                <span data-placeholder="Username"></span>
            </div>

            <div class="txtb">
               <%-- <input type="password"/>--%><asp:TextBox ID="txtUPwd" runat="server" TextMode="Password"></asp:TextBox>
                <span data-placeholder="Password"></span>
            </div>

            <%--<input type="submit" class="logbtn" value="Login"/>--%><asp:Button ID="submit" runat="server" Text="submit"  CssClass="logbtn" OnClick="submit_Click"/>
          <asp:CheckBox ID="chkState" runat="server" Text="两周内不用登录" />


            &nbsp;<div class="bottom-text">
                Don't have account?<a href="#">Sign up</a>
            </div>
        <script type="text/javascript">
        $(".txtb input").on("focus",function(){
            $(this).addClass("focus");
        });

        $(".txtb input").on("blur",function(){
            if($(this).val=="")
            $(this).removeClass("focus");
        });
        </script>
    </form>
</body>
</html>
