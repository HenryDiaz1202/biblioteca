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


namespace Biblioteca.FormulariosCrud
{
    public partial class FrmAgregarPrestamo_cs : DevExpress.XtraEditors.XtraForm
    {
        public FrmAgregarPrestamo_cs()
        {
            InitializeComponent();
        }

       
        private void FrmAgregarPrestamo_cs_Load(object sender, EventArgs e)
        {
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAgregarLector frmagregarlector = new FrmAgregarLector();
            frmagregarlector.ShowDialog();
        }
    }
}