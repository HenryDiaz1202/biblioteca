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
    public partial class FrmListaLectores : DevExpress.XtraEditors.XtraForm
    {
        public FrmListaLectores()
        {
            InitializeComponent();
        }
        private void actualizardatos()
        {
            DataTable Datos_usuario = new DataTable();
            MySqlCommand comando = new MySqlCommand();
            string consulta = "select * from Lectores;";
            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            dataGridView1.DataSource = Datos_usuario;
        }
        private void FrmListaLectores_Load(object sender, EventArgs e)
        {
            actualizardatos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            actualizardatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable Datos_usuario = new DataTable();
            MySqlCommand comando = new MySqlCommand();

            string IdAutor;
            IdAutor = searchControl1.Text;

            string consulta = "select * from Lectores WHERE NombresLector LIKE'%" + IdAutor + "%';";

            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            dataGridView1.DataSource = Datos_usuario;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdLector.Text = (String)dataGridView1.CurrentRow.Cells[0].Value;
            txtNombres.Text = (String)dataGridView1.CurrentRow.Cells[1].Value;
            txtApellidos.Text = (String)dataGridView1.CurrentRow.Cells[2].Value;
            cbSexo.Text = (String)dataGridView1.CurrentRow.Cells[3].Value;
            cbMunicipio.Text = (String)dataGridView1.CurrentRow.Cells[4].Value;
            txtEdad.Text = (String)dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbEtnia.Text = (String)dataGridView1.CurrentRow.Cells[6].Value;
        }
        private void limpiarcajas()
        {
            txtIdLector.Text = "";
            txtEdad.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
        } 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_borar = new MySqlCommand();
            string ID = txtIdLector.Text;
            string orden = "Delete from Lectores where IdLector=@IdLector;";
            comando_borar.Parameters.Add("@IdLector", MySqlDbType.VarChar).Value = ID;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_ingresar = new MySqlCommand();
            string IdLector, nombres, apellidos, sexo, municipio, etnia, consulta;
            int edad = 0;

            IdLector = txtIdLector.Text;
            nombres = txtNombres.Text;
            apellidos = txtApellidos.Text;
            edad = int.Parse(txtEdad.Text);
            sexo = cbSexo.Text;
            municipio = cbMunicipio.Text;
            etnia = cbEtnia.Text;

            consulta = "UPDATE Lectores SET NombresLector=@NombresLector, ApellidosLector=@ApellidosLector, Sexo=@Sexo, Municipio=@Municipio , edad=@edad , etnia=@etnia  WHERE IdLector=@IdLector;";
            comando_ingresar.Parameters.Add("@NombresLector", MySqlDbType.VarChar).Value = nombres;
            comando_ingresar.Parameters.Add("@ApellidosLector", MySqlDbType.VarChar).Value = apellidos;
            comando_ingresar.Parameters.Add("@Sexo", MySqlDbType.VarChar).Value = sexo;
            comando_ingresar.Parameters.Add("@Municipio", MySqlDbType.VarChar).Value = municipio;
            comando_ingresar.Parameters.Add("@edad", MySqlDbType.VarChar).Value = edad;
            comando_ingresar.Parameters.Add("@etnia", MySqlDbType.VarChar).Value = etnia;
            comando_ingresar.Parameters.Add("@IdLector", MySqlDbType.VarChar).Value = IdLector;
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
    }
}