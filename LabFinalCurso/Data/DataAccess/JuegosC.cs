
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabFinalCurso.Data.Models;
using System.Windows.Forms;
using System.Data;
using Mysqlx.Crud;
namespace LabFinalCurso.Data.DataAccess
{
    internal class JuegosC
    {
        private string connectionString = "Server=Localhost;Database=db_universida;Uid=root;Pwd=rudygt2024";
        public bool PruebaConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public void Insertar(Consolas consol)


        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
                try
            {
                string query = "INSERT INTO catalogo_consolas (id_consola, nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@IdConsola, @NombreConsola, @Compania, @AnioLanzamiento, @Generacion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdConsola", consol.id_consola);
                cmd.Parameters.AddWithValue("@NombreConsola", consol.nombre_consola);
                cmd.Parameters.AddWithValue("@Compania", consol.compania);
                cmd.Parameters.AddWithValue("@AnioLanzamiento", consol.anio_lanzamiento);
                cmd.Parameters.AddWithValue("@Generacion", consol.generacion);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
                }
        }

        public void Actualizar(Consolas consol)
            {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE catalogo_consolas SET nombre_consola = @NombreConsola, compania = @Compania, anio_lanzamiento = @AnioLanzamiento, generacion = @Generacion WHERE id_consola = @IdConsola";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@IdConsola", consol.id_consola);
                    cmd.Parameters.AddWithValue("@NombreConsola", consol.nombre_consola);
                    cmd.Parameters.AddWithValue("@Compania", consol.compania);
                    cmd.Parameters.AddWithValue("@AnioLanzamiento", consol.anio_lanzamiento);
                    cmd.Parameters.AddWithValue("@Generacion", consol.generacion);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                }
            }
        }
        public DataTable LeerCatalogo()
{
    DataTable juegoconsola = new DataTable();

    using (MySqlConnection connection = new MySqlConnection(connectionString))
    {
        try
        {
            connection.Open();
            string sql = "SELECT * FROM catalogo_consolas";
            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(juegoconsola);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al leer el catálogo: " + ex.Message);
        }
    }

    return juegoconsola;
}
        public void Eliminar(Consolas consol)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM catalogo_consolas WHERE id_consola = @IdConsola";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@IdConsola", consol.id_consola);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
            }
        }








    }
}


