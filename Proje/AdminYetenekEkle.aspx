<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYetenekEkle.aspx.cs" Inherits="CvEntityCore.AdminYetenekEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
         <asp:TextBox ID="TxtYetenek" runat="server" CssClass="form-control" placeholder="Yeni Yetenek Girin"></asp:TextBox>
        <br />
        <asp:Button ID="BtnYetenekEkle" runat="server" CssClass="btn btn-info" Text="Yetenek Ekle" OnClick="BtnYetenekEkle_Click" />
    </form>

</asp:Content>
