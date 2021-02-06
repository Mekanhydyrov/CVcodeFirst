<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYetenekGuncelle.aspx.cs" Inherits="CvEntityCore.AdminYetenekGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <asp:TextBox ID="Txtid" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtYetenekGuncelle" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="BtnYetenekGuncelle" runat="server" CssClass="btn btn-info" Text="Yetenek Güncelle" OnClick="BtnYetenekGuncelle_Click" />
    </form>

</asp:Content>
