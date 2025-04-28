<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP4_GRUPO_4.Ejercicio_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 96px;
        }
        .auto-style3 {
            width: 96px;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
        .auto-style5 {
            width: 275px;
        }
        .auto-style6 {
            height: 30px;
            width: 275px;
        }
        .auto-style7 {
            width: 381px;
        }
        .auto-style8 {
            height: 30px;
            width: 381px;
        }
        .auto-style9 {
            width: 393px;
        }
        .auto-style10 {
            height: 30px;
            width: 393px;
        }
        .auto-style11 {
            width: 96px;
            height: 34px;
        }
        .auto-style12 {
            width: 275px;
            height: 34px;
        }
        .auto-style13 {
            width: 393px;
            height: 34px;
        }
        .auto-style14 {
            width: 381px;
            height: 34px;
        }
        .auto-style15 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbl_IDp" runat="server" Text="Id Producto:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="ddlIDProduct" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Value ="0">Igual a:</asp:ListItem>
                        <asp:ListItem Value ="1">Mayor a:</asp:ListItem>
                        <asp:ListItem Value="-1">Menor a:</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txt_IDp" runat="server" AutoPostBack="true"  Height="25px"></asp:TextBox>
                </td>
                <td class="auto-style10"></td>
                <td class="auto-style8"></td>
                <td class="auto-style4">
                    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbl_IDc" runat="server" Text="Id Categoria:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlIDCategory" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Value="0">Igual a:</asp:ListItem>
                        <asp:ListItem Value="1">Mayor a:</asp:ListItem>
                        <asp:ListItem Value="-1">Menor a:</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txt_IDc" runat="server" AutoPostBack="true" Height="25px" ></asp:TextBox>
                </td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style12">
                    <asp:Button ID="btnFiltrar" runat="server" AutoPostBack="true" OnClick="btnFiltrar_Click" Text="Filtrar" />
&nbsp;&nbsp;
                    <asp:Button ID="btnQuitar_Filtro" runat="server" AutoPostBack="true" Text="Quitar Filtro" Width="97px" OnClick="btnQuitar_Filtro_Click" />
                </td>
                <td class="auto-style13"></td>
                <td class="auto-style14"></td>
                <td class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    <asp:GridView ID="gvProductos" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
