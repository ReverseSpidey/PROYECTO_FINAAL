<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="wfrmCatPelicula.aspx.cs" Inherits="PROYECTO_WEB.GUI.wfrmCatPelicula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <div class="row">
      <div class="col-lg-12">
          <asp:Label ID="lblPelicula" runat="server" Text="Administrar Películas" Font-Size="Medium"></asp:Label>
      </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb"><i class="fa fa-angle-right"></i> Buscar Película</h4>
                          <div class="well well-lg">
                              <div class="row">
                                  <div class="col-xl-8">
                                    <asp:DropDownList ID="dptPelículas" Width ="40%" Height="100%" CssClass="form-control " runat="server" DataTextField="nombre_pelicula" DataValueField="id_pelicula" Font-Size="Medium"></asp:DropDownList>
                                  </div>
                                  <div class="col-xl-4">
                                      <asp:Button ID="btnNuevaPelicula" runat="server" class="btn btn-success" Text="Nueva Película" Font-Size="Medium" />
                                  </div>
                              </div>
                          </div>
          			</div><!-- /form-panel -->
                     <div class="panel panel-primary">
                              <div class="panel-heading">Resultados</div>
                              <div class ="panel-body">
                                        <asp:GridView ID="gvPelículas" AutoGenerateColumns ="False" HorizontalAlign="Center" Width="100%" runat="server" DataKeyNames="Id_pelicula" CssClass="table table-bordered bs-table" Font-Size="Medium" OnRowCommand="SeleccionarPelicula">
                                  <Columns>
                                      <asp:BoundField DataField="id_pelicula" HeaderText="id_pelicula" />
                                      <asp:BoundField DataField="nombre_pelicula" HeaderText="Película" />
                                      <asp:BoundField DataField="nom_clasif" HeaderText="Clasificación" />
                                      <asp:BoundField DataField="nom_genero" HeaderText="Género" />
                                      <asp:BoundField DataField="nom_idioma" HeaderText="Idioma" />
                                      <asp:BoundField DataField="Sinopsis" HeaderText="Sinopsis" />
                                      <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-secondary btn-lg" Text="Editar" CommandName="Editar" />
                                  </Columns>
                              </asp:GridView>

                              </div>
                          </div>


          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
    </asp:Content>
