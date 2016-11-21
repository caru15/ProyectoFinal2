using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ClsMovimiento
{
    private DateTime Fecha;
    private string Tipo;// si es pago o cobro
    private string ModoDePago;//Efectivo, tRansferencia Bancaria
    private string Moneda;//si es moneda extranjera o peso argentino
    private double Monto;
    private int idFactura;

    public ClsMovimiento(){}

    public ClsMovimiento(DateTime dia, string type, string mp, string mon, double monto, int IF)
    {
        this.Fecha = dia;
        this.Tipo = type;
        this.ModoDePago = mp;
        this.Moneda = mon;
        this.Monto = monto;
        this.idFactura = IF;
    }
    public DateTime SGFecha
    {
        set { this.Fecha = value; }
        get { return Fecha; }
    }
    public string SGTipo
    {
        set { this.Tipo = value;}
        get { return this.Tipo; }
    }
    public string SGModoPago
    {
        set { this.ModoDePago = value; }
        get { return ModoDePago; }
    }
    public string SGMoneda
    {
        set { this.Moneda = value; }
        get { return this.Moneda; }
    }
    public double SGMonto
    {
        set { this.Monto = value; }
        get { return Monto; }
    }
    public int SGIdFac
    {
        set { this.idFactura = value; }
        get { return idFactura; }
    }
    public int TamMovimiento
    {
        get { return (8+Tipo.Length*2+ModoDePago.Length*2+Moneda.Length*2+8+8); }
    }
}