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
    public partial class FrmDetalleDocumento : DevExpress.XtraEditors.XtraForm
    {
        public FrmDetalleDocumento()
        {
            InitializeComponent();
        }

        private void FrmDetalleDocumento_Load(object sender, EventArgs e)
        {
            DataTable Datos_usuario = new DataTable();
            MySqlCommand comando = new MySqlCommand();
            string consulta = "select IdAutor, Concat (Nombres, ' ' ,Apellidos) as Autor from Autores;";
            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            this.cbAutoresList.DataSource = Datos_usuario;

            this.cbAutoresList.DisplayMember = "Autor";
            this.cbAutoresList.ValueMember = "IdAutor";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtAutoresDoc.Rows.Add(txtIdDocm.Text,cbAutoresList.SelectedValue.ToString());
        }
        private void limpiarcajas()
        {
            //txtIdDocm.Text = "";
            cbAutoresList.Text = "";
            dtAutoresDoc.Rows.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_ingresar = new MySqlCommand();
            MySqlCommand comando_ingresar_stock = new MySqlCommand();

            string consulta, consultastock;
            int resultado = 0, resultadostock=0;

            string IdDoc = txtIdDocm.Text;
            int Cant = Int32.Parse(lblNumRegistro.Text);

            consulta = "INSERT INTO detalledocumento (IdDocumento, IdAutor) values (@IdDocumento, @IdAutor)";
            consultastock = "INSERT INTO stockdocumentos (IdDocumento, CantidadDisponible) values (@IdDocumento, @CantidadDisponible)";

             foreach (DataGridViewRow row in dtAutoresDoc.Rows)
             {
                    comando_ingresar.Parameters.Clear();
                    comando_ingresar.Parameters.AddWithValue("@IdDocumento", Convert.ToString(row.Cells["IdDocumento"].Value));
                    comando_ingresar.Parameters.AddWithValue("@IdAutor", Convert.ToString(row.Cells["IdAutor"].Value));
                    comando_ingresar.CommandText = consulta;
                    resultado = Conexion.EjecutarOrden(comando_ingresar);
             }
             if (resultado > 0)
             {
                 comando_ingresar_stock.Parameters.Clear();
                 comando_ingresar_stock.Parameters.Add("@IdDocumento", MySqlDbType.VarChar).Value = IdDoc;
                 comando_ingresar_stock.Parameters.Add("@CantidadDisponible", MySqlDbType.Int32).Value = Cant;
                 comando_ingresar_stock.CommandText = consultastock;
                 resultadostock = Conexion.EjecutarOrden(comando_ingresar_stock);
                 if (resultadostock > 0)
                  {
                      MessageBox.Show("Datos ingresados correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      limpiarcajas();
                      txtIdDocm.Text = "";
                      this.Close();
                  }
             }
             else
             {
                 MessageBox.Show("Error al ingresar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarcajas();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}