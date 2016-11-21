using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using ProyectoFinal;


public class ManejaCuenta
{
    private int TR = 110;
    private int NR;
    private FileStream fs;
    private BinaryWriter bw;
    private BinaryReader br;

    public ManejaCuenta(string Nom)
    {
        AbrirFichero(Nom);
    }
    public void AbrirFichero(string fichero)
    {
        if (Directory.Exists(fichero))
            throw new IOException(Path.GetFileName(fichero) + " no es un fichero.");
        this.fs = new FileStream(fichero, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        this.bw = new BinaryWriter(fs);
        this.br = new BinaryReader(fs);
    }

    public void CerrarFichero() { fs.Close(); bw.Close(); br.Close(); }

    public bool EscribirRegistro(int i, ClsCuenta cuent)
    {
        try
        {
            if (i >= 0 && i <= NR)
            {
                if (cuent.TamCuenta + 4 > TR)
                {
                    Console.WriteLine("Tamaño de registro excedido.");
                    return false;
                }
                else
                {
                    bw.BaseStream.Seek(i * this.TR, SeekOrigin.Begin);
                    bw.Write(cuent.SGFondosDolares);
                    bw.Write(cuent.SGFondoPesos);
                    bw.Write(cuent.SGDepBanc);
                    bw.Write(cuent.SGCheqCobrados);
                    bw.Write(cuent.SGCheqDebitados);
                    bw.Write(Convert.ToString(cuent.SGFecha));
                    return true;
                }
            }
            else { return false; }
        }
        catch (IOException e) { CerrarFichero(); Console.WriteLine(e.Message); return false; }
    }
    public void AgregarRegistro(ClsCuenta cuenta)
    {
        if (EscribirRegistro(this.NR, cuenta))
            this.NR++;
    }

    public int NumReg()
    {
        return this.NR;
    }

    public ClsCuenta LeerRegistro(int i)//lee registro mandandole la posicion en el fichero
    {
        try
        {
            if (i >= 0 && i < NumReg())
            {
                br.BaseStream.Seek(i * this.TR, SeekOrigin.Begin);
                double fondoDol = br.ReadDouble();
                double fondoPe = br.ReadDouble();
                double DepositoBan = br.ReadDouble();
                double CheCob = br.ReadDouble();
                double CheDeb = br.ReadDouble();
                DateTime fec = Convert.ToDateTime(br.ReadString());
                return (new ClsCuenta(fondoDol, fondoPe, DepositoBan, CheCob, CheDeb, fec));
            }
            else { return null; }
        }
        catch (IOException e) { CerrarFichero(); return null; }
    }

    public bool ModificarReg(int pos)
    {
        try
        {
            ClsCuenta nuevaCuenta = LeerRegistro(pos);
            EscribirRegistro(pos, nuevaCuenta); return true;
        }
        catch (IOException e) { CerrarFichero(); return false; }
    }
}