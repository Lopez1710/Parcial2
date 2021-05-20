using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVenta.Vista
{
    public partial class FrmPadre : Form
    {
        public FrmPadre()
        {
            InitializeComponent();
        }
        public static FrmVenta frmventa = new FrmVenta();
        private void cRUDProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cRUDClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cRUDDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocumento frm = new FrmDocumento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             frmventa.Show();
        }
    }
}
