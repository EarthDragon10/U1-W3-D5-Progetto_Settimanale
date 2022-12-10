<%@ Page Title="" Language="C#" MasterPageFile="~/TemplateSite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="U1_W3_D5_Progetto_Settimanale.WebForm1"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <div class="row d-flex flex-wrap gap-5 justify-content-around align-content-center">
            <asp:Repeater runat="server" ID="RepeaterProduct" ItemType="U1_W3_D5_Progetto_Settimanale.WebForm1.Products">
                <ItemTemplate>
                    <div class="card shadow d-flex p-2 card-product" style="width: 18rem;">
                        <div><asp:Image ImageUrl="<%#Item.urlImage %>" runat="server" ID="imgProduct" CssClass="card-img-top" /></div>
                        <div class="card-body">
                            <h3 class="card-title" runat="server" id="titleProduct"><%#Item.Name %></h3>
                            <p class="txtItalic">Model: <%#Item.Model %></p>
                            <p class="txt-price">Price: <%#Item.Price %></p>
                            <p class="card-text" id="descProduct">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                                               
                            <a href="DetailProduct.aspx?idproduct=<%#Item.IdProducts %>">Detail of Product</a>
                            <asp:Button Text="Aggiungi Carrello" CommandArgument="<%#Item.IdProducts %>" OnClick="Unnamed_Click1" runat="server" CssClass="btn btn-primary"/>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
            
    
</asp:Content>
