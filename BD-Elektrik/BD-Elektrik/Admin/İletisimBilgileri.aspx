<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="İletisimBilgileri.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-2">
            </div>
            <div class="col-lg-8">
                <div class="card">
                    <div class="card-header">
                        <strong>İletişim Bilgileri Ekleme</strong>
                    </div>
                    <div class="card-body card-block">

                        <div class="row form-group">
                                                       
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Mail</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_mail" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Telefon</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_Telefon" runat="server" class="form-control">
                            </div>

                            <div class="col col-sm-3">
                                <label class=" form-control-label">Konum</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_konum" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">İnstagram</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_insta" runat="server" class="form-control">
                            </div>

                            <div class="col col-sm-3">
                                <label class=" form-control-label">Facebook</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_face" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Whatsapp</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_wp" runat="server" class="form-control">
                            </div>
                            
                        </div>
                        <div class="form-actions form-group">
                            <asp:Button ID="Ekle" OnClick="Ekle_Click1" runat="server" class="btn btn-primary btn-sm" Text="Arıza Ekle" />
                        </div>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-lg-2">
                
            </div>
            <div class="col-lg-12">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>            
        </div>
    </div>
</asp:Content>
