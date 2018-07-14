<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="TIPOBOLETOPRINCIPAL.aspx.cs" Inherits="PROYECTO_WEB.GUI.TIPOBOLETOPRINCIPAL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h1>TIPO DE BOLETO</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" BackColor="#CC3300" ForeColor="White" />
						<asp:Button ID="btnBuscar" runat="server" Text="Buscar " BackColor="#CC3300" ForeColor="White" />
    <br />
     <div class="form-group">
         <br />
                              <label class="col-sm-2 control-label col-lg-2" for="inputWarning">Tipo de sala</label>
                            <asp:TextBox ID="txtSala" runat="server" Width="533px"></asp:TextBox>  
                          </div>

    <div class="row">
    <div class="col-md-12">
    <asp:GridView ID="gvResultado" runat="server" CellPadding="4" DataKeyNames="id_clasif" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" Width="80%" AutoGenerateColumns="False" OnRowCommand="gvResultado_RowCommand">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" />
            <asp:BoundField DataField="CLASIFICACIÓN" HeaderText="CLASIFICACIÓN" />
            <asp:ButtonField ButtonType="Button" CommandName="editar" Text="EDICIÓN" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
        </div>
</div>
</asp:Content>
