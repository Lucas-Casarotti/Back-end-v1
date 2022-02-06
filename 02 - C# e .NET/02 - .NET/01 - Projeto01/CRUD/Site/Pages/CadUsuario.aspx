<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadUsuario.aspx.cs" Inherits="Site.Pages.CadUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Cadastro de Usuários</title>
        <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    </head>
    <script src="Scripts/jquery.1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <body>
        <form id="form1" runat="server">
            <div class="container">
                <div class="span10 offset1">
                    <div class="col-md-12"> 
                        <h3 class="well">Cadastro de Usuários</h3>
                        <br />

                        Nome do Usuário: <br />
                        <asp:TextBox ID="txtNome" runat="server" placeholder="" Width="50%"  CssClass="form-control"/>
                        <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Preencha o campo Nome!" ForeColor="Red" />

                         <br /><br />
                         E-mail do Usuário: <br />
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="" Width="50%"  CssClass="form-control"/>
                        <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Preencha o campo E-mail!" ForeColor="Red" />

                        <br /><br />
                         Senha do Usuário: <br />
                        <asp:TextBox ID="txtSenha" runat="server" placeholder="" Width="50%"  CssClass="form-control" TextMode="Password"/>
                        <asp:RequiredFieldValidator ID="RequiredSenha" runat="server" ControlToValidate="txtSenha" ErrorMessage="Preencha o campo Senha!" ForeColor="Red" />

                        <br /><br />
                        <p>
                            <asp:Label ID="lblMensagem" runat="server" />
                        </p>

                        <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" Onclick="btnCadUsuario" />
                        <a href="Login.aspx" class="btn btn-default btn-lg">Voltar</a>
                    </div>
                    
                </div>
            </div>
        </form>
    </body>
</html>

