<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Cadastro de Tarefas</title>
        <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    </head>
    <script src="Scripts/jquery.1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <body>
        <form id="form1" runat="server">
            <div class="container">
                <div class="span10 offset1">
                    <div class="col-md-12"> 
                        <h3 class="well">Cadastro de Tarefas</h3>
                        <br />
                         Nome do usuário: <br />
                        <asp:DropDownList ID="cbxUsuarios" runat="server">                            
                        </asp:DropDownList>

                        <br /><br />
                         Descrição da tarefa: <br />
                        <asp:TextBox ID="Descricao" runat="server" placeholder="" Width="50%"  CssClass="form-control"/>
                        <asp:RequiredFieldValidator ID="requiredDescricao" runat="server" ControlToValidate="Descricao" ErrorMessage="Preencha a descrição!" ForeColor="Red" />

                         <br />
                         Status da tarefa: <br />
                        <asp:DropDownList ID="StatusTarefa" runat="server">
                            <asp:ListItem  Value="AN" Text="Em andamento" />
                            <asp:ListItem  Value="CO" Text="Concluida" />
                            <asp:ListItem  Value="CC" Text="Cancelada" />
                        </asp:DropDownList>
                        
                        <br />
                        <p>
                            <asp:Label ID="LabelValues" runat="server" />
                        </p>
                        <br /><br />
                        <p>
                            <asp:Label ID="lblMensagem" runat="server" />
                        </p>

                        <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" OnClick="btnCadastrar" />
                        <a href="Index.aspx" class="btn btn-default btn-lg">Voltar</a>
                    </div>
                    
                </div>
            </div>
        </form>
    </body>
</html>
