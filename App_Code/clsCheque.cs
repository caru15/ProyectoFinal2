/*
 * Created by SharpDevelop.
 * User: JORGE
 * Date: 9/11/2016
 * Time: 1:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProyectoFinal
{
	public class clsCheque
	{
		
		private int idCheque;
		private DateTime fechaEmision;
		private double monto;
		private String moneda;
        private bool estado; //true si el cheque activo y false si el cheque est inactivo
		
		public clsCheque()
		{
		}
		
		public clsCheque(int id, DateTime fEmision, double mont, String mone, bool es)
		{
			this.IdCheque=id;
			this.FechaEmision=fEmision;
			this.Monto=mont;
			this.Moneda=mone;
            this.estado = true;
		}
		
		public int IdCheque{
			set{this.idCheque=value;}
			get{return this.idCheque;}
		}
		
		public DateTime FechaEmision{
			set{this.fechaEmision=value;}
			get{return this.fechaEmision;}
		}
		
		public double Monto{
			set{this.monto=value;}
			get{return this.monto;}
		}
		
		public String Moneda{
			set{this.moneda=value;}
			get{return this.moneda;}
		}

        public bool Esta
        {
            set { estado = value; }
            get { return estado; }
        }
		
		public int Tamaño //tamaño del registro Persona
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return (4 + 8 + 16 + Moneda.Length*2 +1) ; }
  		}
  		
	}
}