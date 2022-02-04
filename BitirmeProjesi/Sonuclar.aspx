<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sonuclar.aspx.cs" Inherits="BitirmeProjesi.Sonuclar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Bitirme Projesi</title>
        <link href="/StyleSheet1.css" rel="stylesheet"/>
</head>
<body>
     <form id="form1" runat="server">
        <div id="wrapper">
             <div class="logo"></div>
            <div class="arama"> 
                <asp:TextBox runat="server" ID="txtArama1" BackColor="White" BorderColor="#CCFFCC" BorderStyle="None" Height="31px" Width="439px" Placeholder="Makale Ara" />
                <asp:Button Text="ARA" ID="btnArama1" runat="server" OnClick="btnArama_Click1" BackColor="Silver" BorderColor="#669999" BorderStyle="None" ForeColor="#333300" Height="34px" Width="62px" position= "fixed" left= "480px"
	top= "200px" />
        </div>
            <div class="sonuclar">
                 BULUNAN SONUÇLAR:<br/>
                <asp:Repeater runat="server" ID="rptAramaSonuclari" OnItemCommand="rptAramaSonuclari_ItemCommand">
                    <ItemTemplate>
                    <%#Eval ("baslik") %> <br/>
                     <%#Eval ("yazari") %><br/>
                      <a  href="AramaSonuclari.aspx?detay=<%#Eval("baslik") %>"><figcaption>Detaylar için tıklayınız</figcaption></a><br/>
                    </ItemTemplate>
				</asp:Repeater>
                <br/>
                 <asp:Label ID="lblOneri" runat="server" Text=""></asp:Label>
                 <br />
                 <asp:Label ID="lblOneri0" runat="server" Text=""></asp:Label>
             </div>
			<p>Her Hakkı Saklıdır</p>
            </div>
          <div class="header">
            <p>Semantik Web Tabanlı Akademi Bilgi Sistemi</p>
        </div>
        
         <div class="footer">
             Her Hakkı Saklıdır</div>
        </form>
</body>
</html>
