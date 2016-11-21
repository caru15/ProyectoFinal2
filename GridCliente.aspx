<%@ Page Title="Cliente"Language="C#" AutoEventWireup="true" CodeFile="GridCliente.aspx.cs" Inherits="GridCliente" MasterPageFile="~/Site.master"%>

 <%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>
        <asp:GridView ID="GrillaCliente" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="203px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="494px">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </h2>

    
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">     
                            <asp:Button runat="server" OnClick="Baja" Text="Baja" CssClass="btn btn-default" />
                            <asp:Button runat="server" OnClick="Modificacion" Text="Modificar" CssClass="btn btn-default" />
                        </div>
                    </div>
          
              
          
</asp:Content>
