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
                                </div>
                                <div class="col-md-12 mb-1">
                                    <div class="form-group">
                                        <textarea id="TextArea1"  class="form-control" placeholder="Yorumunuz" cols="45" rows="8"></textarea>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <asp:Button ID="YorumGönder" OnClick="YorumGönder_Click" class="btn btn-a" runat="server" Text="Gönder" />
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
