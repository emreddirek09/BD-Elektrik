<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="MüsteriYorumlari.aspx.cs" Inherits="BD_Elektrik.Users.WebForm8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="main">
        <section class="intro-single">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-lg-8">
                        <div class="title-single-box">
                            <h1 class="title-single">Müşteri Yorumları</h1>
                            <span class="color-text-a">Görüşleriniz</span>
                        </div>
                    </div>
                    <div class="col-md-12 col-lg-4">
                        <nav aria-label="breadcrumb" class="breadcrumb-box d-flex justify-content-lg-end">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item">
                                    <a href="Default.aspx">AnaSayfa</a>
                                </li>
                                <li class="breadcrumb-item active" aria-current="page">Yorumlar </li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </section>
        <section class="section-testimonials nav-arrow-a">
            <div class="container">
                <div id="testimonial-carousel" class="owl-carousel owl-arrow owl-loaded owl-drag">
                    <div class="owl-stage-outer">
                        <div class="owl-stage" style="transform: translate3d(-1110px, 0px, 0px); transition: all 0s ease 0s; width: 2220px;">
                            <div class="owl-item" style="width: 1110px;">
                                <div class="carousel-item-a">
                                    <div class="testimonials-box">
                                        <div class="row">
                                            <asp:Repeater ID="Repeater3" runat="server">
                                                <ItemTemplate>                                                    
                                                    <div class="col-sm-12 col-md-6">
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
                    </div>
                </div>
            </div>
        </section>
    </main>
</asp:Content>
