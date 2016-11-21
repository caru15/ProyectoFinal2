using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using ProyectoFinal;


public class ListaCheques
{
    private FileStream fs,fst;          
    private BinaryWriter bw,bwt;        
    private BinaryReader br,brt;        
    private int nregs;              
    private int tamañoReg = 150;

    public ListaCheques(String fichero)
    {
        abrirFichero(fichero);
    }

    public int NumeroReg
    {
        get { return nregs; }
    }

    public void agregarRegistro(clsCheque obj)//agrega un registro al ultimo
    {
        if (EscribirRegistro(nregs, obj))
        {
            nregs++; }
    }

    public bool EscribirRegistro(int i, clsCheque obj)
    {
        try
        {
            if (i >= 0 && i <= NumeroReg)
            {
                if (obj.Tamaño + 4 > tamañoReg)
                {
                    Console.WriteLine("Tamaño de registro excedido.");
                    return false;
                }
                else
                {
                    bw.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
                    bw.Write(obj.IdCheque);
                    bw.Write(obj.FechaEmision.ToString());
                    bw.Write(obj.Monto);
                    bw.Write(obj.Moneda);
                    bw.Write(obj.Esta);
                   
                    return true;
                }
            }
            else { return false; }
        }
        catch (IOException e) { CerrarFichero(); Console.WriteLine(e.Message); return false; }
    }

    

    public void abrirFichero(String path)
    {  
        if (Directory.Exists(path))
            throw new IOException(Path.GetFileName(path) + " no es un fichero");
        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        bw = new BinaryWriter(fs);
        br = new BinaryReader(fs);
        nregs = (int)Math.Ceiling((double)fs.Length / (double)tamañoReg);
    }

    public void CerrarFichero() { bw.Close(); br.Close(); fs.Close(); }

    public int NúmeroDeRegs() { return nregs; } //devuelve número de registros

    public clsCheque LeerReg(int i)
    {
        if (i >= 0 && i < nregs)
        {
            br.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
            int idcheque = br.ReadInt32();
            string fechaemisioncheque = br.ReadString();
            double montoCheque = br.ReadDouble();
            string moneda = br.ReadString();
            bool estado = br.ReadBoolean();

            return (new clsCheque(idcheque, Convert.ToDateTime(fechaemisioncheque), montoCheque, moneda,estado));
        }
        else
        {
            return null;
        }
    }
    //busca el cheque por id y devuelve la posicion
    public int BuscarCheque(int idcheque)
    {
        clsCheque obj;
        int num;
        int reg_i = 0;
        bool encontrado = false;

        if (idcheque < 0) { return -1; }
        else
        {
            while ((reg_i < nregs) && (!encontrado))
            {
                obj = LeerReg(reg_i);
                num = obj.IdCheque;
                if (num == idcheque)
                { encontrado = true; }
                else
                    reg_i++;
            }
            if (encontrado) { return reg_i;}
            else
            { return -1;}
        }
    }
    //elimina cheque pasando numero de id
    public void EliminarCheque(int idche,string fichero) {

        int regi=0,regist = 0;
        int pos = BuscarCheque(idche);
        fst = new FileStream("Tempo.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        bwt = new BinaryWriter(fst);
        brt = new BinaryReader(fst);
        while (regi < nregs)
        {
            if (regist != pos)
            {
                clsCheque cheque1 = LeerReg(regist);
                bwt.BaseStream.Seek(regi * tamañoReg, SeekOrigin.Begin);
                bwt.Write(cheque1.IdCheque);
                bwt.Write(cheque1.FechaEmision.ToString());
                bwt.Write(cheque1.Monto);
                bwt.Write(cheque1.Moneda);
                bwt.Write(cheque1.Esta);
                regist++; regi++;
            }
            else
            {
                regist++;
                clsCheque cheque1 = LeerReg(regist);
                bwt.BaseStream.Seek(regi * tamañoReg, SeekOrigin.Begin);
                bwt.Write(cheque1.IdCheque);
                bwt.Write(cheque1.FechaEmision.ToString());
                bwt.Write(cheque1.Monto);
                bwt.Write(cheque1.Moneda);
                bwt.Write(cheque1.Esta);
                regist++; regi++;
            }
        }
            nregs--;
            CerrarFichero();
            fst.Close();
            bwt.Close();
            brt.Close();
            File.Delete(fichero);
            File.Move("Tempo.bin", fichero);
        abrirFichero(fichero);
        }

    public void AnularCheque(int idcheque) {
        int pos = BuscarCheque(idcheque);
        clsCheque cheque1 = LeerReg(pos);
        if (cheque1.Esta) { cheque1.Esta = false; }
    }
}
