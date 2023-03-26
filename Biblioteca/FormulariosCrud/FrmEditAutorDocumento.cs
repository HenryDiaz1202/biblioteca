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

            string consulta = "select IdAutor, Concat (Nombres, ' ' ,Apellidos) as Autor from Autores;";
            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            this.cbAutoresList.DataSource = Datos_usuario;

            this.cbAutoresList.DisplayMember = "Autor";
            this.cbAutoresList.ValueMember = "IdAutor";


            string idDoc;
            idDoc = txtIdDocm.Text;

            string consulta_aut = "select * from DetalleDocumento WHERE IdDocumento ='" + idDoc + "';";

            comando_autores.CommandText = consulta_aut;
            Datos_autores = Conexion.Ejecutar(comando_autores);
            dtAutoresDoc.DataSource = Datos_autores;


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
            dtUpdateActs.Rows.Add(txtIdDocm.Text, cbAutoresList.SelectedValue.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dtAutoresDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtUpdateActs.Rows.Add((String)dtAutoresDoc.CurrentRow.Cells[0].Value, (String)dtAutoresDoc.CurrentRow.Cells[1].Value);
        }

        private void dtUpdateActs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando_borar = new MySqlCommand();
            MySqlCommand comando_ingresar = new MySqlCommand();

            string ID = txtIdDocm.Text;

            string consulta = "INSERT INTO detalledocumento (IdDocumento, IdAutor) values (@IdDocumento, @IdAutor)";
            string orden = "Delete from DetalleDocumento where IdDocumento=@IdDocumento;";
            int result = 0;

            comando_borar.Parameters.Add("@IdDocumento", MySqlDbType.VarChar).Value = ID;
            comando_borar.CommandText = orden;
            int resultado = Conexion.EjecutarOrden(comando_borar);
            if (resultado > 0)
            {
                foreach (DataGridViewRow row in dtUpdateActs.Rows)
                {
                    comando_ingresar.Parameters.Clear();
                    comando_ingresar.Parameters.AddWithValue("@IdDocumento", Convert.ToString(row.Cells["IdDocumento"].Value));
                    comando_ingresar.Parameters.AddWithValue("@IdAutor", Convert.ToString(row.Cells["IdAutor"].Value));
                    comando_ingresar.CommandText = consulta;
                    result = Conexion.EjecutarOrden(comando_ingresar);
                }
                if (result > 0)
                {
                    MessageBox.Show("Datos ingresados correctamete!!!!!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al ingresar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dtUpdateActs.Rows.Clear();
        }
    }
}