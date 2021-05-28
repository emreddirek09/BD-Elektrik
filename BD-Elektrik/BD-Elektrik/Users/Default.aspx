<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BD_Elektrik.Users.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- ======= Intro Section ======= -->
    <div class="intro intro-carousel">
        <div id="carousel" class="owl-carousel owl-theme">
            <div class="carousel-item-a intro-item bg-image" style="background-image: url(../Admin/img/Slider/Untitled-1_0006_C2-after.jpg)">
                <%--<div class="overlay overlay-a"></div>
                <div class="intro-content display-table">
                    <div class="table-cell">
                        <div class="container">
                            <div class="row">
                                <div class="col-lg-8"><a href="../Admin/img/Slider/">../Admin/img/Slider/</a>
                                    <div class="intro-body">
                                        <p class="intro-title-top">
                                            Doral, Florida
                      <br>
                                            78345
                                        </p>
                                        <h1 class="intro-title mb-4">
                                            <span class="color-b">204 </span>Mount
                      <br>
                                            Olive Road Two
                                        </h1>
                                        <p class="intro-subtitle intro-price">
                                            <a href="#"><span class="price-a">rent | $ 12.000</span></a>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>--%>
            </div>
            <div class="carousel-item-a intro-item bg-image" style="background-image: url(../Admin/img/Slider/FEHBB9FHCB8R3CN.jpg)">
                <%--<div class="overlay overlay-a"></div>
                <div class="intro-content display-table">
                    <div class="table-cell">
                        <div class="container">
                            <div class="row">
                                <div class="col-lg-8">
                                    <div class="intro-body">
                                        <p class="intro-title-top">
                                            Doral, Florida
                      <br>
                                            78345
                                        </p>
                                        <h1 class="intro-title mb-4">
                                            <span class="color-b">204 </span>Rino
                      <br>
                                            Venda Road Five
                                        </h1>
                                        <p class="intro-subtitle intro-price">
                                            <a href="#"><span class="price-a">rent | $ 12.000</span></a>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>--%>
            </div>
            <div class="carousel-item-a intro-item bg-image" style="background-image: url(../Admin/img/Slider/electrician.jpg)">
                <%--<div class="overlay overlay-a"></div>
                <div class="intro-content display-table">
                    <div class="table-cell">
                        <div class="container">
                            <div class="row">
                                <div class="col-lg-8">
                                    <div class="intro-body">
                                        <p class="intro-title-top">
                                            Doral, Florida
                      <br>
                                            78345
                                        </p>
                                        <h1 class="intro-title mb-4">
                                            <span class="color-b">204 </span>Alira
                      <br>
                                            Roan Road One
                                        </h1>
                                        <p class="intro-subtitle intro-price">
                                            <a href="#"><span class="price-a">rent | $ 12.000</span></a>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>--%>
            </div>
        </div>
    </div>
    <section class="section-property section-t8">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="title-wrap d-flex justify-content-between">
                        <div class="title-box">
                            <h2 class="title-a">Elektrik Malzemelerim</h2>
                        </div>
                        <div class="title-link">
                            <a href="ElektrikMalzemelerim.aspx">Devamı
                  <span class="ion-ios-arrow-forward"></span>
                            </a>
                        </div>
                    </div>
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
                                    <img src="<%#Eval("Resim")%>" alt="" class="img-a img-fluid">
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
                                                <span class="price-a"><%#Eval("Fiyat")%></span>
                                            </div>
                                            <a href="property-single.html" class="link-a">Click here to view
                      <span class="ion-ios-arrow-forward"></span>
                                            </a>
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

    <!-- ======= Agents Section ======= -->
    <section class="section-agents section-t8">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="title-wrap d-flex justify-content-between">
                        <div class="title-box">
                            <h2 class="title-a">Arıza Bildir</h2>
                        </div>
                        <div class="title-link">
                            <a href="Ariza.aspx">Devamı
                  <span class="ion-ios-arrow-forward"></span>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4">
                            <div class="card-box-d">
                                <div class="card-img-d">
                                    <img src="<%#Eval("Resim")%>" alt="" class="img-d img-fluid">
                                </div>
                                <div class="card-overlay card-overlay-hover text-center">
                                    <div class="card-header-d">
                                        <div class="card-title-d align-self-center">
                                            <h3 class="title-d">
                                                <a href="#" class="link-two"><%#Eval("ArizaAdi")%>
                                            </h3>
                                        </div>
                                    </div>
                                    <div class="card-body-d">
                                        <p class="content-d color-text-a">
                                            <%#Eval("Arizaiçerik")%>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </section>
    <section class="section-testimonials section-t8 nav-arrow-a">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="title-wrap d-flex justify-content-between">
                        <div class="title-box">
                            <h2 class="title-a">Müşteri Yorumları</h2>
                        </div>
                        <div class="title-link">
                            <a href="MüsteriYorumlari.aspx">Devamı
                  <span class="ion-ios-arrow-forward"></span>
                            </a>
                        </div>
                    </div>
                </div>
            </div>

            <div id="testimonial-carousel" class="owl-carousel owl-arrow">
                <div class="carousel-item-a">
                    <div class="testimonials-box">
                        <div class="row">
                            <asp:Repeater ID="Repeater3" runat="server">
                                <ItemTemplate>
                                    <div class="col-sm-12 col-md-12">
                                        <div class="testimonials-content">
                                            <p class="testimonial-text">
                                                  <%#Eval("Müsteri_Yorum")%>
                                            </p>
                                        </div>
                                        <div class="testimonial-author-box">
                                            <img src="<%#Eval("Resim")%>" alt="" class="testimonial-avatar">
                                            <h5 class="testimonial-author"><%#Eval("isim")%></h5>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
</asp:Content>
