﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="ElektrikMalzemelerim.aspx.cs" Inherits="BD_Elektrik.Users.WebForm6" %>
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
                <li class="breadcrumb-item active" aria-current="page">
                  Malzemeler
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
          <div class="col-md-4">
            <div class="card-box-a card-shadow">
              <div class="img-box-a">
                <img src="assets/img/property-1.jpg" alt="" class="img-a img-fluid">
              </div>
              <div class="card-overlay">
                <div class="card-overlay-a-content">
                  <div class="card-header-a">
                    <h2 class="card-title-a">
                      <a href="#"> Mazleme ismi</a>
                    </h2>
                  </div>
                  <div class="card-body-a">
                    <div class="price-box d-flex">
                      <span class="price-a">Fiyat: | $ 12.000</span>
                    </div>
                    <%--<a href="property-single.html" class="link-a">Click here to view
                      <span class="ion-ios-arrow-forward"></span>
                    </a>--%>
                  </div>
               <%--   <div class="card-footer-a">
                    <ul class="card-info d-flex justify-content-around">
                      <li>
                        <h4 class="card-info-title">Kalite</h4>
                        <span>1                         
                        </span>
                      </li>
                      <li>
                        <h4 class="card-info-title">Tür</h4>
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
                  </div>--%>
                </div>
              </div>
            </div>
          </div>          
        </div>        
      </div>
    </section>
  </main>
</asp:Content>