<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Adminiletisim.aspx.cs" Inherits="CvEntityCore.Adminiletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table class="table table-bordered">
        <tr>
            <th>İD</th>
            <th>AD SOYAD</th>
            <th>MAİL</th>
            <th>KONU</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("id")%></td>
                    <td><%#Eval("AdSoyad")%></td>
                    <td><%#Eval("Mail")%></td>
                    <td><%#Eval("Konu")%></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"AdminiletisimDetay.aspx?id="+Eval("id")%>' CssClass="btn btn-danger">Mesaj Detay</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
