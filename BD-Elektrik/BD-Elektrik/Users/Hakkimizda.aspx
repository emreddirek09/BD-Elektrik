<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="BD_Elektrik.Users.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="main">
        <section class="intro-single">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-lg-8">
                        <div class="title-single-box">
                            <h1 class="title-single">Biz Kimiz</h1>
                        </div>
                    </div>
                    <div class="col-md-12 col-lg-4">
                        <nav aria-label="breadcrumb" class="breadcrumb-box d-flex justify-content-lg-end">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item">
                                    <a href="Default.aspx">Ana Sayfa</a>
                                </li>
                                <li class="breadcrumb-item active" aria-current="page">Hakkımızda
                                </li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </section>
        <section class="section-about">
            <div class="container">
                <div class="row">
                    <div class="col-sm-12">
                        <div class="about-img-box">
                            <img src="../Admin/img/Hakkimizda/1.jpg" alt="" class="img-fluid">
                        </div>
                        <%--<div class="sinse-box">
                            <h3 class="sinse-title">Dekarasyon                
                                <br>
                                25 EYLÜL 2020
                            </h3><a href="../Admin/img/Hakkimizda/">../Admin/img/Hakkimizda/</a>
                            
                        </div>--%>
                    </div>
                    <div class="col-md-12 section-t8">
                        <div class="row">
                            <div class="col-md-6 col-lg-5">
                                <img src="../Admin/img/Hakkimizda/2.jpg" alt="" class="img-fluid">
                            </div>
                            <div class="col-lg-2  d-none d-lg-block">
                                <div class="title-vertical d-flex justify-content-start">
                                    <span>Yetenek elektrik gibidir</span>
                                </div>
                            </div>
                            <div class="col-md-6 col-lg-5 section-md-t3">
                                <div class="title-box-d">
                                    
                    <span class="color-d">Elektrik </span> çağı
                    <br>
                                        
                                </div>
                                <p class="color-text-a">
                                    2010 yılında Aydın’da, Burak Direk tarafından elektrik sektöründe proje ve arıza giderme hizmetleri vermek amacıyla 
                                    BDElektrik unvanı ile ticari hayatına geçmeyi hedefleyen kişisel çalışmalarım ile başarıyla devam ederek günümüze 
                                    kadar gelmiştir.
                                </p>
                                <p class="color-text-a">
                                    Dürüst, güvenilir ve kaliteli hizmeti kendisine ilke edinerek bulunduğu bölgenin saygın firmaları arasında yerini alan firmamız, 23 yıllık bilgi ve tecrübesiyle, 
                                    konut, fabrika, otel, eğitim kurumu, sosyal tesisler ve misafirhaneler başta olmak üzere birçok özel projeye imzasını başarıyla atmış ve atmaya devam etmektedir.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>
</asp:Content>
