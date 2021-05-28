<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="Galeri.aspx.cs" Inherits="BD_Elektrik.Users.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="main">
        <section class="intro-single">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-lg-8">
                        <div class="title-single-box">
                            <h1 class="title-single">Güncel Kareler</h1>
                        </div>
                    </div>
                    <div class="col-md-12 col-lg-4">
                        <nav aria-label="breadcrumb" class="breadcrumb-box d-flex justify-content-lg-end">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item">
                                    <a href="Default.aspx">Anasayfa</a>
                                </li>
                                <li class="breadcrumb-item active" aria-current="page">Galeri</li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </section>
        <section class="news-grid grid">
            <div class="container">
                <div class="row">
                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <div class="col-md-4">
                                <div class="card-box-b card-shadow news-box">
                                    <div class="img-box-b">
                                        <img src="<%#Eval("GaleriResim")%>" alt="" class="img-b img-fluid">
                                    </div>
                                    <div class="card-overlay">
                                        <div class="card-header-b">
                                            <div class="card-category-b">
                                                <a href="#" class="category-b"><%#Eval("GaleriBaslik")%></a>
                                            </div>
                                            <div class="card-title-b">
                                                <h2 class="title-2">
                                                    <a href="blog-single.html"><%#Eval("GaleriYazi")%></a>
                                                </h2>
                                            </div>
                                            <div class="card-date">
                                                <span class="date-b"><%#Convert.ToDateTime(Eval("OlusturmaTarihi")).ToShortDateString()%></span>
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
