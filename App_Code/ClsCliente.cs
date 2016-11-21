
using System;

namespace ProyectoFinal
{
	public class clsCliente
	{
        private int IdCliente;
		private String nombre;
		private String apellido;
		private long dni;
		private String domicilio;
		private long telefono;
		private int  cuenta;
		private String email;
		
		public clsCliente()
		{
		}
		
		public clsCliente(String nom, String ape, long doc, String dom, long tel, int cuen, String mail, int ic)
		{
            this.IdCliente = ic;
            this.nombre=nom;
			this.apellido=ape;
			this.dni=doc;
			this.domicilio=dom;
			this.telefono=tel;
			this.cuenta=cuen;
			this.email=mail;
		}
		
		public String Nombre{
			set{this.nombre=value;}
			get{return this.nombre;}
		}
		
		public String Apellido{
			set{this.apellido=value;}
			get{return this.apellido;}
		}
		
		public long Dni{
			set{this.dni=value;}
			get{return this.dni;}
		}
		
		public String Domicilio{
			set{this.domicilio=value;}
			get{return this.domicilio;}
		}
		
		public long Telefono{
			set{this.telefono=value;}
			get{return this.telefono;}
		}
		
		public int Cuenta{
			set{this.cuenta=value;}
			get{return this.cuenta;}
		}
		
		public String Email{
			set{this.email=value;}
			get{return this.email;}
		}	
        public int idcli
        {
            set { IdCliente = value; }
            get { return IdCliente;  }
        }	
		
		public int Tamaño //tamaño del registro Persona
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return Nombre.Length*2 + Apellido.Length*2 + 8 + Domicilio.Length*2 + 8 + 4 +4 + Email.Length*2 ; }
  		}
		
	}
}
