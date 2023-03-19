using Biblioteca.FormulariosCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
    }
}
