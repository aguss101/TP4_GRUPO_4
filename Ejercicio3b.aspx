<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3b.aspx.cs" Inherits="TP4_GRUPO_4.Ejercicio3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 138px;
        }
        .auto-style2 {
            width: 114px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 114px;
            height: 23px;
        }
    </style>
</head>
<body style="width: 468px; height: 153px">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Listado de libros"></asp:Label>
                    </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblTemaSeleccionado" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="gvLibros" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="IdLibro" HeaderText="IdLibro" SortExpression="IdLibro" />
                                <asp:BoundField DataField="IdTema" HeaderText="IdTema" SortExpression="IdTema" />
                                <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
                                <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                                <asp:BoundField DataField="Autor" HeaderText="Autor" SortExpression="Autor" />
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LibreriaConnectionString %>" SelectCommand="SELECT * FROM Libros WHERE IdTema = @Tema">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="Tema" QueryStringField="tema" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lbVolver" runat="server" OnClick="lbVolver_Click">Consultar otro tema</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
