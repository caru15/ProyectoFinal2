using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoFinal;

public partial class GridCliente : System.Web.UI.Page
{
    private ListaClientes ListaCli;

    protected void Page_Load(object sender, EventArgs e)
    {
        ListaCli = new ListaClientes(Server.MapPath(@"~/Archivos/Clientes.bin"));
    
    }

    protected void Baja(object sender, EventArgs e)
    {

    }

    protected void Modificacion(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int CantReg = ListaCli.NumReg();
        clsCliente persona;
        
   
    }
    /*private void cargarDataGrid(){
			int nregs = Prestamos.NúmeroDeRegs();
			Persona obj;
			this.dataGridView1.Columns.Add("nroPrestamo","NroPrestamo");
			this.dataGridView1.Columns.Add("nroIdentidad","NroIdentidad");
			this.dataGridView1.Columns.Add("nombre","Nombre");
			this.dataGridView1.Columns.Add("apellido","Apellido");
			this.dataGridView1.Columns.Add("telefono","Telefono");
			this.dataGridView1.Columns.Add("celular","Celular");
			this.dataGridView1.Columns.Add("monto","Monto");
			this.dataGridView1.Columns.Add("fecha","Fecha");
			
			for(int reg_i = 0; reg_i< nregs;reg_i++){
				obj = Prestamos.LeerReg(reg_i);
				//if(obj.Teléfono !=0)
					this.dataGridView1.Rows.Add(obj.Prestamos.NroPrestamo,obj.NumIdentidad,obj.Nombre,obj.Apellido,obj.Telefono,obj.Celular,obj.Prestamos.Monto,obj.Prestamos.Fecha);
			}
		}
		
		public void actualizarDataGrid(){
			int nregs = Prestamos.NúmeroDeRegs();
			Persona obj;
			
			dataGridView1.Rows.Clear();
			
			for(int reg_i = 0; reg_i< nregs;reg_i++){
				obj = Prestamos.LeerReg(reg_i);
				this.dataGridView1.Rows.Add(obj.Prestamos.NroPrestamo,obj.NumIdentidad,obj.Nombre,obj.Apellido,obj.Telefono,obj.Celular,obj.Prestamos.Monto,obj.Prestamos.Fecha);
			}
		}*/
}