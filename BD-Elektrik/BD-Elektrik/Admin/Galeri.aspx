<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Galeri.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-2">
            </div>
            <div class="col-lg-8">
                <div class="card">
                    <div class="card-header">
                        <strong>Galeri Ekleme</strong>
                    </div>
                    <div class="card-body card-block">
                        <div class="row form-group">

                            <div class="col col-sm-3">
                                <label class=" form-control-label">Resim Başlık(Dekarasyon)</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_Baslik" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Galeri Yazı(Konum)</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_Yazi" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Resim</label>
                            </div>
                            <div class="col col-sm-9">
                                <asp:FileUpload class="form-control" ID="Resim" runat="server" />
                                <asp:HiddenField ID="HiddenFieldResim" runat="server" />
                                <%--<asp:Label ID="lblDurum" CssClass="text-left" runat="server"></asp:Label>--%>
                            </div>
                        </div>
                        <div class="form-actions form-group">
                            <asp:Button ID="Ekle" OnClick="Ekle_Click" runat="server" class="btn btn-primary btn-sm" Text="Ekle" />
                        </div>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

                    </div>
                </div>
            </div>
            <div class="col-lg-2">
            </div>
            <div class="row">
                <div class="col-12">
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
