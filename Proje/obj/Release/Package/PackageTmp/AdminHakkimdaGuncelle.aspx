<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHakkimdaGuncelle.aspx.cs" Inherits="CvEntityCore.AdminHakkimdaGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <strong>
        <asp:Label ID="Label1" runat="server" Text="Ad Soyad"></asp:Label>
        </strong>
        <asp:TextBox ID="TxtAdSoyad" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <strong>
        <asp:Label ID="Label6" runat="server" Text="Unvan"></asp:Label>
        </strong>
        <asp:TextBox ID="TxtUnvan" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <strong>
        <asp:Label ID="Label5" runat="server" Text="Foto Link"></asp:Label>
        </strong>
        <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
         <strong>
         <asp:Label ID="Label2" runat="server" Text="Eğitim Hayatım"></asp:Label>
        </strong>
        <asp:TextBox ID="TxtEgitim" runat="server" CssClass="form-control" Height="200px" TextMode="MultiLine"></asp:TextBox>
        <br />
         <strong>
         <asp:Label ID="Label3" runat="server" Text="İş Deneyimlerim"></asp:Label>
        </strong>
        <asp:TextBox ID="TxtisDeneyimlerim" runat="server" CssClass="form-control" Height="200px" TextMode="MultiLine"></asp:TextBox>
        <br />
         <strong>
         <asp:Label ID="Label4" runat="server" Text="İletişim Açıklama"></asp:Label>
        </strong>
        <asp:TextBox ID="TxtiletisimAciklama" runat="server" CssClass="form-control" Height="200px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="BtnGuncelle" runat="server" CssClass="btn btn-primary" Text="Hakkımda Kaydet" OnClick="BtnGuncelle_Click"/>
    </form>

</asp:Content>
