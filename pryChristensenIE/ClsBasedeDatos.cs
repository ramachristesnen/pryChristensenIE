using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace pryChristensenIE
{
    internal class ClsBasedeDatos
    {
        OleDbConnection conexionBD;
        DirectoryInfo rutaProyecto = new DirectoryInfo(@"../..");
        string cadenaConexion;
        public bool estadoConexion;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD; // Mantenemos el campo lectorBD
        OleDbDataAdapter adaptadorDS;
        DataSet objDataSet = new DataSet();

        public ClsBasedeDatos()
        {
            estadoConexion = false;
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source="
                + rutaProyecto.FullName + "\\Archivos\\basedeusuarios.accdb";
        }

        public void ConectarBaseDatos()
        {
            conexionBD = new OleDbConnection(cadenaConexion);
            conexionBD.Open();
            estadoConexion = true;
        }

        public bool ValidarUsuarios(String Usuario, String Contraseña)
        {
            bool usuarioValido = false;
            try
            {
                string consulta = "SELECT * FROM Users WHERE Nombre = @Usuario AND Contraseña = @Contraseña";

                using (OleDbCommand cmd = new OleDbCommand(consulta, conexionBD))
                {
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                    lectorBD = cmd.ExecuteReader(); // Asignamos el lectorBD aquí

                    if (lectorBD.Read())
                    {
                        usuarioValido = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja las excepciones de manera apropiada, por ejemplo, mostrando un mensaje o registrando la excepción.
                MessageBox.Show("Error al validar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return usuarioValido;
        }

        public void RegistroUsuarios(String usuario, String contraseña)
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Users";

                adaptadorDS = new OleDbDataAdapter(comandoBD);
                adaptadorDS.Fill(objDataSet, "Users");

                DataTable tablaGrabar = objDataSet.Tables["Users"];
                DataRow filaGrabar = tablaGrabar.NewRow();

                filaGrabar["Nombre"] = usuario;
                filaGrabar["Contraseña"] = contraseña;
                tablaGrabar.Rows.Add(filaGrabar);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorDS);
                adaptadorDS.Update(objDataSet, "Users");
            }
            catch (Exception ex)
            {
                // Maneja las excepciones de manera apropiada, por ejemplo, mostrando un mensaje o registrando la excepción.
                MessageBox.Show("Error al registrar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
