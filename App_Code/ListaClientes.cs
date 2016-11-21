using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using ProyectoFinal;
using System.Web.WebPages;

public class ListaClientes
{
    private FileStream fs, fst;
    private BinaryWriter bw, bwt;
    private BinaryReader br, brt;
    private int nregs;
    private int tamañoReg = 200;

    public ListaClientes(string fichero)
    {
        AbrirFichero(fichero);
    }
    public void AbrirFichero(string fi)
    {
        if (Directory.Exists(fi))
            throw new IOException(Path.GetFileName(fi) + " no es un fichero.");
        this.fs = new FileStream(fi, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        this.bw = new BinaryWriter(fs);
        this.br = new BinaryReader(fs);
        this.nregs = (int)Math.Ceiling((double)fs.Length / (double)this.tamañoReg);
    }
    public void CerrarFichero() { fs.Close(); bw.Close(); br.Close(); }

    public bool EscribirRegistro(int i, clsCliente obj)
    {
        try
        {
            if (i >= 0 && i <= nregs)
            {
                if (obj.Tamaño + 4 > tamañoReg) {
                    Console.WriteLine("Tamaño de registro excedido.");
                    return false;
                }else
                {
                    bw.BaseStream.Seek(i * this.tamañoReg, SeekOrigin.Begin);
                    bw.Write(obj.idcli);
                    bw.Write(obj.Nombre);
                    bw.Write(obj.Apellido);
                    bw.Write(obj.Dni);
                    bw.Write(obj.Domicilio);
                    bw.Write(obj.Telefono);
                    bw.Write(obj.Cuenta);
                    bw.Write(obj.Email);
                    return true;
                }
            }
           else { return false; }
        }
        catch (IOException e) { CerrarFichero(); Console.WriteLine(e.Message); return false; }
    }

    public void AgregarRegistro(clsCliente cli)
    {
        if (EscribirRegistro(this.nregs, cli))
            this.nregs++;
    }

    public int NumReg()
    {
        return this.nregs;
    }

    public clsCliente LeerRegistro(int i)//lee registro mandandole la posicion en el fichero
    {
        try
        {
            if (i >= 0 && i < NumReg())
            {
                br.BaseStream.Seek(i * this.tamañoReg, SeekOrigin.Begin);
                int idcliente = br.ReadInt32();
                string nombre = br.ReadString();
                string apellido = br.ReadString();
                long dni = br.ReadInt64();
                string domi = br.ReadString();
                long tel = br.ReadInt16();
                int cuenta = br.ReadInt32();
                string email = br.ReadString();
                return (new clsCliente(nombre, apellido, dni, domi, tel, cuenta, email, idcliente));
            }
            else { return null; }
        }
        catch (IOException e) { CerrarFichero(); return null; }
    }
    //busca registro por el id del cliente devuelve la posicion en el fichero
    public int BuscarReg(int IDCliente)
    {
        clsCliente obj;
        int ide;
        int reg_i = 0;
        bool encontrado = false;
        try
        {
            if (IDCliente < 0) { return -1; }
            else
            {
                while ((reg_i < nregs) && (!encontrado))
                {
                    obj = LeerRegistro(reg_i);
                    ide = obj.idcli;
                    if (ide == IDCliente)
                    {
                        encontrado = true;
                    }
                    else { reg_i++; }
                }

                if (encontrado)
                {
                    return reg_i;
                }
                else
                {
                    return -1;
                }
            }
        }
        catch (IOException e) { CerrarFichero(); Console.WriteLine("error:" + e.Message);return -1; }
    }

    public void EliminarCliente(int idcli, string fichero)
    {

        int regi = 0, regist = 0;
        int pos = BuscarReg(idcli);
        fst = new FileStream("Tempo.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        bwt = new BinaryWriter(fst);
        brt = new BinaryReader(fst);
        while (regi < nregs)
        {
            if (regist != pos)
            {
                clsCliente cliente = LeerRegistro(regist);
                bwt.BaseStream.Seek(regi * tamañoReg, SeekOrigin.Begin);
                bwt.Write(cliente.idcli);
                bwt.Write(cliente.Nombre);
                bwt.Write(cliente.Apellido);
                bwt.Write(cliente.Dni);
                bwt.Write(cliente.Domicilio);
                bwt.Write(cliente.Telefono);
                bwt.Write(cliente.Cuenta);
                bwt.Write(cliente.Email);
                regist++; regi++;
            }
            else
            {
                regist++;
                clsCliente cliente = LeerRegistro(regist);
                bwt.BaseStream.Seek(regi * tamañoReg, SeekOrigin.Begin);
                bwt.Write(cliente.idcli);
                bwt.Write(cliente.Nombre);
                bwt.Write(cliente.Apellido);
                bwt.Write(cliente.Dni);
                bwt.Write(cliente.Domicilio);
                bwt.Write(cliente.Telefono);
                bwt.Write(cliente.Cuenta);
                bwt.Write(cliente.Email);
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
        AbrirFichero(fichero);
    }
}