using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using ProyectoFinal;

public partial class ABMClientes : System.Web.UI.Page
{
    private ListaClientes lista;
    private int numeroReg;

    protected void Page_Load(object sender, EventArgs e)
    {
        lista = new ListaClientes(Server.MapPath(@"~/Archivos/Clientes.bin"));
        lista.CerrarFichero();
    }
    protected void Alta(object sender, EventArgs e) {
        try
        {
            lista.AbrirFichero(Server.MapPath(@"~/Archivos/Clientes.bin"));
       
            int idcli = Convert.ToInt32(IdCliente.Text);
            string nom = Nombre.Text;
            string ape = Apellido.Text;
            long Dni = long.Parse(dni.Text);
            string dom = domicilio.Text;
            long tele = long.Parse(tel.Text);
            int cue = Convert.ToInt32(cuenta.Text);
            string em = email.Text;
            clsCliente obj = new clsCliente(nom, ape, Dni, dom, tele, cue, em, idcli);
            lista.AgregarRegistro(obj);
            //numeroReg = lista.NumReg();
            lista.CerrarFichero();
        }catch(IOException er) { }
        
        
        
    }

    protected void Baja(object sender, EventArgs e)
    {

    }

    protected void Modificacion(object sender, EventArgs e)
    {

    }
}