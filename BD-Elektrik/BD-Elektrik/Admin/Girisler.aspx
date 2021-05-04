<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="animated fadeIn">
        <div class="row text-center">
            <div class="col-lg-2">
            </div>
            <div class="col-lg-8">
                <div class="card">
                    <div class="card-header">
                        <strong>Müşteri Girişleri</strong>
                    </div>
                    <div class="card-body card-block">
                        <div class="row form-group">
                            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-2">
            </div>
        </div>
    </div>
</asp:Content>
