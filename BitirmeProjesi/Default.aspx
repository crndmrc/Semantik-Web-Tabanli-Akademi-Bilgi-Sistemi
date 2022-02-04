<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BitirmeProjesi.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Bitirme Projesi</title>
    <link href="/Style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            <div class="logo"></div>
            <div class="arama"> 
                <asp:TextBox runat="server" ID="txtArama" BackColor="White" BorderColor="#CCFFCC" BorderStyle="None" Height="31px" Width="439px" Placeholder="Makale Ara" />
                <asp:Button Text="ARA" ID="btnArama" runat="server" OnClick="btnArama_Click1" BackColor="Silver" BorderColor="#669999" BorderStyle="None" ForeColor="#333300" Height="34px" Width="62px" position= "fixed" left= "480px"
	top= "200px" />
             </div> <br />
            <asp:Label ID="lblOneri" runat="server" Text=""></asp:Label>
        </div>
         <div class="header">
			<p>Semantik Web Tabanlı Akademi Bilgi Sistemi</p>
        </div>
        <div class="footer">
			<p>Her Hakkı Saklıdır</p>
        </div>
    </form>
</body>
</html>
