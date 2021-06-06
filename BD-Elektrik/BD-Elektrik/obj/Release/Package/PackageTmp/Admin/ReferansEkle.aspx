<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ReferansEkle.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-2">
            </div>
            <div class="col-lg-8">
                <div class="card">
                    <div class="card-header">
                        <strong>Referans Bilgileri Ekleme</strong>
                    </div>
                    <div class="card-body card-block">

                        <div class="row form-group">                             

                            <div class="col col-sm-3">
                                <label class=" form-control-label">Referans Ad</label>
                            </div>
                            <div class="col col-sm-9">
                                <input type="text" id="txt_Ref" runat="server" class="form-control">
                            </div>
                            <div class="col col-sm-3">
                                <label class=" form-control-label">Resim</label>
                            </div>                            
                            <div class="col col-sm-9">
                                <asp:FileUpload class="form-control" id="Resim" runat="server"/>
                                <asp:HiddenField ID="HiddenFieldResim" runat="server" />
                            </div>                                                      
                        </div>
                        <div class="form-actions form-group">
                            <asp:Button ID="Ekle" OnClick="Ekle_Click" runat="server" class="btn btn-primary btn-sm" Text="Ekle" />
                        </div>
                        <asp:Label ID="Label2" runat="server" ></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-lg-2">
                
            </div>
            <div class="col-lg-12">
                <asp:GridView ID="GridView1" CssClass="container" runat="server"></asp:GridView>
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
                        <strong>Referans Sil</strong>
                    </div>
                    <div class="card-body card-block">
                        <div class="has-success form-group">
                            <label for="inputIsValid" class=" form-control-label">Referans id</label>
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
