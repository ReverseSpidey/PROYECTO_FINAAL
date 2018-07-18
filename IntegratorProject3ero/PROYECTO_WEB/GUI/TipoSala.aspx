<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="TipoSala.aspx.cs" Inherits="PROYECTO_WEB.GUI.TipoSala" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="row">
      <div class="col-lg-12">
          <asp:Label ID="lblTipoSala" runat="server" Text="Registrar peliculas" Font-Size="Medium"></asp:Label>
      </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         

    <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb"><i class="fa fa-angle-right"></i> Buscar Tipo de Sala</h4>
                          <div class="well well-lg">
                              <div class="row">
                                  <div class="form-group col">
                                <h5><label>Tipo sala</label></h5> 
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
                                        <asp:GridView ID="gvTipoSala" AutoGenerateColumns ="False" HorizontalAlign="Center" Width="100%" runat="server" DataKeyNames="Cod_sala" CssClass="table table-bordered bs-table" Font-Size="Medium" >
                                  <Columns>
                                      <asp:BoundField DataField="Cod_sala" HeaderText="Codigo de sala" />
                                      <asp:BoundField DataField="Nombre_sala" HeaderText="Nombre de sala" />
                                      <asp:BoundField DataField="Precio" HeaderText="Precio" />
                                      
                                      <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-secondary btn-lg" Text="Editar" CommandName="Editar" />
                                  </Columns>
                              </asp:GridView>

                              </div>
                          </div>


          		</div><!-- /col-lg-12 -->
        </div>
   
</asp:Content>
