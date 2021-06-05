<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BD_Elektrik.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Burak Elektrik Admin Giriş Sayfası</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"/>
</head>
<body>
<div class="container">
    <div class="row">
        <div class="col-md-6">
            <div class="card">
                <form runat="server" class="box">
                    <h1>Login</h1>
                    <p class="text-muted"> Lütfen Giriş Bilgilerini Giriniz!</p> 
                    <input type="text" runat="server" id="KulAdi" name="" placeholder="Kullanıcı Adı"/> 
                    <input type="password" runat="server" id="KulSifre" name="" placeholder="Şifre"/> 
                    <asp:Button ID="Giris" OnClick="Giris_Click" runat="server" Text="Giriş" />
                    <asp:Label ID="Label1" runat="server" ForeColor="White"></asp:Label>
                </form>
            </div>
        </div>
    </div>
</div>
</body>
</html>
