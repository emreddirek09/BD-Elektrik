<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="Ariza.aspx.cs" Inherits="BD_Elektrik.Users.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="main">
        <section class="intro-single">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-lg-8">
                        <div class="title-single-box">
                            <h1 class="title-single">Elektrik Arıza</h1>
                            <span class="color-text-a">Temel Arızalar bildirilmiş olup farklı durumlar için iletişime geçebilirsiniz.</span>
                        </div>
                    </div>
                    <div class="col-md-12 col-lg-4">
                        <nav aria-label="breadcrumb" class="breadcrumb-box d-flex justify-content-lg-end">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item">
                                    <a href="Default.aspx">AnaSayfa</a>
                                </li>
                                <li class="breadcrumb-item active" aria-current="page">Arıza
                                </li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </section>
        <section class="section-agents">
            <div class="container">
                <div class="row">
                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <div class="col-md-4">
                                <div class="card-box-d">
                                    <div class="card-img-d">
                                        <img src="<%#Eval("Resim")%>" alt="" class="img-d img-fluid">
                                    </div>
                                    <div class="card-overlay card-overlay-hover">
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
    </main>
</asp:Content>
