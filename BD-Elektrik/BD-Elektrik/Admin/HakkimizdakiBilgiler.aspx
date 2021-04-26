<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="HakkimizdakiBilgiler.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-2">
            </div>
            <div class="col-lg-8">
                <div class="card">
                    <div class="card-header">
                        <strong>Hakkımızdaki Bilgileri Ekleme</strong>
                    </div>
                    <div class="card-body card-block">

                        <div class="row form-group">
                                                       
                            <div class="col col-sm-3">
                                <label class=" form-control-label">1. Paragraf</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_paragraf1" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">2. Paragraf</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_paragraf2" runat="server" class="form-control">
                            </div>

                            <div class="col col-sm-3">
                                <label class=" form-control-label">Özlü Söz 1</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_söz1" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Özlü Söz 2</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_söz2" runat="server" class="form-control">
                            </div>                            
                            
                        </div>
                        <div class="form-actions form-group">
                            <asp:Button ID="Ekle" OnClick="Ekle_Click" runat="server" class="btn btn-primary btn-sm" Text="Arıza Ekle" />
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
