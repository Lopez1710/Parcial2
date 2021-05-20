using appVenta.DAO;
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
    public partial class FrmBuscarProduto : Form
    {
        public FrmBuscarProduto()
        {
            InitializeComponent();
        }

        void cargardatos()
        {
            var clsp = new ClsCRUDProducto();
            dataGridView1.Rows.Clear();

            foreach (var lista in clsp.buscarProducto(txtProducto.Text))
            {
                dataGridView1.Rows.Add(lista.idProducto, lista.nombreProducto, lista.precioProducto);
            }

        }

        private void FrmBuscarProduto_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            FrmPadre.frmventa.txtId.Text = id;
            FrmPadre.frmventa.txtNombre.Text = Nombre;
            FrmPadre.frmventa.txtPrecio.Text = Precio;

            this.Close();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            cargardatos();
        }
    }
}
