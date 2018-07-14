<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="TIPOBOLETO.aspx.cs" Inherits="PROYECTO_WEB.GUI.TIPOBOLETO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <h1>TIPO BOLETO</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <section class="">
          
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb"><i class="fa fa-angle-right"></i> Datos</h4>
                      
                         <div class="form-group">
                              <label class="col-sm-2 control-label col-lg-2" for="inputWarning">ID</label>
                            <asp:TextBox ID="txtID" runat="server" Width="784px"></asp:TextBox>  
                          </div>
                        

                          <div class="form-group">
                              <label class="col-sm-2 control-label col-lg-2" for="inputWarning">Tipo de boleto</label>
                            <asp:TextBox ID="txtBOLETO" runat="server" Width="784px"></asp:TextBox>  
                          </div>
                          
						<!-- Standard button -->
						<asp:Button ID="btnGuardar" runat="server" Text="Guardar" BackColor="#CC3300" ForeColor="White" />
						<asp:Button ID="btnGuardarYSeguirGuardando" runat="server" Text="Guardar y seguir " BackColor="#CC3300" ForeColor="White" />
						<asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" BackColor="#CC3300" ForeColor="White" />
						<asp:Button ID="bntEliminar" runat="server" Text="Eliminar" BackColor="#CC3300" ForeColor="White" />
      				
                      
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
          	
          	
          	
          	
		</section>
</asp:Content>
