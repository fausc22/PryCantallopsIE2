using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Threading;

namespace PryCantallopsIE
{
    public class clsUser
    {
        public string Nombre { get; set; }

        string rutaArchivo;
        string cadenaConexion;

        OleDbConnection cnn;
        OleDbCommand cmd;
        OleDbCommand cmdB;
        OleDbDataReader rdr;
        OleDbDataReader rdrB;

        public string estadoConexion;


        public clsUser()
        {
            rutaArchivo = @"../../DbAseguradora.accdb";
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            estadoConexion = "CERRADO";


        }


        //public void ConectarBD()
        //{
        //    try
        //    {
        //        cnn = new OleDbConnection();
        //        cnn.ConnectionString = cadenaConexion;
        //        cnn.Open();
        //        estadoConexion = "ABIERTO";

        //    }
        //    catch (Exception ex)
        //    {
        //        estadoConexion = ex.Message;

        //    }


        //}


        public void RegistrarLog(string Fecha, string User, string categoria)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(cadenaConexion);
                con.Open();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Logs (fechaHora, [user], Categoria) VALUES (@fecha, @user, @categoria)";
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                cmd.Parameters.AddWithValue("@user", User);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public bool IniciarSesion(string user, string password)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(cadenaConexion);
                con.Open();
                cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT Count(*) FROM Usuarios WHERE user = @Username AND password = @Password";
                cmd.Parameters.AddWithValue("@Username", user);
                cmd.Parameters.AddWithValue("@Password", password);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }





        }



        public string ObtenerNombreUsuario()
        {
            string user = "";
            try
            {
                

                using (OleDbConnection con = new OleDbConnection(cadenaConexion))
                {
                    con.Open();

                    // Obtener el último usuario de los logs
                    using (OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 user FROM Logs ORDER BY IdLogs DESC;", con))
                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            user = rdr["user"].ToString();
                        }
                    }
                }
                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
        }


        public string ObtenerRolUsuario()
        {
            try
            {
                string user = "";
                string rol = "";

                using (OleDbConnection con = new OleDbConnection(cadenaConexion))
                {
                    con.Open();

                    // Obtener el último usuario de los logs
                    using (OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 user FROM Logs ORDER BY IdLogs DESC;", con))
                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            user = rdr["user"].ToString();
                        }
                    }

                    // Obtener el rol del usuario
                    if (!string.IsNullOrEmpty(user))
                    {
                        using (OleDbCommand cmdB = new OleDbCommand("SELECT rol FROM Usuarios WHERE user = @user;", con))
                        {
                            cmdB.Parameters.AddWithValue("@user", user);

                            using (OleDbDataReader rdrB = cmdB.ExecuteReader())
                            {
                                if (rdrB.Read())
                                {
                                    rol = rdrB["rol"].ToString();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el usuario en los registros de logs.", "ERROR", MessageBoxButtons.OK);
                    }
                }

                return rol;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                return string.Empty;
            }
        }

        public void CargarUsuario(string user, string pw, string rol, byte[] imagen)
        {
            try
            {
                cnn = new OleDbConnection(cadenaConexion);
                cmd = new OleDbCommand();
                cmd.Connection = cnn;
                cnn.Open();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Usuarios ([user], [password], rol, firma) VALUES (@user, @pw, @rol, @firma)";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pw", pw);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.Add("@firma", OleDbType.VarBinary).Value = imagen; ;
                cmd.ExecuteNonQuery();
                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
