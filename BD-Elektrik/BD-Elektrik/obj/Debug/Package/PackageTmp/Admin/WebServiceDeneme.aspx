<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="WebServiceDeneme.aspx.cs" Inherits="BD_Elektrik.Admin.WebForm9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:updatepanel runat="server" xmlns:asp="#unknown">
    <contenttemplate>
    <%-- <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick"></asp:Timer>--%>
    <label id="lbl" runat="server"> </label>
    ASMX Servis Deneme: <asp:Label ID="Label1" runat="server" ></asp:Label>   
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager><br />
     </contenttemplate>
    </asp:updatepanel>


    <%--WCF Servis Deneme:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>--%>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
