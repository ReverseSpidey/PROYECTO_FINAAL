<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/IndexMaster.Master" AutoEventWireup="true" CodeBehind="wfrmPrueba.aspx.cs" Inherits="CinexcesoWeb.GUI.wfrmPrueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CarteleraSmall" runat="server">
    
    <asp:Repeater ID="RptPeliculas" runat="server" >
        <HeaderTemplate>
             <div class="row">
        </HeaderTemplate>
        <ItemTemplate>
                <div class="col-md-4">
                        <div class="contenedor">
                            <div class="imagen">
                                <img class="imagen" src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[])DataBinder.Eval(Container.DataItem,"imagen_pelicula"))%>" />
                             <h3 class="nomPeli"><asp:Label ID="lblNombre_peli" runat="server" Text=<%# Eval("nombre_pelicula") %>></asp:Label></span></h3>
                            </div>

                            <div class="info">
                                <%--<p class="titulo">AQUI BOTON</p> --%>                          
                                <a class="link" href="#">
                                    <asp:LinkButton CssClass="btn btn-info" ID="btnFuncion" CommandName="verFuncion" CommandArgument='<%# Eval("id_pelicula") %>' runat="server" Font-Size="Medium">Ver Funciones</asp:LinkButton>
                                    </a>
                                <a class="Sinopsis" href="#">
                                    <asp:Button ID="btnSinopsis" CssClass="btn btn-info" runat="server" Text="Ver Sinopsis" Font-Size="Medium" CommandName="Sinopsis" /></a>

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
