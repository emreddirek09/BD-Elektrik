<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-header">
                        <strong>Müşteri Yorumları</strong>
                    </div>
                    <div class="card-body card-block">
                        <div class="row form-group">
                            <asp:GridView CssClass=" container" ID="GridView1" runat="server"></asp:GridView>
                        </div>
                    </div>
                </div>
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
                        <strong>Yorum Sil</strong>
                    </div>
                    <div class="card-body card-block">
                        <div class="has-success form-group">
                            <label for="inputIsValid" class=" form-control-label">Yorum id</label>
                            <input type="text" id="Katid" runat="server" class="is-valid form-control-success form-control">
                        </div>
                        <div class="form-actions form-group">
                            <asp:Button ID="sil" OnClick="sil_Click" runat="server" class="btn btn-primary btn-sm" Text="Sil" />
                        </div>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-lg-3">
            </div>
        </div>
    </div>
</asp:Content>
