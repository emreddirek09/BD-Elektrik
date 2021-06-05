<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Kayitlar.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-header">
                        <strong>Müşteri Kayıtları</strong>
                    </div>
                    <div class="card-body card-block text-center">
                        <div class="row form-group">
                            <asp:GridView CssClass=" container" ID="GridView1" runat="server"></asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
