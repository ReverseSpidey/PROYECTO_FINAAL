<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/IndexMaster.Master" AutoEventWireup="true" CodeBehind="wfrmPrueba.aspx.cs" Inherits="CinexcesoWeb.GUI.wfrmPrueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CarteleraSmall" runat="server">
    <asp:Repeater ID="RptPeliculas" runat="server" OnItemCommand="RptPeliculas_ItemCommand">
        <HeaderTemplate>
            <div class="row">
        </HeaderTemplate>
        <ItemTemplate>
            <div class="col-md-3">
            <div class="card-deck">
                  <div class="card">
                             <img class="card-img-top" src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"imagen_pelicula"))%>" alt="Card image cap">
                    <div class="card-body">
                      <h5 class="card-title"><asp:Label ControlID="lblPelicula" runat="server" Text='<%# Eval("nombre_pelicula") %>'></asp:Label></h5>
                      <p class="card-text"><small class="text-muted">
                          <asp:Label ID="lblSinopsis" runat="server" Text='<%# Eval("sinopsis") %>'></asp:Label></small></p>
                    </div>
                  </div>
                </div>
             </div>
                
                        <!--<p class="choose-film__title">The Fifth Estate</p>-->            
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
