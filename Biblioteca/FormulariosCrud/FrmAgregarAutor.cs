using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Linq; using System.Threading.Tasks; using System.Windows.Forms; using DevExpress.XtraEditors;
using MySql.Data;
using MySql.Data.MySqlClient;  namespace Biblioteca.FormulariosCrud {     public partial class FrmAgregarAutor : DevExpress.XtraEditors.XtraForm     {         public FrmAgregarAutor()         {             InitializeComponent();         }          private void textEdit3_EditValueChanged(object sender, EventArgs e)         {          }          private void FrmAgregarAutor_Load(object sender, EventArgs e)         {          }
        private void limpiarcajas()
        {
            txtIdAutor.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            cbNacionalidad.Text = "";
        }         private void btnGuardar_Click(object sender, EventArgs e)         {             MySqlCommand comando_ingresar = new MySqlCommand();             string IdAutor, Nombres, Apellidos, Nacionalidad, consulta;              IdAutor = txtIdAutor.Text;             Nombres = txtNombres.Text;             Apellidos = txtApellidos.Text;             Nacionalidad = cbNacionalidad.Text;              consulta = "insert into Autores(IdAutor , Nombres, Apellidos, Nacionalidad) values (@IdAutor , @Nombres, @Apellidos, @Nacionalidad);";             comando_ingresar.Parameters.Add("@IdAutor", MySqlDbType.VarChar).Value = IdAutor;             comando_ingresar.Parameters.Add("@Nombres", MySqlDbType.VarChar).Value = Nombres;             comando_ingresar.Parameters.Add("@Apellidos", MySqlDbType.VarChar).Value = Apellidos;             comando_ingresar.Parameters.Add("@Nacionalidad", MySqlDbType.VarChar).Value = Nacionalidad;             comando_ingresar.CommandText = consulta;              int resultado = Conexion.EjecutarOrden(comando_ingresar);             if (resultado > 0)             {                 MessageBox.Show("Datos ingresados correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);                 limpiarcajas();             }             else             {                 MessageBox.Show("Error al ingresar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);             }          }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarcajas();
        }     } }