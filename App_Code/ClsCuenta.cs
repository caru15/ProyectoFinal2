using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ClsCuenta
{
    private double FondoDolares;
    private double FondoPesos;
    private double DepBancario;
    private double ChequesCobrados;
    private double ChequesDebitados;
    private DateTime Fecha;


    public ClsCuenta() { }

    public ClsCuenta(double FD,double FP, double DB, double CC, double CD,DateTime fe)
    {
        this.FondoDolares = FD;
        this.FondoPesos = FP;
        this.DepBancario = DB;
        this.ChequesCobrados = CC;
        this.ChequesDebitados = CD;
        this.Fecha = fe;
    }
  
        
    public double SGFondosDolares
    {
        get { return FondoDolares; }
        set { FondoDolares = value; }
    }

    public double SGFondoPesos
    {
        get { return FondoPesos; }
        set { FondoPesos = value; }
    }
    public double SGDepBanc
    {
        get { return DepBancario; }
        set { DepBancario = value; }
    }
    public double SGCheqCobrados
    {
        get { return ChequesCobrados; }
        set { ChequesCobrados = value; }
    }
    public double SGCheqDebitados
    {
        get { return ChequesDebitados; }
        set { ChequesDebitados = value; }
    }
   public DateTime SGFecha
    {
        get { return Fecha; }
        set { this.Fecha = value; }
    }
    
    public int TamCuenta {
    get { return  ((5 * 16)+16); } }
}