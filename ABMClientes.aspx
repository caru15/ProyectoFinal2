<%@ Page Title="Cliente" Language="C#" AutoEventWireup="true" CodeFile="ABMClientes.aspx.cs" Inherits="ABMClientes" MasterPageFile="~/Site.master" %>
 <%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %></h2>

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                 <hr />
                <div class="form-horizontal">
                   
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="IdCliente" CssClass="col-md-2 control-label">Id Cliente</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="IdCliente" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="IdCliente" CssClass="text-danger" ErrorMessage="The password field is required." />
                        </div>
                    </div>
                  <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Nombre" CssClass="col-md-2 control-label">Nombre</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Nombre" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Nombre"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Apellido" CssClass="col-md-2 control-label">Apellido</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Apellido" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Apellido"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="dni" CssClass="col-md-2 control-label">DNI</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="dni" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="dni"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="domicilio" CssClass="col-md-2 control-label">Domicilio</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="domicilio" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="domicilio"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="tel" CssClass="col-md-2 control-label">Telefono</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="tel" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="tel"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="cuenta" CssClass="col-md-2 control-label">Numero de Cuenta</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="cuenta" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="cuenta"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="email" CssClass="col-md-2 control-label">E-mail</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="email" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="email"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="Alta" Text="Alta" CssClass="btn btn-default" />
                          
                            <asp:Button runat="server" OnClick="Baja" Text="Baja" CssClass="btn btn-default" />
                            <asp:Button runat="server" OnClick="Modificacion" Text="Modificar" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
              
            </section>
        </div>
    </div>
        </div>
</asp:Content>

