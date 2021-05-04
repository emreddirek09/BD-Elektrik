<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="MüşteriSayfası.aspx.cs" Inherits="BD_Elektrik.Users.WebForm9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="intro-single">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-lg-12">
                    <div class="title-single-box">
                        <h1 class="title-single">Yorumlar Sayfasına Hoş Geldiniz...</h1>
                        <span class="color-text-a">Sizin fikir ve düşünceleriniz her zaman önceliğimizdir.  </span>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="property-single nav-arrow-b">
        <div class="container">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-6 col-lg-4">
                        <img src="assets/img/agent-4.jpg" alt="" class="img-fluid">
                    </div>
                    <div class="col-md-6 col-lg-8">
                        <div class="property-contact">

                            <div class="row">
                                <div class="col-md-12 mb-1 text-center">
                                    <h4 class="title-agent">Emre Direk </h4>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </div>
                                <div class="col-md-12 mb-1">
                                    <div class="form-group">
                                        <textarea id="TextArea1" runat="server" class="form-control" placeholder="Yorumunuz" cols="45" rows="8"></textarea>
                                    </div>
                                </div>
                                <div class="col-md-12"> 
                                    <asp:Button ID="YorumGönder" class="btn btn-success" OnClick="YorumGönder_Click1" runat="server" Text="Yorum Gönder" />   
                                    <asp:Button ID="cikis" OnClick="cikis_Click1" class="btn btn-danger" runat="server" Text="Çıkış Yap" />    
                                    
                                    <%--<button id="YorumGönder" class="btn btn-b-n" type="button" onclick="YorumGönder_Click">
                                        <span class="fa fa-send" aria-hidden="true"></span> Gönder
                                    </button>
                                    <button id="cikis" class="btn btn-danger" type="button" onclick="cikis_Click">
                                        <span class="fa fa-close" aria-hidden="true">ÇIKIŞ</span> 
                                    </button>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
