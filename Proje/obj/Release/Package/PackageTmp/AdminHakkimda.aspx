<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHakkimda.aspx.cs" Inherits="CvEntityCore.AdminHakkimda1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>İD</th>
            <th>AD SOYAD</th>
            <th>EĞİTİM</th>
            <th>DENEYİMLERİM</th>
            <th>İLETİŞİM AÇIKLAMA</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("id")%></td>
                    <td><%#Eval("AdSoyad")%></td>
                    <td><%#Eval("Egitim")%></td>
                    <td><%#Eval("isDeneyimlerim")%></td>
                    <td><%#Eval("iletisimAciklama")%></td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"AdminHakkimdaGuncelle.aspx?id="+Eval("id")%>' CssClass="btn btn-success">Güncelle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
