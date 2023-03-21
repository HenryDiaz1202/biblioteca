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
    public partial class FrmAgregarUsuario : DevExpress.XtraEditors.XtraForm
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void limpiarcajas() 
        {
            txtPassword.Text = "";
            txtUsuario.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_ingresar = new MySqlCommand();
            string IdUsuario, Usuario, Password, consulta;

            IdUsuario = txtUsuario.Text + "-" + "usr";
            Usuario = txtUsuario.Text;
            Password = txtPassword.Text;

            consulta = "insert into Usuarios(IdUsuario , Usuario, Contrasena) values (@IdUsuario , @Usuario, @Contrasena);";
            comando_ingresar.Parameters.Add("@IdUsuario", MySqlDbType.VarChar).Value = IdUsuario;
            comando_ingresar.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = Usuario;
            comando_ingresar.Parameters.Add("@Contrasena", MySqlDbType.VarChar).Value = Password;
            comando_ingresar.CommandText = consulta;

            int resultado = Conexion.EjecutarOrden(comando_ingresar);
            if (resultado > 0)
            {
                MessageBox.Show("Datos ingresados correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarcajas();
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}