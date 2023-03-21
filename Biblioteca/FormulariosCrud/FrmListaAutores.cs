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
    public partial class FrmListaAutores : DevExpress.XtraEditors.XtraForm
    {
        public FrmListaAutores()
        {
            InitializeComponent();
        }
        private void actualizardatos() {
            DataTable Datos_usuario = new DataTable();
            MySqlCommand comando = new MySqlCommand();
            string consulta = "select * from Autores;";
            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            dataGridView1.DataSource = Datos_usuario;
        }
        private void FrmListaAutores_Load(object sender, EventArgs e)
        {
            actualizardatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdAutor.Text = (String)dataGridView1.CurrentRow.Cells[0].Value;
            txtNombres.Text = (String)dataGridView1.CurrentRow.Cells[1].Value;
            txtApellidos.Text = (String)dataGridView1.CurrentRow.Cells[2].Value;
            cbNacionalidad.Text = (String)dataGridView1.CurrentRow.Cells[3].Value;
        }
        private void limpiarcajas()
        {
            txtApellidos.Text = "";
            txtIdAutor.Text = "";
            txtNombres.Text = "";
            searchControl1.Text = "";
            cbNacionalidad.Text = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_ingresar = new MySqlCommand();
            string IdAutor, Nombres, Apellidos, Nacionalidad, consulta;
            IdAutor = txtIdAutor.Text;
            Nombres = txtNombres.Text;
            Apellidos = txtApellidos.Text;
            Nacionalidad = cbNacionalidad.Text;

            consulta = "UPDATE Autores SET Nombres=@Nombres, Apellidos=@Apellidos, Nacionalidad=@Nacionalidad WHERE IdAutor=@IdAutor;";
            comando_ingresar.Parameters.Add("@Nombres", MySqlDbType.VarChar).Value = Nombres;
            comando_ingresar.Parameters.Add("@Apellidos", MySqlDbType.VarChar).Value = Apellidos;
            comando_ingresar.Parameters.Add("@Nacionalidad", MySqlDbType.VarChar).Value = Nacionalidad;
            comando_ingresar.Parameters.Add("@IdAutor", MySqlDbType.VarChar).Value = IdAutor;
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
            string ID = txtIdAutor.Text;
            string orden = "Delete from Autores where IdAutor=@IdAutor;";
            comando_borar.Parameters.Add("@IdAutor", MySqlDbType.VarChar).Value = ID;
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