<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Malzemeler.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-2">
            </div>
            <div class="col-lg-8">
                <div class="card">
                    <div class="card-header">
                        <strong>Malzeme İçerik Ekleme</strong>
                    </div>
                    <div class="card-body card-block">

                        <div class="row form-group">
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Kategori Seç</label>
                            </div>
                            <div class="col col-sm-9">
                                <asp:DropDownList CssClass="form-control" ID="DropDownListKategori" runat="server">
                                    <asp:ListItem Value="-1">Seçiniz</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Ürün Adı</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_ürünAdi" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Ürün Açıklama</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_ürünAciklama" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Ürün Resim</label>
                            </div>                            
                            <div class="col col-sm-9">
                                <asp:FileUpload class="form-control" id="Resim" runat="server"/>
                                <asp:HiddenField ID="HiddenFieldResim" runat="server" />
                                <%--<asp:Label ID="lblDurum" CssClass="text-left" runat="server"></asp:Label>--%>
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Ürün Fiyatı</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_ürünFiyat" runat="server" class="form-control">
                            </div>
                        </div>
                        <div class="form-actions form-group">
                            <asp:Button ID="Ekle" OnClick="Ekle_Click1" runat="server" class="btn btn-primary btn-sm" Text="Ekle" />
                        </div>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        
                    </div>
                </div>
            </div>
            <div class="col-lg-2">
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </div>
            <div class="row">
                <div class="col-12">
                    <asp:Button ID="Entty" runat="server" OnClick="Entty_Click" Text="Ent Veri Çek" />
                     <asp:Button ID="GetByMalzemeler" runat="server" OnClick="GetByMalzemeler_Click" Text="GetByMalzemeler" />
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

                </div>

            </div>
        </div>
    </div>
</asp:Content>
