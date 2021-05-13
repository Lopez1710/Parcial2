using appVenta.DAO;
using appVenta.MODEL;
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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtIdProductp.Text == "") 
            {
                ClsCRUDProducto produc = new ClsCRUDProducto();
                produc.Guardar(TxtProducto.Text, TxtPrecio.Text, TxtEstadoProdutc.Text);
            }
            else
            {
                ClsCRUDProducto produc = new ClsCRUDProducto();
                tb_producto product = new tb_producto();
                product.idProducto = Convert.ToInt32(TxtIdProductp.Text);
                product.nombreProducto = TxtProducto.Text;
                product.nombreProducto = TxtPrecio.Text;
                product.estadoProducto = TxtEstadoProdutc.Text;
                produc.Modificar(product);
            }
            cargar();
            LimpiarTextBox();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            ClsCRUDProducto produc = new ClsCRUDProducto();
            produc.Eliminar(Convert.ToInt32(TxtIdProductp.Text));
            cargar();
            LimpiarTextBox();
        }

        public void cargar()
        {
            dataGridView1.Rows.Clear();
            ClsCRUDProducto produc = new ClsCRUDProducto();
            List<tb_producto> lista = produc.Mostrar();
            foreach (var ver in lista)
            {
                dataGridView1.Rows.Add(ver.idProducto,ver.nombreProducto,ver.precioProducto,ver.estadoProducto);
            }
        }

        public void LimpiarTextBox()
        {
            TxtIdProductp.Clear();
            TxtProducto.Clear();
            TxtPrecio.Clear();
            TxtEstadoProdutc.Clear();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cargar();
            LimpiarTextBox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Producto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string Estado = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            TxtIdProductp.Text = id;
            TxtProducto.Text = Producto;
            TxtPrecio.Text = Precio;
            TxtEstadoProdutc.Text = Estado;
        }
    }
}
