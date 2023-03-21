using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Biblioteca.FormulariosCrud
{
    public partial class FrmListaUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public FrmListaUsuarios()
        {
            InitializeComponent();
        }

        private void actualizardatos()
        {
            DataTable Datos_usuario = new DataTable();
            MySqlCommand comando = new MySqlCommand();
            string consulta = "select * from Usuarios;";
            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            dataGridView1.DataSource = Datos_usuario;
        }
        private void FrmListaUsuarios_Load(object sender, EventArgs e)
        {
            actualizardatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUsuario.Text = (String)dataGridView1.CurrentRow.Cells[0].Value;
            txtUsuario.Text = (String)dataGridView1.CurrentRow.Cells[1].Value;
            txtPassword.Text = (String)dataGridView1.CurrentRow.Cells[2].Value;
        }
        private void limpiarcajas()
        {
            txtIdUsuario.Text = "";
            txtPassword.Text = "";
            txtUsuario.Text = "";
            searchControl1.Text = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_ingresar = new MySqlCommand();
            string IdUsuario, Usuario, Password, consulta;

            IdUsuario = txtIdUsuario.Text;
            Usuario = txtUsuario.Text;
            Password = txtPassword.Text;

            consulta = "UPDATE Usuarios SET Usuario=@Usuario, Contrasena=@Contrasena WHERE IdUsuario=@IdUsuario ;";
            comando_ingresar.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = Usuario;
            comando_ingresar.Parameters.Add("@Contrasena", MySqlDbType.VarChar).Value = Password;
            comando_ingresar.Parameters.Add("@IdUsuario", MySqlDbType.VarChar).Value = IdUsuario;
            comando_ingresar.CommandText = consulta;

            int resultado = Conexion.EjecutarOrden(comando_ingresar);
            if (resultado > 0)
            {
                MessageBox.Show("Datos ingresados correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarcajas();
                actualizardatos();
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_borar = new MySqlCommand();
            string ID = txtIdUsuario.Text;
            string orden = "Delete from Usuarios where IdUsuario=@IdUsuario;";
            comando_borar.Parameters.Add("@IdUsuario", MySqlDbType.VarChar).Value = ID;
            comando_borar.CommandText = orden;
            int resultado = Conexion.EjecutarOrden(comando_borar);
            if (resultado > 0)
            {
                MessageBox.Show("Datos eliminado correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarcajas();
                actualizardatos();
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            actualizardatos();
        }
    }
}