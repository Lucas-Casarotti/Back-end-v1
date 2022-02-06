<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Lista de Tarefas</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="Scripts/jquery.1.9.0.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Lista de Tarefas</h3>
                    <a href="Cadastro.aspx" class="btn btn-primary btn-lg">Nova Tarefa</a>
                    <br /><br />
                    <asp:GridView ID="gridServicos" runat="server" CssClass="table table-hover table-striped" GridLines="none" AutoGenerateColumns="false" BackColor="#ccffcc">
                       
                        <Columns>
                            <asp:BoundField DataField="ID_Item" HeaderText="Código Tarefa" />
                            <asp:BoundField DataField="ID_Usuario" HeaderText="Código Usuário" />
                            <asp:BoundField DataField="Descricao" HeaderText="Descrição Tarefa" />
                            <asp:BoundField DataField="Status" HeaderText="Status da tarefa" />
                            
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnEditar" Text="Editar" runat="server" CommandArgument='<%#Eval("ID_Item") %>' OnClick="btnEditarServico" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnExcluir" Text="Excluir" runat="server" CommandArgument='<%#Eval("ID_Item") %>' OnClick="btnExcluirServico" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
