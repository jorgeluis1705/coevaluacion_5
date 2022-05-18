using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for Persona
/// </summary>
public class PersonaService : Conexion
{
    public PersonaService()
    {

    }

    public List<Persona> GetAllPersonas()
    {
        List<Persona> personas = new List<Persona>();
        Connectar();
        try
        {
            MySqlCommand comando = new MySqlCommand("Listar", cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona persona = new Persona()
                {
                    Id = int.Parse(reader[0] + ""),
                    Name = reader["Name"].ToString(),
                    Description = reader["Description"].ToString(),
                };
                personas.Add(persona);
            }
            reader.Close();
            comando.Dispose();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Desconectar();
        }
        return personas;
    }

    public Persona CreatePersona(Persona persona)
    {
        Connectar();
        try
        {
            MySqlCommand comando = new MySqlCommand("Guardar", cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add(new MySqlParameter("@name", persona.Name));
            comando.Parameters.Add(new MySqlParameter("@description", persona.Description));
            comando.ExecuteNonQuery();
            comando.Dispose();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Desconectar();
        }
        return persona;
    }

    public Persona GetOnePersona(int id)
    {
        Persona persona = new Persona();
        Connectar();
        try
        {
            MySqlCommand comando = new MySqlCommand("Detalles", cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add(new MySqlParameter("@id", id));
            comando.ExecuteNonQuery();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                persona.Id = int.Parse(reader[0] + "");
                persona.Name = reader["Name"].ToString();
                persona.Description = reader["Description"].ToString();
            }
            reader.Close();
            comando.Dispose();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Desconectar();
        }
        return persona;
    }
    public void UpdatePersona(Persona persona, int id)
    {
        Connectar();
        try
        {
            MySqlCommand comando = new MySqlCommand("Editar", cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add(new MySqlParameter("@idUpdate", id));
            comando.Parameters.Add(new MySqlParameter("@name", persona.Name));
            comando.Parameters.Add(new MySqlParameter("@description", persona.Description));
            comando.ExecuteNonQuery();
            MySqlDataReader reader = comando.ExecuteReader();

            reader.Close();
            comando.Dispose();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Desconectar();
        }
    }
    public int DeletePersona(int id)
    {
        Connectar();
        try
        {
            MySqlCommand comando = new MySqlCommand("BorrarOne", cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add(new MySqlParameter("@idDelete", id));
            comando.ExecuteNonQuery();
            comando.Dispose();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Desconectar();
        }
        return id;
    }
}