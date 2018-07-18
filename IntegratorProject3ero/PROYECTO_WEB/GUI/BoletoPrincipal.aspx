<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="BoletoPrincipal.aspx.cs" Inherits="PROYECTO_WEB.GUI.BoletoPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="row">
      <div class="col-lg-12">
          <asp:Label ID="lblTipoboleto" runat="server" Text="Registrar Boletos" Font-Size="Medium"></asp:Label>
      </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb"><i class="fa fa-angle-right"></i> Buscar tipo de boleto</h4>
                          <div class="well well-lg">
                              <div class="row">
                                  <div class="form-group col">
                                 <label><h5>Tipos de boletos</h5></label>
                            <asp:TextBox ID="txtTurno" class="form-control" runat="server"></asp:TextBox>            
                                </div>
                              </div>

                                  <div class="col-xl-4">
                                      <asp:Button ID="btnBuscar" runat="server" class="btn btn-success" Text="Buscar" Font-Size="Medium" /> 
                                      <asp:Button ID="btnNuevo" runat="server" class="btn btn-success" Text="Nuevo" Font-Size="Medium" OnClick="btnNuevo_Click" />                             
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
                                        <asp:GridView ID="gvTipoBoleto" AutoGenerateColumns ="False" HorizontalAlign="Center" Width="100%" runat="server" DataKeyNames="id_tipoBoleto" CssClass="table table-bordered bs-table" Font-Size="Medium" OnRowCommand="Seleccionar" >
                                  <Columns>
                                      <asp:BoundField DataField="id_tipoBoleto" HeaderText="Id Tipo de Boleto" /><%--El datakeyname va el nombre de nuestra tabla--%>
                                      <asp:BoundField DataField="nombre_tipo" HeaderText="Tipo de Boleto" />
                                      <asp:BoundField DataField="Precio_tipo" HeaderText="Precio" />
                                      
                                      <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-secondary btn-lg" Text="Editar" CommandName="Editar" />
                                  </Columns>
                              </asp:GridView>

                              </div>
                          </div>


          		</div><!-- /col-lg-12 -->
        </div>
</asp:Content>
