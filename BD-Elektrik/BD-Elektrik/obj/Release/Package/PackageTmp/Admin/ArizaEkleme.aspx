<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ArizaEkleme.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-3">
            </div>
            <div class="col-lg-6">
                <div class="card">
                    <div class="card-header">
                        <strong>Arıza Kategori Ekleme</strong>
                    </div>
                    <div class="card-body card-block">
                        <div class="has-success form-group">
                            <label for="inputIsValid" class=" form-control-label">Kategori İsmi</label>
                            <input type="text" id="txt_Kategori" runat="server" class="is-valid form-control-success form-control">
                        </div>
                        <div class="form-actions form-group">
                            <asp:Button ID="Ekle" runat="server" OnClick="Ekle_Click" class="btn btn-primary btn-sm" Text="Ekle" />
                        </div>
                        <asp:Label ID="Label1" runat="server" ></asp:Label>
                    </div>
                </div>               
            </div>
            <div class="col-lg-3">
            </div>
        </div>
    </div>    
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-2">
            </div>
            <div class="col-lg-8">
                <div class="card">
                    <div class="card-header">
                        <strong>Arıza İçerik Ekleme</strong>
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
                                <label class=" form-control-label">Arıza Adı</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_ArizaAdi" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Arıza İçerik</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_Arizaicerik" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Ürün Resim</label>
                            </div>
                            <div class="col col-sm-9">
                                <asp:FileUpload class="form-control" ID="Resim" runat="server" />
                                <asp:HiddenField ID="HiddenFieldResim" runat="server" />
                                <%--<asp:Label ID="lblDurum" CssClass="text-left" runat="server"></asp:Label>--%>
                            </div>
                        </div>
                        <div class="form-actions form-group">
                            <asp:Button ID="ArizaEkle" OnClick="ArizaEkle_Click" runat="server" class="btn btn-primary btn-sm" Text="Arıza Ekle" />
                        </div>
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </div>
                     <asp:GridView CssClass="container" ID="GridView1" runat="server"></asp:GridView>
                </div>
            </div>
            <div class="col-lg-2">
                
            </div>
                       
        </div>
    </div>
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-3">
            </div>
            <div class="col-lg-6">
                <div class="card">
                    <div class="card-header">
                        <strong>Arıza Sil</strong>
                    </div>
                    <div class="card-body card-block">
                        <div class="has-success form-group">
                            <label for="inputIsValid" class=" form-control-label">Kategori id</label>
                            <input type="text" id="Katid" runat="server" class="is-valid form-control-success form-control">
                        </div>
                        <div class="form-actions form-group">
                            <asp:Button ID="sil" OnClick="sil_Click" runat="server" class="btn btn-primary btn-sm" Text="Sil" />
                        </div>
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-lg-3">
            </div>
        </div>
    </div>
</asp:Content>
