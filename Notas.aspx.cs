using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoFinal;

public partial class Notas : System.Web.UI.Page
{
    private ListaNotas l_notas;
    private int i = 0;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        l_notas = new ListaNotas(Server.MapPath(@"~/Archivos/Notas.bin"));
        l_notas.CerrarFichero();
    }
    protected void Unnamed14_Click(object sender, EventArgs e) //boton
    {
        l_notas.AbrirFichero(Server.MapPath(@"~/Archivos/Notas.bin"));
        clsNota obj = new clsNota(i+1, Convert.ToString(TipoNota.Text), Convert.ToDouble(Monto.Text), Convert.ToDateTime(Fecha.Text));
        l_notas.AgregarRegistro(obj);
        l_notas.CerrarFichero();
    }
    protected void TipoNota_TextChanged(object sender, EventArgs e) //Tipo de Nota
    {

    }
    protected void Monto_TextChanged(object sender, EventArgs e) //Monto
    {

    }

    protected void Fecha_TextChanged(object sender, EventArgs e) //Fecha
    {

    }
}