<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="MalzemeKategori.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-3">
            </div>
            <div class="col-lg-6">
                <div class="card">
                    <div class="card-header">
                        <strong>Malzeme Kategori Ekleme</strong>
                    </div>
                    <div class="card-body card-block">
                        <div class="has-success form-group">
                            <label for="inputIsValid" class=" form-control-label">Kategori İsmi</label>
                            <input type="text" id="txt_Kategori" runat="server" class="is-valid form-control-success form-control">
                        </div>
                        <div class="form-actions form-group">
                            <asp:Button ID="Ekle" runat="server" OnClick="Ekle_Click" class="btn btn-primary btn-sm" Text="Ekle" />

                        </div>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-lg-3">
            </div>
        </div>
         <asp:GridView ID="GridView1" CssClass="container" runat="server"></asp:GridView>
    </div>


</asp:Content>
