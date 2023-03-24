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
    public partial class FrmAgregarDocumento : DevExpress.XtraEditors.XtraForm
    {
        public FrmAgregarDocumento()
        {
            InitializeComponent();
        }

        private void limpiarcajas()
        {
            txtIdDoc.Text = "";
            txtTitulo.Text = "";
            txtNumPaginas.Text = "";
            cbCategoria.Text = "";
            txtObservacion.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_ingresar = new MySqlCommand();

            int NumPaginas=0, CantidadRegistro=0;
            string IdDocumento, Titulo, Categoria, Observacion, consulta;
            DateTime FechaPublicacion, FechaRegistro;
            
            IdDocumento = txtIdDoc.Text;
            Titulo = txtTitulo.Text;
            NumPaginas = Int32.Parse(txtNumPaginas.Text);
            Categoria = cbCategoria.Text;
            Observacion = txtObservacion.Text;
            FechaPublicacion = dtPublicacion.Value.Date;
            FechaRegistro = dtRegistro.Value.Date;
            CantidadRegistro = Int32.Parse(txtCantidadRegistro.Text);

            consulta = "insert into Documentos(IdDocumento , Titulo, NumPaginas, Categoria, Observacion, FechaPublicacion, FechaRegistro, CantidadRegistrar) values (@IdDocumento , @Titulo, @NumPaginas, @Categoria, @Observacion, @FechaPublicacion, @FechaRegistro, @CantidadRegistrar);";
            comando_ingresar.Parameters.Add("@IdDocumento", MySqlDbType.VarChar).Value = IdDocumento;
            comando_ingresar.Parameters.Add("@Titulo", MySqlDbType.VarChar).Value = Titulo;
            comando_ingresar.Parameters.Add("@NumPaginas", MySqlDbType.Int32).Value = NumPaginas;
            comando_ingresar.Parameters.Add("@Categoria", MySqlDbType.VarChar).Value = Categoria;
            comando_ingresar.Parameters.Add("@Observacion", MySqlDbType.VarChar).Value = Observacion;
            comando_ingresar.Parameters.Add("@FechaPublicacion", MySqlDbType.Date).Value = FechaPublicacion;
            comando_ingresar.Parameters.Add("@FechaRegistro", MySqlDbType.Date).Value = FechaRegistro;
            comando_ingresar.Parameters.Add("@CantidadRegistrar", MySqlDbType.Int32).Value = CantidadRegistro;

            comando_ingresar.CommandText = consulta;

            int resultado = Conexion.EjecutarOrden(comando_ingresar);
            if (resultado > 0)
            {
                //MessageBox.Show("Datos ingresados correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                FrmDetalleDocumento frmdetalledocumento = new FrmDetalleDocumento();
                frmdetalledocumento.txtIdDocm.Text = txtIdDoc.Text;
                frmdetalledocumento.lblNumRegistro.Text = txtCantidadRegistro.Text;
                frmdetalledocumento.ShowDialog();
                limpiarcajas();
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarcajas();
        }
    }
}