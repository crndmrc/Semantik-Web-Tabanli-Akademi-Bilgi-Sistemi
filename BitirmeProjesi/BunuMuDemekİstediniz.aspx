<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BunuMuDemekİstediniz.aspx.cs" Inherits="BitirmeProjesi.BunuMuDemekİstediniz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 <div>
 <asp:TextBox ID="txtAra" runat="server"></asp:TextBox>
 <asp:Button ID="btnAra" runat="server"
 Text="Ara" onclick="btnAra_Click" />
 </div>
 <asp:Repeater ID="rpListe" runat="server">
 <HeaderTemplate>
 <table>
 </HeaderTemplate>
 <ItemTemplate>
 <tr>
 <td>
 <a href="#">
 <%#Eval("baslik")%></a>
 </td>
 </tr>
 </ItemTemplate>
 <FooterTemplate>
 </table>
 </FooterTemplate>
 </asp:Repeater>
 <asp:Label ID="lblOneri" runat="server" Text=""></asp:Label>
 </form>
</body>
</html>
