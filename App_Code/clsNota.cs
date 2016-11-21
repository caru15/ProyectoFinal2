using System;

namespace ProyectoFinal
{
	public class clsNota
	{
		//NATIVE
		
		private int idNota;
		private String tipo;
		private double monto;
		private DateTime fecha;
		//private String fecha;
		
		//CONSTRUCTOR
		
		public clsNota()
		{
		}
		
		public clsNota(int id, String tip, double mon, DateTime fec)
		{
			this.IdNota=id;
			this.Tipo=tip;
			this.Monto=mon;
			this.Fecha=fec;
		}
		
		//PROPERTIES
		
		public int IdNota
        {
			set{this.idNota=value;}
			get{return this.idNota;}
		}
		
		public String Tipo
        {
			set{this.tipo=value;}
			get{return this.tipo;}
		}
		
		public double Monto
        {
			set{this.monto=value;}
			get{return this.monto;}
		}
		
		public DateTime Fecha
        {
			set{this.fecha=value;}
			get{return this.fecha;}
		}
        	
		public int Tamaño //tamaño del registro Notas
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return 4 + Tipo.Length*2 + 16 + 8 ; }
  		}
  		
		
	}
}
