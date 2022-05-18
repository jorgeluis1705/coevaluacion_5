using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for Persona
/// </summary>
public class Conexion
{

    protected MySqlConnection cnn;
    protected MySqlCommand cmd;
    protected string connectionCadena = "server = mysql-jorgeluispenareal.alwaysdata.net; database = jorgeluispenareal_prueba; Uid = 254084_root; pwd =gB0az0YYqK7wsSG;";

    public Conexion()
    {


    }
    public void Connectar()
    {
        try
        {

            cnn = new MySqlConnection(connectionCadena);
            cnn.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }

    public void Desconectar()
    {
        try
        {
            cnn.Close();
            cnn.Dispose();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }

}