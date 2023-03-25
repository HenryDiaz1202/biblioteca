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
    public partial class FrmEditAutorDocumento : DevExpress.XtraEditors.XtraForm
    {
        public FrmEditAutorDocumento()
        {
            InitializeComponent();
        }

        private void FrmEditAutorDocumento_Load(object sender, EventArgs e)
        {
            DataTable Datos_usuario = new DataTable();
            MySqlCommand comando = new MySqlCommand();
            DataTable Datos_autores = new DataTable();
            MySqlCommand comando_autores = new MySqlCommand();


            string consulta = "select IdAutor,Nombres,Apellidos from Autores;";
            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            this.cbAutoresList.DataSource = Datos_usuario;

            this.cbAutoresList.DisplayMember = "Nombres";
            this.cbAutoresList.ValueMember = "IdAutor";


            string idDoc;
            idDoc = txtIdDocm.Text;

            string consulta_aut = "select * from DetalleDocumento WHERE IdDocumento ='" + idDoc + "';";

            comando_autores.CommandText = consulta_aut;
            Datos_autores = Conexion.Ejecutar(comando_autores);
            dtAutoresDoc.DataSource = Datos_autores;

            checkedListBox1.Items.Add(Datos_autores);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtAutoresDoc.Rows.Add(txtIdDocm.Text, cbAutoresList.SelectedValue.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}