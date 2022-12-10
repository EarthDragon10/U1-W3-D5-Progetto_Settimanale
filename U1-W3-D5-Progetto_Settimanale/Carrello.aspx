<%@ Page Title="" Language="C#" MasterPageFile="~/TemplateSite.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="U1_W3_D5_Progetto_Settimanale.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"> 
    <link href="StyleSheet2.css" rel="stylesheet" />
    <style>
        /*.item-cart {
            border: solid grey 1px;
            box-shadow: 4px 4px 4px grey;
        }*/
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container d-flex flex-column justify-content-center align-content-center align-items-center gap-3">
        <div class="row d-flex gap-3 flex-column justify-content-center align-content-center">
            <asp:Repeater runat="server" ID="Repeater_Cart" ItemType="U1_W3_D5_Progetto_Settimanale.WebForm1.Products">
                <ItemTemplate>
                    <div class="border shadow p-2 align-items-center" runat="server">

                                <span id="titleProduct" class="fw-bold" runat="server"><%#Item.Name %></span>
                                <span runat="server"> <%#Item.Model %></span>
                                <span runat="server" class="text-danger"><%#Item.Price %> $</span>
             
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <asp:Label Text="Tot:" CssClass="fw-bold" runat="server" ID="TotalCart" />
         <asp:Button Text="Svuota carrello" OnClick="Clear_Click" runat="server" CssClass="btn btn-primary " PostBackUrl="~/Carrello.aspx" />
    </div>
</asp:Content>
