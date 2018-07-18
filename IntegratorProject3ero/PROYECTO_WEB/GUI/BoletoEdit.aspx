<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="BoletoEdit.aspx.cs" Inherits="PROYECTO_WEB.GUI.BoletoEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <div class="col-lg-12">
          <asp:Label ID="lblBoletoEdit" runat="server" Text="Editar boletos" Font-Size="Medium"></asp:Label>
      </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-row">
        <div class="form-group col-12">
            <h4><label>Nombre del boleto:</label></h4>
            <asp:TextBox ID="txtNomBoleto" class="form-control" runat="server"></asp:TextBox>            
        </div>
    </div>

    <div class="form-row">
        <div class="form-group col-12">
            <h4><label>Precio del boleto:</label></h4>
            <asp:TextBox ID="txtPrecioBoleto" class="form-control" runat="server"></asp:TextBox>            
        </div>
    </div>


    <div ">
              <asp:Button ID="btnAgregar" runat="server" class="btn btn-success" Text="Agregar" Font-Size="Medium" /> 
              <asp:Button ID="btnGuardarNext" runat="server" class="btn btn-success" Text="Agregar y seguir" Font-Size="Medium" />    
              <asp:Button ID="btnEliminar" runat="server" class="btn btn-sm btn-danger" Text="Eliminar" Font-Size="Medium" /> 
              <asp:Button ID="btnRegresar" runat="server" class="btn btn-success" Text="Regresar" Font-Size="Medium" OnClick="btnRegresar_Click" />   
                                  </div>
</asp:Content>
