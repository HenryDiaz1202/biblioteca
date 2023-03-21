using Biblioteca.FormulariosCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Biblioteca
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form2 login = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAgregarAutor frmagregarautor = new FrmAgregarAutor();
            frmagregarautor.MdiParent = this;
            frmagregarautor.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Con la función Hide(), se ocultan ventanas, que en este caso es la de función principal
            this.Hide();
            //Los if se llaman condicionales que permiten tomar una decisión u troa
            if (login.ShowDialog() != DialogResult.OK)
            {
                login.Close();
                this.Close();
                return;
            }
            else
            {
                this.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmListaAutores frmlistaautores = new FrmListaAutores();
            frmlistaautores.MdiParent = this;
            frmlistaautores.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmListaDocumentos frmlistadocumentos = new FrmListaDocumentos();
            frmlistadocumentos.MdiParent = this;
            frmlistadocumentos.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAgregarDocumento frmagregardocumento = new FrmAgregarDocumento();
            frmagregardocumento.MdiParent = this;
            frmagregardocumento.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmListaUsuarios frmlistausuarios = new FrmListaUsuarios();
            frmlistausuarios.MdiParent = this;
            frmlistausuarios.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAgregarUsuario frmagregarusuario = new FrmAgregarUsuario();
            frmagregarusuario.MdiParent = this;
            frmagregarusuario.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form2 login = new Form2();
            this.Hide();
            login.Show();
        }
        string direc = "C:\\RespaldoBiblioteca";
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fecha = System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString();
            string hora = System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString();

            string credenciales = "Server=localhost; Database=bibliotecasiuna; Uid=root; Pwd=;";
            string archivo = "C:\\RespaldoBiblioteca\\BIBLIOTECA-" + fecha + "-" + hora + ".sql";
            using (MySqlConnection conexion1 = new MySqlConnection(credenciales))
            {
                using (MySqlCommand comando = new MySqlCommand())
                {
                    using (MySqlBackup respaldo = new MySqlBackup(comando))
                    {
                        comando.Connection = conexion1;
                        conexion1.Open();
                        respaldo.ExportToFile(archivo);
                        MessageBox.Show("El respaldo de la base de datos ha sido creado exitosamente. \n\n Dirección donde se guardó. \n " + direc + "", "Creado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexion1.Close();
                    }
                }
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
