using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoFinal;

public partial class Facturas : System.Web.UI.Page
{
    private ListaFactura lista;

    protected void Page_Load(object sender, EventArgs e)
    {
        lista = new ListaFactura(Server.MapPath(@"~/Archivos/Facturas.bin"));
        lista.CerrarFichero();
    }

    protected void ComboCliente_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Unnamed14_Click(object sender, EventArgs e)
    {
        lista.abrirFichero(Server.MapPath(@"~/Archivos/Facturas.bin"));
        clsFactura obj = new clsFactura(1, Convert.ToDateTime(FechaEmi.Text), Convert.ToDateTime(FechaCobro.Text), "Propia", ComboModo.Text, 1, 1,1);
        lista.agregarRegistro(obj);
        Notas.Text = Convert.ToString(lista.Registro);
        lista.CerrarFichero();
        
    }
}