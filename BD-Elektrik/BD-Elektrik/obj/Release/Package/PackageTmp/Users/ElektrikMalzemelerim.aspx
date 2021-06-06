<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="ElektrikMalzemelerim.aspx.cs" Inherits="BD_Elektrik.Users.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="main">

        <!-- ======= Intro Single ======= -->
        <section class="intro-single">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-lg-8">
                        <div class="title-single-box">
                            <h1 class="title-single">Elektrik Malzemeleri</h1>
                            <span class="color-text-a">İhtiyacınız olan malzemlerin tedarik sürceni gerçekleştirmek için iletişime geçebilirsiniz.</span>
                        </div>
                    </div>
                    <div class="col-md-12 col-lg-4">
                        <nav aria-label="breadcrumb" class="breadcrumb-box d-flex justify-content-lg-end">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item">
                                    <a href="Default.aspx">AnaSayfa</a>
                                </li>
                                <li class="breadcrumb-item active" aria-current="page">Malzemeler
                                </li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </section>
        <section class="property-grid grid">
            <div class="container">
                <div class="row">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div class="col-md-4">
                                <div class="card-box-a card-shadow">
                                    <div class="img-box-a">
                                        <img src="<%#Eval("Resim")%>" alt=" <%#Eval("ÜrünAciklama")%>" class="img-a img-fluid">
                                    </div>
                                    <div class="card-overlay">
                                        <div class="card-overlay-a-content">
                                            <div class="card-header-a">
                                                <h2 class="card-title-a">
                                                    <a href="#"><%#Eval("ÜrünAdi")%></a>
                                                </h2>
                                            </div>
                                            <div class="card-body-a">
                                                <div class="price-box d-flex">
                                                    <span class="price-a"><%#Eval("Fiyat")%> TL </span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>
        </section>
    </main>
</asp:Content>
