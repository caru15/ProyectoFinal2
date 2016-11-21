<%@ Page Title="Notas" Language="C#"  MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Notas.aspx.cs" Inherits="Notas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Nueva Nota</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TipoNota" CssClass="col-md-2 control-label">Tipo Nota</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TipoNota" CssClass="form-control" OnTextChanged="TipoNota_TextChanged" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TipoNota"
                    CssClass="text-danger" ErrorMessage="Se requiere el Tipo de Nota." />
            </div>
        </div>   
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Monto" CssClass="col-md-2 control-label">Monto</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Monto" CssClass="form-control" OnTextChanged="Monto_TextChanged" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Monto"
                    CssClass="text-danger" ErrorMessage="Se requiere el Monto de la Nota" />
            </div>
        </div>   
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Fecha" CssClass="col-md-2 control-label">Fecha</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Fecha" CssClass="form-control" OnTextChanged="Fecha_TextChanged" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Fecha"
                    CssClass="text-danger" ErrorMessage="Se requiere Fecha de Nota" />
            </div>
        </div> 
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server"  Text="Registrar Nota" CssClass="btn btn-small btn-success" ID="btnRegistro" OnClick="Unnamed14_Click" OnClientClick="Registrar" />
            </div>
        </div>
      </div>
</asp:Content>