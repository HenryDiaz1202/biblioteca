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
    public partial class FrmAgregarLector : DevExpress.XtraEditors.XtraForm
    {
        public FrmAgregarLector()
        {
            InitializeComponent();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
        private void limpiarcajas()
        {
            txtIdLector.Text = "";
            txtEdad.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
        }
        private void FrmAgregarLector_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarcajas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_ingresar = new MySqlCommand();
            string IdLector, nombres, apellidos, sexo, municipio, etnia, consulta;
            int edad = 0;

            IdLector = "LT-"+txtIdLector.Text;
            nombres = txtNombres.Text;
            apellidos = txtApellidos.Text;
            edad = int.Parse(txtEdad.Text);
            sexo = cbSexo.Text;
            municipio = cbMunicipio.Text;
            etnia = cbEtnia.Text;

            consulta = "insert into Lectores(IdLector , NombresLector, ApellidosLector,Sexo,Municipio,edad,etnia) values (@IdLector , @NombresLector, @ApellidosLector,@Sexo,@Municipio,@edad,@etnia);";
            comando_ingresar.Parameters.Add("@IdLector", MySqlDbType.VarChar).Value = IdLector;
            comando_ingresar.Parameters.Add("@NombresLector", MySqlDbType.VarChar).Value = nombres;
            comando_ingresar.Parameters.Add("@ApellidosLector", MySqlDbType.VarChar).Value = apellidos;
            comando_ingresar.Parameters.Add("@Sexo", MySqlDbType.VarChar).Value = sexo;
            comando_ingresar.Parameters.Add("@Municipio", MySqlDbType.VarChar).Value = municipio;
            comando_ingresar.Parameters.Add("@edad", MySqlDbType.Int32).Value = edad;
            comando_ingresar.Parameters.Add("@etnia", MySqlDbType.VarChar).Value = etnia;
            comando_ingresar.CommandText = consulta;

            int resultado = Conexion.EjecutarOrden(comando_ingresar);
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
    }
}