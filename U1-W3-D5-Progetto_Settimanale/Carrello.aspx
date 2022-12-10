<%@ Page Title="" Language="C#" MasterPageFile="~/TemplateSite.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="U1_W3_D5_Progetto_Settimanale.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row d-flex flex-wrap gap-5 justify-content-around align-content-center">
            <asp:Repeater runat="server" ID="Repeater_Cart" ItemType="U1_W3_D5_Progetto_Settimanale.WebForm1.Products">
                <ItemTemplate>
                    <div class="card d-flex " style="width: 18rem;">
                        <asp:Image ImageUrl="<%#Item.urlImage %>" runat="server" ID="imgProduct" CssClass="card-img-top" />
                        <div class="card-body">
                            <h5 class="card-title" runat="server" id="titleProduct"><%#Item.Name %></h5>
                            <p>Model: <%#Item.Model %></p>
                            <p>Price: <%#Item.Price %></p>
                            <p class="card-text" id="descProduct">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <%--<asp:Button Text="Detail of product" runat="server" ID="Btn_DetailProduct" OnClick=$"Btn_DetailProduct_Click({<%#Item.IdProducts %>})" CssClass="btn btn-primary"/> --%>                      
                            <a href="DetailProduct.aspx?idproduct=<%#Item.IdProducts %>">Detail of Product</a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
