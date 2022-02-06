<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Atualizar Tarefas</title>
        <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    </head>
    <script src="Scripts/jquery.1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <body>
        <form id="form1" runat="server">
            <div class="container">
                <div class="span10 offset1">
                    <div class="row"> 
                        <h3 class="well">Informações da tarefa</h3>
                            Descrição da tarefa:
                            <asp:TextBox ID="Descricao" runat="server" CssClass="form-control" Width="45%" />
                            <br /><br />
                            
                             Nome do usuário: <br />
                            <asp:DropDownList ID="cbxUsuarios" runat="server" />                          
                           
                            <br /><br />

                             Status da tarefa: <br />
                            <asp:DropDownList ID="StatusTarefa" runat="server">
                                <asp:ListItem  Value="AN" Text="Em andamento" />
                                <asp:ListItem  Value="CO" Text="Concluida" />
                                <asp:ListItem  Value="CC" Text="Cancelada" />
                             </asp:DropDownList>
                             <br /><br />
                            <p>
                            <asp:Label ID="lblMensagem" runat="server" />
                            </p>

                           
                            <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-warning btn-lg" OnClick="btnAtualizarTarefa" />
                             <a href="Index.aspx" class="btn btn-default btn-lg">Voltar</a>
                         
                     </div>
                </div>
            </div>
        </form>
    </body>
</html>
