<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Site.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login de Usuário</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="CSS/style.css" />
</head>
<script src="Scripts/jquery.1.9.0.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card card-container">
          
                <img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" />
                <p id="profile-name" class="profile-name-card"></p>
                <div class="form-signin">
                    <span id="reauth-email" class="reauth-email"></span>

                    <asp:TextBox ID="txtEmail" runat="server" placeholder="E-mail" Cssclass="form-control"/>
                    <br />

                    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" placeholder="Senha" Cssclass="form-control"/>
                    <br />

                    <asp:Button ID="btnLogin" Text="Entrar" runat="server" OnClick="btnLoginUsuario" Cssclass="btn btn-lg btn-primary btn-block btn-signin"/>
                    <br />
                    <a href="CadUsuario.aspx" class="btn btn-lg btn-primary btn-block btn-signin">Novo usuário</a>
                    <br />
                    <asp:Label runat="server" ID="lblStatus" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
