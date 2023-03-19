using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace Biblioteca
{
    class Conexion
    {
        private static MySqlConnection conexion_local = null;
        private static MySqlCommand cmd = new MySqlCommand();
        private static MySqlDataAdapter DATAA;

        public static void conectar()
        {
            if (conexion_local != null) return;
            conexion_local = new MySqlConnection();
            conexion_local.ConnectionString = "Server=127.0.0.1;Uid=root;Pwd='';Database=BibliotecaSiuna";

            try
            {
                conexion_local.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha podidon conectar a la base de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion_local = null;
            }
        }

        public static DataTable Ejecutar(MySqlCommand comando)
        {
            DataTable Data = new DataTable();
            try
            {
                conectar();
                if (conexion_local == null) return Data;
                cmd = comando;
                cmd.Connection = conexion_local;
                DATAA = new MySqlDataAdapter();
                DATAA.SelectCommand = cmd;
                DATAA.Fill(Data);
                DATAA.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Data;
        }
        public static int EjecutarOrden(MySqlCommand comando)
        {
            int n = 0;
            conectar();
            if (conexion_local == null) return 0;
            try
            {
                cmd = comando;
                cmd.Connection = conexion_local;
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return n;
        }

        public static void mysql_close()
        {
            conexion_local.Close();
            conexion_local.Dispose();
            conexion_local = null;
        }
    }
}
