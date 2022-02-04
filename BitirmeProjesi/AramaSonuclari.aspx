<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AramaSonuclari.aspx.cs" Inherits="BitirmeProjesi.AramaSonuclari" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Bitirme Projesi</title>
        <link href="/StyleSonuclar.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            &nbsp;&nbsp;&nbsp;
            <div class="label">
                Başlık:<br />
                Yazarı:<br />
                Tarihi:<br />
                Açıklama:</div>
            <div class="sonuclar"> 
                <asp:Repeater runat="server" ID="rptAramaSonuclari">
                    <ItemTemplate>
                    <%#Eval ("baslik") %> <br/>
                     <%#Eval ("yazari") %><br/>
                        <%#Eval ("tarihi") %><br/>
                        <%#Eval ("aciklama") %>
                    </ItemTemplate>
				</asp:Repeater>
             </div>  
               <div class="anasayfa" <a  href="Default.aspx"> <a/></div>
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
