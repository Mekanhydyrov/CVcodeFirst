<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminiletisimDetay.aspx.cs" Inherits="CvEntityCore.AdminiletisimDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <strong>
        <asp:Label ID="Label1" runat="server" Text="Ad Soyad"></asp:Label>
        </strong>
        <asp:TextBox ID="TxtAdSoyad" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        <br />
        <strong>
        <asp:Label ID="Label2" runat="server" Text="Mail"></asp:Label>
        </strong>
        <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
         <br />
        <strong>
        <asp:Label ID="Label3" runat="server" Text="Konu"></asp:Label>
        </strong>
        <asp:TextBox ID="TxtKonu" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
         <br />
        <strong>
        <asp:Label ID="Label4" runat="server" Text="Mesaj"></asp:Label>
        </strong>
        <asp:TextBox ID="TxtMesaj" runat="server" CssClass="form-control" Enabled="false" TextMode="MultiLine" Height="200px"></asp:TextBox>
    </form>

</asp:Content>
