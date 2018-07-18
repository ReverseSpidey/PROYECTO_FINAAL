<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="GeneroPrincipal.aspx.cs" Inherits="PROYECTO_WEB.GUI.GeneroPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <div class="row">
      <div class="col-lg-12">
          <asp:Label ID="lblGenero" runat="server" Text="Registrar Generos" Font-Size="Medium"></asp:Label>
      </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb"><i class="fa fa-angle-right"></i> Buscar Tipo de Genero</h4>
                          <div class="well well-lg">
                              <div class="row">
                                  <div class="form-group col">
                                 <h5><label>Género</label></h5><%--primero van los titulos--%>
                            <asp:TextBox ID="txtTurno" class="form-control" runat="server"></asp:TextBox>            
                                </div>
                              </div>

                                  <div class="col-xl-4">
                                      <asp:Button ID="btnBuscar" runat="server" class="btn btn-success" Text="Buscar" Font-Size="Medium" /> 
                                      <asp:Button ID="btnNuevo" runat="server" class="btn btn-success" Text="Nuevo" Font-Size="Medium" />                             
                                  </div>
                    </div>
                 </div>
       </div>
        </div>

        <br/>
        <br />
        <div>
             <div class="panel panel-primary">
                              <div class="panel-heading">Resultados</div>
                              <div class ="panel-body">
                                        <asp:GridView ID="gvGenero" AutoGenerateColumns ="False" HorizontalAlign="Center" Width="100%" runat="server" DataKeyNames="ID_genero" CssClass="table table-bordered bs-table" Font-Size="Medium" OnRowCommand="SeleccionarGenero" >
                                  <Columns>
                                      <asp:BoundField DataField="ID_genero" HeaderText="Id genero" />
                                      <asp:BoundField DataField="nombre_gen" HeaderText="Nombre del genero" />
                                     
                                      
                                      <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-secondary btn-lg" Text="Editar" CommandName="Editar" />
                                  </Columns>
                              </asp:GridView>

                              </div>
                          </div>


          		</div><!-- /col-lg-12 -->
        </div>
</asp:Content>
