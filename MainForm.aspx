<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="TP4_GRUPO_4.MainForm" %>

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
            width: 256px;
        }
        .auto-style3 {
            width: 107px;
        }
        .auto-style4 {
            width: 236px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblM" runat="server" Font-Size="XX-Large" Text="Main Form"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnEj1" runat="server" OnClick="btnEj1_Click" Text="Ejercicio 1" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnEj2" runat="server" OnClick="btnEj2_Click" Text="Ejercicio 2" />
                </td>
                <td>
                    <asp:Button ID="btnEj3" runat="server" OnClick="btnEj3_Click" Text="Ejercicio 3" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblInt" runat="server" Font-Bold="True" Font-Size="Large" Text="Integrantes"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="lblInt2" runat="server" Text="Lautaro Camejo"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblInt4" runat="server" Text="Luca Gauna"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblInt3" runat="server" Text="Agustin Baied"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="lblInt7" runat="server" Text="Benjamin Romero Lima"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblInt6" runat="server" Text="Franco Fernandez"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblInt5" runat="server" Text="Lucas Saucedo"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
