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
            dataGridView1.DataSource = Datos_usuario;
        }
        private void FrmDetallePrestamo_Load(object sender, EventArgs e)
        {
            DataTable Datos_usuario = new DataTable();
            MySqlCommand comando = new MySqlCommand();

            string IdAutor;
            IdAutor = searchControl1.Text;
            string consulta = "select * from StockDocumentos S, Documentos D WHERE S.IdDocumento=D.IdDocumento AND D.Titulo LIKE'%" + IdAutor + "%';";
            comando.CommandText = consulta;
            Datos_usuario = Conexion.Ejecutar(comando);
            dataGridView1.DataSource = Datos_usuario;
        }
    }
}