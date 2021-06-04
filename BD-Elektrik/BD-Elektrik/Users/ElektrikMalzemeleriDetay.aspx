<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Ana.Master" AutoEventWireup="true" CodeBehind="ElektrikMalzemeleriDetay.aspx.cs" Inherits="BD_Elektrik.Users.WebForm10" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="intro-single">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-lg-8">
                    <div class="title-single-box">
                        <h1 class="title-single">Ürün İncele</h1>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="agent-single">
        <div class="container">
            <div class="row">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="col-sm-12">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="agent-avatar-box">
                                        <img src="<%#Eval("Resim")%>" alt="" class="agent-avatar img-fluid">
                                    </div>
                                </div>
                                <div class="col-md-5 section-md-t3">
                                    <div class="agent-info-box">
                                        <div class="agent-title">
                                            <div class="title-box-d">
                                                <h3 class="title-d"><%#Eval("ÜrünAdi")%>
                                                </h3>
                                            </div>
                                        </div>
                                        <div class="agent-content mb-3">
                                            <p class="content-d color-text-a">
                                                <%#Eval("ÜrünAciklama")%>
                                            </p>
                                            <div class="info-agents color-a">
                                                <p>
                                                    <strong>Fiyat: </strong>
                                                    <span class="color-text-a"><%#Eval("Fiyat")%> </span>
                                                </p>
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
</asp:Content>
