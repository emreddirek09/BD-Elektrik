<%@ Page Title="İletişim" EnableEventValidation="false" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="BD_Elektrik.Users.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="main">

    <!-- ======= Intro Single ======= -->
    <section class="intro-single">
      <div class="container">
        <div class="row">
          <div class="col-md-12 col-lg-8">
            <div class="title-single-box">
              <h1 class="title-single">İletişim</h1>
              <span class="color-text-a"> Aydın ve çevresinde ulaşım imkanı olan yerlerde arıza ve herhangi malzeme tedariği için ulaşım sağlayabilirsiniz. </span>
            </div>
          </div>
          <div class="col-md-12 col-lg-4">
            <nav aria-label="breadcrumb" class="breadcrumb-box d-flex justify-content-lg-end">
              <ol class="breadcrumb">
                <li class="breadcrumb-item">
                  <a href="Default.aspx">Anasayfa</a>
                </li>
                <li class="breadcrumb-item active" aria-current="page">
                  İletişim
                </li>
              </ol>
            </nav>
          </div>
        </div>
      </div>
    </section>
    <section class="contact">
      <div class="container">
        <div class="row">
          <div class="col-sm-12">
            <div class="contact-map box">
              <div id="map" class="contact-map">
                  <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d50416.71437124903!2d27.812397155782534!3d37.835840603002254!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14b92b6627dced2f%3A0xcca12f1bcb3b322e!2zQXlkxLFuLCBFZmVsZXIvQXlkxLFu!5e0!3m2!1str!2str!4v1616672013507!5m2!1str!2str" width="100%" height="450" style="border:0;" allowfullscreen="" loading="lazy"></iframe>              
              </div>
            </div>
          </div>
          <div class="col-sm-12 section-t8">
            <div class="row">
              <div class="col-md-7">
                <form action="forms/contact.php" method="post" role="form" class="php-email-form">
                  <div class="row">
                    <div class="col-md-6 mb-3">
                      <div class="form-group">
                        <input id="isim" runat="server" type="text" name="name" class="form-control form-control-lg form-control-a" placeholder="İsim" data-rule="minlen:4" >
                        <div class="validate"></div>
                      </div>
                    </div>
                    <div class="col-md-6 mb-3">
                      <div class="form-group">
                        <input id="mail" runat="server" type="email" class="form-control form-control-lg form-control-a" placeholder="Mail" data-rule="email" >
                        <div class="validate"></div>
                      </div>
                    </div>
                    <div class="col-md-12 mb-3">
                      <div class="form-group">
                        <input id="konu" runat="server" type="text" name="subject" class="form-control form-control-lg form-control-a" placeholder="Konu" data-rule="minlen:4" >
                        <div class="validate"></div>
                      </div>
                    </div>
                    <div class="col-md-12">
                      <div class="form-group">
                        <textarea id="mesaj" runat="server" name="message" class="form-control" cols="45" rows="8" data-rule="required" placeholder="Mesajınız"></textarea>
                        <div class="validate"></div>
                      </div>
                    </div>
                    <div class="col-md-12 text-center">
                        <asp:Button ID="Gönder" OnClick="Gönder_Click"  class="btn btn-a" runat="server" Text="Mesaj Gönderin" />                        

                    </div>
                  </div>
                </form>
              </div>
              <div class="col-md-5 section-md-t3">
                <div class="icon-box section-b2">
                  <div class="icon-box-icon">
                    <span class="ion-ios-paper-plane"></span>
                  </div>
                  <div class="icon-box-content table-cell">
                    <div class="icon-box-title">
                      <h4 class="icon-title">Merhaba..</h4>
                    </div>
                    <div class="icon-box-content">
                      <p class="mb-1">Email
                        <span class="color-a">burak@bdelektrik.com</span>
                      </p>
                      <p class="mb-1">Phone.
                        <span class="color-a">0 535 280 81 61</span>
                      </p>
                    </div>
                  </div>
                </div>
                <div class="icon-box section-b2">
                  <div class="icon-box-icon">
                    <span class="ion-ios-pin"></span>
                  </div>
                  <div class="icon-box-content table-cell">
                    <div class="icon-box-title">
                      <h4 class="icon-title">Konum</h4>
                    </div>
                    <div class="icon-box-content">
                      <p class="mb-1">
                        Aydın
                        <br> Efeler
                      </p>
                    </div>
                  </div>
                </div>
                <div class="icon-box">
                  <div class="icon-box-icon">
                    <span class="ion-ios-redo"></span>
                  </div>
                  <div class="icon-box-content table-cell">
                    <div class="icon-box-title">
                      <h4 class="icon-title">Sosyal Medya</h4>
                    </div>
                    <div class="icon-box-content">
                      <div class="socials-footer">
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
        </div>
      </div>
    </section>
  </main>
</asp:Content>
