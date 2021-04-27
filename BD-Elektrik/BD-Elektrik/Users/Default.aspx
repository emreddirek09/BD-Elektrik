<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BD_Elektrik.Users.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- ======= Intro Section ======= -->
    <div class="intro intro-carousel">
        <div id="carousel" class="owl-carousel owl-theme">
            <div class="carousel-item-a intro-item bg-image" style="background-image: url(assets/img/slide-1.jpg)">
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
            <div class="carousel-item-a intro-item bg-image" style="background-image: url(assets/img/slide-2.jpg)">
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
            <div class="carousel-item-a intro-item bg-image" style="background-image: url(assets/img/slide-3.jpg)">
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
    <div class="click-closed"></div>
    <!--/ Form Search Star /-->
    <div class="box-collapse">
        <span class="close-box-collapse right-boxed ion-ios-close"></span>
        <div class="box-collapse-wrap form">
            <div class="title-box-d">
                <h3 class="title-d">Giriş</h3>
            </div>
            <div class="row">
                <div class="col-md-12 mb-2">
                    <div class="form-group">
                        <label for="Type">Kullanıcı Adı</label>
                        <input id="mail" runat="server" type="text" class="form-control form-control-lg form-control-a" placeholder="Mail">
                    </div>
                </div>
                <div class="col-md-12 mb-2">
                    <div class="form-group">
                        <label for="Type">Şifre</label>
                        <input id="sifre" runat="server" type="text" class="form-control form-control-lg form-control-a" placeholder="Şifre">
                    </div>
                </div>
                <div class="col-md-12">
                    <button type="submit" class="btn btn-b">Giriş Yap</button>
                </div>
            </div>

            <div class="title-box-d">
                <h3 class="title-d">Kayıt</h3>
            </div>

            <div class="row">
                <div class="col-md-6 mb-2">
                    <div class="form-group">
                        <label for="Type">İsim</label>
                        <input type="text" class="form-control form-control-lg form-control-a" placeholder="Ad-Soyad">
                    </div>
                </div>
                <div class="col-md-6 mb-2">
                    <div class="form-group">
                        <label for="Type">Kullanıcı Adı</label>
                        <input type="text" class="form-control form-control-lg form-control-a" placeholder="Mail">
                    </div>
                </div>
                <div class="col-md-6 mb-2">
                    <div class="form-group">
                        <label for="Type">Şifre</label>
                        <input type="text" class="form-control form-control-lg form-control-a" placeholder="Şifre">
                    </div>
                </div>
                <div class="col-md-6 mb-2">
                    <div class="form-group">
                        <label for="Type">Şifre Onay</label>
                        <input type="text" class="form-control form-control-lg form-control-a" placeholder="Şifre Onay">
                    </div>
                </div>
                <div class="col-md-12">
                     <label for="Type">Profil Resmi</label>
                    <asp:FileUpload class="form-control" ID="Resim" runat="server" />
                    <asp:HiddenField ID="HiddenFieldResim" runat="server" />
                </div><br /><br /><br />
                <div class="col-md-12">
                    <button type="submit" class="btn btn-b">Kayıt Ol</button>
                </div>
            </div>
        </div>
    </div>
    <!-- End Property Search Section -->
    
    <section class="section-property section-t8">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="title-wrap d-flex justify-content-between">
                        <div class="title-box">
                            <h2 class="title-a">Elektrik Malzemelerim</h2>
                        </div>
                        <div class="title-link">
                            <a href="property-grid.html">Devamı
                  <span class="ion-ios-arrow-forward"></span>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
    </section>
    <section class="property-grid grid">
        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <div class="card-box-a card-shadow">
                        <div class="img-box-a">
                            <img src="assets/img/property-10.jpg" alt="" class="img-a img-fluid">
                        </div>
                        <div class="card-overlay">
                            <div class="card-overlay-a-content">
                                <div class="card-header-a">
                                    <h2 class="card-title-a">
                                        <a href="#">204 Mount
                        <br>
                                            Olive Road Two</a>
                                    </h2>
                                </div>
                                <div class="card-body-a">
                                    <div class="price-box d-flex">
                                        <span class="price-a">rent | $ 12.000</span>
                                    </div>
                                    <a href="property-single.html" class="link-a">Click here to view
                      <span class="ion-ios-arrow-forward"></span>
                                    </a>
                                </div>
                                <div class="card-footer-a">
                                    <ul class="card-info d-flex justify-content-around">
                                        <li>
                                            <h4 class="card-info-title">Area</h4>
                                            <span>340m
                          <sup>2</sup>
                                            </span>
                                        </li>
                                        <li>
                                            <h4 class="card-info-title">Beds</h4>
                                            <span>2</span>
                                        </li>
                                        <li>
                                            <h4 class="card-info-title">Baths</h4>
                                            <span>4</span>
                                        </li>
                                        <li>
                                            <h4 class="card-info-title">Garages</h4>
                                            <span>1</span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
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
                            <a href="agents-grid.html">Devamı
                  <span class="ion-ios-arrow-forward"></span>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <div class="card-box-d">
                        <div class="card-img-d">
                            <img src="assets/img/agent-4.jpg" alt="" class="img-d img-fluid">
                        </div>
                        <div class="card-overlay card-overlay-hover">
                            <div class="card-header-d">
                                <div class="card-title-d align-self-center">
                                    <h3 class="title-d">
                                        <a href="agent-single.html" class="link-two">Margaret Sotillo
                        <br>
                                            Escala</a>
                                    </h3>
                                </div>
                            </div>
                            <div class="card-body-d">
                                <p class="content-d color-text-a">
                                    Sed porttitor lectus nibh, Cras ultricies ligula sed magna dictum porta two.
                                </p>
                                <div class="info-agents color-a">
                                    <p>
                                        <strong>Phone: </strong>+54 356 945234
                                    </p>
                                    <p>
                                        <strong>Email: </strong>agents@example.com
                                    </p>
                                </div>
                            </div>
                            <div class="card-footer-d">
                                <div class="socials-footer d-flex justify-content-center">
                                    <ul class="list-inline">
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-facebook" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-twitter" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-instagram" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-pinterest-p" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-dribbble" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="card-box-d">
                        <div class="card-img-d">
                            <img src="assets/img/agent-1.jpg" alt="" class="img-d img-fluid">
                        </div>
                        <div class="card-overlay card-overlay-hover">
                            <div class="card-header-d">
                                <div class="card-title-d align-self-center">
                                    <h3 class="title-d">
                                        <a href="agent-single.html" class="link-two">Stiven Spilver
                        <br>
                                            Darw</a>
                                    </h3>
                                </div>
                            </div>
                            <div class="card-body-d">
                                <p class="content-d color-text-a">
                                    Sed porttitor lectus nibh, Cras ultricies ligula sed magna dictum porta two.
                                </p>
                                <div class="info-agents color-a">
                                    <p>
                                        <strong>Phone: </strong>+54 356 945234
                                    </p>
                                    <p>
                                        <strong>Email: </strong>agents@example.com
                                    </p>
                                </div>
                            </div>
                            <div class="card-footer-d">
                                <div class="socials-footer d-flex justify-content-center">
                                    <ul class="list-inline">
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-facebook" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-twitter" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-instagram" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-pinterest-p" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-dribbble" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="card-box-d">
                        <div class="card-img-d">
                            <img src="assets/img/agent-5.jpg" alt="" class="img-d img-fluid">
                        </div>
                        <div class="card-overlay card-overlay-hover">
                            <div class="card-header-d">
                                <div class="card-title-d align-self-center">
                                    <h3 class="title-d">
                                        <a href="agent-single.html" class="link-two">Emma Toledo
                        <br>
                                            Cascada</a>
                                    </h3>
                                </div>
                            </div>
                            <div class="card-body-d">
                                <p class="content-d color-text-a">
                                    Sed porttitor lectus nibh, Cras ultricies ligula sed magna dictum porta two.
                                </p>
                                <div class="info-agents color-a">
                                    <p>
                                        <strong>Phone: </strong>+54 356 945234
                                    </p>
                                    <p>
                                        <strong>Email: </strong>agents@example.com
                                    </p>
                                </div>
                            </div>
                            <div class="card-footer-d">
                                <div class="socials-footer d-flex justify-content-center">
                                    <ul class="list-inline">
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-facebook" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-twitter" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-instagram" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-pinterest-p" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a href="#" class="link-one">
                                                <i class="fa fa-dribbble" aria-hidden="true"></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
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
                            <div class="col-sm-12 col-md-12">
                                <div class="testimonials-content">
                                    <p class="testimonial-text">
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis, cupiditate ea nam praesentium
                      debitis hic ber quibusdam
                      voluptatibus officia expedita corpori.
                                    </p>
                                </div>
                                <div class="testimonial-author-box">
                                    <img src="assets/img/mini-testimonial-1.jpg" alt="" class="testimonial-avatar">
                                    <h5 class="testimonial-author">Albert & Erika</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
</asp:Content>
