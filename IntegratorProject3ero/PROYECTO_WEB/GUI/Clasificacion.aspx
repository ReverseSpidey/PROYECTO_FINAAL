<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Clasificacion.aspx.cs" Inherits="PROYECTO_WEB.GUI.Clasificacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <h1>CLASIFICACIÓN</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="">
          
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	  <h4 class="mb"><i class="fa fa-angle-right"></i> Datos</h4>
                      <form class="form-inline" role="form">
                          <div class="form-group">
                              
                              <input class="form-control" id="exampleInputEmail2" placeholder="" type="email">
                          </div>
                          <div class="form-group">
                              
                              <input class="form-control" id="exampleInputPassword2" placeholder="" type="password">
                          </div>
                        
						<!-- Standard button -->
						<button type="button" class="btn btn-theme">Guardar</button>
						<button type="button" class="btn btn-theme02">Guardar y seguir guardando</button>
						<button type="button" class="btn btn-theme03">Eliminar</button>
						<button type="button" class="btn btn-theme04">Limpiar</button>
      				
                      </form>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
          	
          	
          	
          	
		</section>
</asp:Content>
