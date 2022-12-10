<%@ Page Title="" Language="C#" MasterPageFile="~/TemplateSite.Master" AutoEventWireup="true" CodeBehind="DetailProduct.aspx.cs" Inherits="U1_W3_D5_Progetto_Settimanale.WebForm3" EnableEventValidation="true"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
        <div class="row d-flex flex-wrap gap-5 justify-content-around align-content-center">

                    <div class="card d-flex " style="width: 18rem;">
                        <asp:Image ImageUrl="" runat="server" ID="imgProduct" CssClass="card-img-top" />
                        <div class="card-body">
                            <h5 class="card-title" runat="server" id="titleProduct"></h5>
                            <p runat="server" id="txtModel">Model: </p>
                            <p runat="server" id="txtPrice">Price: </p>
                            <p class="card-text" id="descProduct" runat="server">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="Default.aspx" CssClass="btn btn-primary">Home Page</a>                         
                        </div>
                    </div>
                
        </div>
    </div>
</asp:Content>
