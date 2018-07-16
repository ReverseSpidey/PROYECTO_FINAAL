<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="wfrmCatPelicula.aspx.cs" Inherits="PROYECTO_WEB.GUI.wfrmCatPelicula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="row">
      <div class="col-md-8">
          <asp:Label ID="lblPelicula" runat="server" Text="Administrar Películas"></asp:Label>
      </div>
      <div class="col-md-4">
          <asp:Button ID="btnNuevo" runat="server" Text="Nueva Película" />                   
      </div>

</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb"><i class="fa fa-angle-right"></i> Buscar Película</h4>
                      <form class="form-inline" role="form">
                          
                          <div class="form-group">
                              <asp:DropDownList ID="dptPelículas" Width ="40%" CssClass="form-control" runat="server" DataTextField="nombre_pelicula" DataValueField="id_pelicula"></asp:DropDownList>
                              <asp:GridView ID="dgvPeliculas" CssClass="table table-bordered bs-table" runat="server"></asp:GridView>

                          </div>
                        
						<!-- Standard button -->
<%--						<button type="button" ID ="btnSexy" class="btn btn-theme" runat ="server">CLICKKK</button>
						<button type="button" class="btn btn-theme02">Guardar y seguir guardando</button>
						<button type="button" class="btn btn-theme03">Eliminar</button>
						<button type="button" class="btn btn-theme04">Limpiar</button>--%>
      				
                      </form>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
    </asp:Content>
