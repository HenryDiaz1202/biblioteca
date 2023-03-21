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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtAutoresDoc.Rows.Add(txtIdDocm.Text,cbAutoresList.Text);
        }
        private void limpiarcajas()
        {
            txtIdDocm.Text = "";
            cbAutoresList.Text = "";
            dtAutoresDoc.Rows.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_ingresar = new MySqlCommand();

            string consulta;
            int resultado = 0;

            consulta = "INSERT INTO detalledocumento (IdDocumento, IdAutor) values (@IdDocumento, @IdAutor)";

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
                 MessageBox.Show("Datos ingresados correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 limpiarcajas();
                 this.Close();
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
    }
}