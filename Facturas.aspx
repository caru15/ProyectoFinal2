<%@ Page Title="Facturas" Language="C#"  MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Facturas.aspx.cs" Inherits="Facturas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal" role="form">
        <br />
        <h4>Nueva Factura.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="row">
        <div class="form-group col-md-6">
            <asp:Label runat="server" AssociatedControlID="ComboCliente" CssClass="col-md-2 control-label">Cliente</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ComboCliente" runat="server" CssClass="form-control">
                </asp:DropDownList>               
            </div>
        </div>
        <div class="form-group col-md-6">
            <asp:Label runat="server" AssociatedControlID="ComboFactura" CssClass="col-md-2 control-label">Tipo de Factura</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ComboFactura" runat="server" CssClass="form-control">
                </asp:DropDownList>
                
            </div>
        </div>   
        <div class="form-group col-md-6">
            <asp:Label runat="server" AssociatedControlID="Numero" CssClass="col-md-2 control-label">Numero</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Numero" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Numero"
                    CssClass="text-danger" ErrorMessage="Se requiere el número de cuenta" />
            </div>
        </div>   
          
        <div class="form-group col-md-6">
            <asp:Label runat="server" AssociatedControlID="FechaEmi" CssClass="col-md-2 control-label">Fecha Emisión</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="FechaEmi" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="FechaEmi"
                    CssClass="text-danger" ErrorMessage="Se requiere domicilio" />
            </div>
        </div>  
        <div class="form-group col-md-6">
            <asp:Label runat="server" AssociatedControlID="FechaCobro" CssClass="col-md-2 control-label">Fecha Cobro</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="FechaCobro" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="FechaCobro"
                    CssClass="text-danger" ErrorMessage="Se requiere un email válido." />
            </div>
        </div> 
        <div class="form-group col-md-6">
            <asp:Label runat="server" AssociatedControlID="ComboModo" CssClass="col-md-2 control-label">Modo</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ComboModo" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ComboModo"
                    CssClass="text-danger" ErrorMessage="Se requiere un email válido." />
            </div>
        </div> 
        <div class="form-group col-md-6">
            <asp:Label runat="server" AssociatedControlID="Monto" CssClass="col-md-2 control-label">Monto</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Monto" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Monto"
                    CssClass="text-danger" ErrorMessage="Se requiere un email válido." />
            </div>
        </div> 
        <div class="form-group col-md-6">
            <asp:Label runat="server" AssociatedControlID="Notas" CssClass="col-md-2 control-label">Notas</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Notas" CssClass="form-control" />
               
            </div>
        </div> 
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server"  Text="Buscar" CssClass="btn btn-small btn-success" ID="btnRegistro" OnClick="Unnamed14_Click" OnClientClick="Registrar" />
                <asp:Button runat="server"  Text="Registrar" CssClass="btn btn-small btn-success" ID="Button1" OnClick="Unnamed14_Click" OnClientClick="Registrar" />
                <asp:Button runat="server"  Text="Agregar Nota" CssClass="btn btn-small btn-success" ID="Button2" OnClick="Unnamed14_Click" OnClientClick="Registrar" />
            </div>
        </div>
    </div>
  </div>
</asp:Content>