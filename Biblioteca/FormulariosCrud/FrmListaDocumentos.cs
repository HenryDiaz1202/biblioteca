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
    public partial class FrmListaDocumentos : DevExpress.XtraEditors.XtraForm
    {
        public FrmListaDocumentos()
        {
            InitializeComponent();
        }

        private void actualizardatos()
        {
            DataTable Datos_usuario = new DataTable();
            MySqlCommand comando = new MySqlCommand();
            string consulta = "select * from Documentos;";
            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            dataGridView1.DataSource = Datos_usuario;
        }
        private void FrmListaDocumentos_Load(object sender, EventArgs e)
        {
            actualizardatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDocumento.Text = (String)dataGridView1.CurrentRow.Cells[0].Value;
            txtTitulo.Text = (String)dataGridView1.CurrentRow.Cells[1].Value;
            txtNumPaginas.Text = (String)dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbCategoria.Text = (String)dataGridView1.CurrentRow.Cells[3].Value;
            txtObservacion.Text = (String)dataGridView1.CurrentRow.Cells[4].Value;
            dtPublicacion.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
            dtRegistro.Value = (DateTime)dataGridView1.CurrentRow.Cells[6].Value;
        }
        private void limpiarcajas()
        {
            searchControl1.Text = "";
            txtIdDocumento.Text = "";
            txtNumPaginas.Text = "";
            txtObservacion.Text = "";
            txtTitulo.Text = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_ingresar = new MySqlCommand();

            int NumPaginas = 0;
            string IdDocumento, Titulo, Categoria, Observacion, consulta;
            DateTime FechaPublicacion, FechaRegistro;

            IdDocumento = txtIdDocumento.Text;
            Titulo = txtTitulo.Text;
            NumPaginas = Int32.Parse(txtNumPaginas.Text);
            Categoria = cbCategoria.Text;
            Observacion = txtObservacion.Text;
            FechaPublicacion = dtPublicacion.Value.Date;
            FechaRegistro = dtRegistro.Value.Date;

            consulta = "UPDATE Documentos SET Titulo=@Titulo, NumPaginas=@NumPaginas, Categoria=@Categoria, Observacion=@Observacion, FechaPublicacion=@FechaPublicacion, FechaRegistro=@FechaRegistro WHERE IdDocumento=@IdDocumento;";
            comando_ingresar.Parameters.Add("@Titulo", MySqlDbType.VarChar).Value = Titulo;
            comando_ingresar.Parameters.Add("@NumPaginas", MySqlDbType.Int32).Value = NumPaginas;
            comando_ingresar.Parameters.Add("@Categoria", MySqlDbType.VarChar).Value = Categoria;
            comando_ingresar.Parameters.Add("@Observacion", MySqlDbType.VarChar).Value = Observacion;
            comando_ingresar.Parameters.Add("@FechaPublicacion", MySqlDbType.Date).Value = FechaPublicacion;
            comando_ingresar.Parameters.Add("@FechaRegistro", MySqlDbType.Date).Value = FechaRegistro;
            comando_ingresar.Parameters.Add("@IdDocumento", MySqlDbType.VarChar).Value = IdDocumento;

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

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_borar = new MySqlCommand();
            string ID = txtIdDocumento.Text;

            string orden_detalle = "Delete from DetalleDocumento where IdDocumento=@IdDocumento;";
            string orden_documento = "Delete from Documentos where IdDocumento=@IdDocumento;";

            comando_borar.Parameters.Add("@IdDocumento", MySqlDbType.VarChar).Value = ID;
            comando_borar.CommandText = orden_detalle;
            int resultado = Conexion.EjecutarOrden(comando_borar);
            if (resultado > 0)
            {
                comando_borar.Parameters.Clear();
                string ID1 = txtIdDocumento.Text;
                comando_borar.Parameters.Add("@IdDocumento", MySqlDbType.VarChar).Value = ID1;
                comando_borar.CommandText = orden_documento;
                int resultado_doc = Conexion.EjecutarOrden(comando_borar);
                if (resultado_doc > 0)
                {
                    MessageBox.Show("Datos eliminados correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarcajas();
                    actualizardatos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos"+e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            string consulta = "select * from Documentos WHERE Titulo LIKE'%" + IdAutor + "%';";

            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            dataGridView1.DataSource = Datos_usuario;
        }
    }
}