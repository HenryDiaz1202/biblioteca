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
    public partial class FrmDetallePrestamo : DevExpress.XtraEditors.XtraForm
    {
        public FrmDetallePrestamo()
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
            dtCargar.DataSource = Datos_usuario;
        }
        private void FrmDetallePrestamo_Load(object sender, EventArgs e)
        {
            DataTable Datos_usuario = new DataTable();
            MySqlCommand comando = new MySqlCommand();

            string IdAutor;
            IdAutor = searchControl1.Text;
            string consulta = "select S.IdDocumento, D.Titulo, S.CantidadDisponible from StockDocumentos S, Documentos D WHERE S.IdDocumento=D.IdDocumento AND D.Titulo LIKE'%" + IdAutor + "%';";
            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            dtCargar.DataSource = Datos_usuario;
        }

        private void lblNumRegistro_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtCargar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int disponibles = 0, solicita =0, nuevodisponible=0;
            solicita = Int32.Parse(txtCantidad.Text);
            disponibles = Int32.Parse(dtCargar.CurrentRow.Cells[2].Value.ToString());
            nuevodisponible = disponibles - solicita;

            if (solicita <= 0)
            {
                MessageBox.Show("La cantidad debe de ser mayor a 0", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(solicita>disponibles)
            {
                MessageBox.Show("No hay esas cantidad Disponible, por ahora solo hay : " + disponibles + " documentos disponibles.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtRegistro.Rows.Add(txtIdPrestamo.Text, (String)dtCargar.CurrentRow.Cells[0].Value,(String)dtCargar.CurrentRow.Cells[1].Value, txtCantidad.Text, nuevodisponible.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_ingresar = new MySqlCommand();
            MySqlCommand comando_update_stock = new MySqlCommand();
            string consulta, consulta_update;
            int resultado = 0;

            consulta = "INSERT INTO DetallePrestamo (IdPrestamo, IdDocumento, Cantidad) VALUES (@IdPrestamo, @IdDocumento, @Cantidad);";
            consulta_update = "UPDATE StockDocumentos SET CantidadDisponible=@CantidadDisponible WHERE IdDocumento = @IdDocumento;";

            foreach (DataGridViewRow row in dtRegistro.Rows)
            {
                comando_ingresar.Parameters.Clear();
                comando_ingresar.Parameters.AddWithValue("@IdPrestamo", Convert.ToString(row.Cells["IdPrestamo"].Value));
                comando_ingresar.Parameters.AddWithValue("@IdDocumento", Convert.ToString(row.Cells["IdDoc"].Value));
                comando_ingresar.Parameters.AddWithValue("@Cantidad", Convert.ToString(row.Cells["Cantidad"].Value));
                comando_ingresar.CommandText = consulta;
                resultado = Conexion.EjecutarOrden(comando_ingresar);
            }
            if (resultado > 0)
            {
                foreach (DataGridViewRow row in dtRegistro.Rows)
                {
                    comando_update_stock.Parameters.Clear();

                    comando_update_stock.Parameters.AddWithValue("@CantidadDisponible", Convert.ToString(row.Cells["newD"].Value));
                    comando_update_stock.Parameters.AddWithValue("@IdDocumento", Convert.ToString(row.Cells["IdDoc"].Value));
                    comando_update_stock.CommandText = consulta_update;
                    resultado = Conexion.EjecutarOrden(comando_update_stock);
                }
                int resultadostock = Conexion.EjecutarOrden(comando_update_stock);
                if (resultadostock > 0)
                {
                    MessageBox.Show("Datos ingresados correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}