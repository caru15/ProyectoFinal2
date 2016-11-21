using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ClsMoveRecu : ClsMovimiento
{
    private DateTime fechaIni;//fecha de inicio del movimiento recurrente
    private byte FrecFac;//frecuencia de facturacion 
    private byte PlazoEjec; //cant de dias que seva a realizar el cobro o pago
    //en consecuencia de un movimiento recurrente se genera una factura eventual correspondiente

    public ClsMoveRecu(DateTime dia, string type, string mp, string mon, double monto, int IF,DateTime fechaIni,byte ff,byte pe): base(dia, type, mp, mon, monto, IF)
    {
        this.fechaIni = fechaIni;
        this.FrecFac = ff;
        this.PlazoEjec = pe; 
    }
    public DateTime SGFechaIni {
    set { this.fechaIni = value; }
    get { return fechaIni; } }

    public byte SGFrecuenciaFac {
    set { this.FrecFac = value; }
    get { return FrecFac; } }

    public byte SGPlazoEjec {
    set { this.PlazoEjec = value; }
    get { return PlazoEjec; } }

    public int TamMovRec {
    get { return (8+2); } }

  
}