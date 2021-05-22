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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void ultimocorrelativoventa()
        {
            ClsDVenta cls = new ClsDVenta();
            int IdVentaUltimo = 0;
            foreach (var lista in cls.Ultimaventa())
            {
                IdVentaUltimo = lista.iDVenta;
            }

            IdVentaUltimo = IdVentaUltimo + 1;
            txtNumeroDoc.Text = IdVentaUltimo.ToString();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

            ultimocorrelativoventa();

            ClsCRUDCliente clsCliente = new ClsCRUDCliente();

                comboBox2.DataSource = clsCliente.Mostrar();
                comboBox2.DisplayMember = "nombreCliente";
                comboBox2.ValueMember = "iDCliente";

            ClsCRUDDocumento clsDocumento = new ClsCRUDDocumento();   
                comboBox1.DataSource = clsDocumento.Mostrar();
                comboBox1.DisplayMember = "nombreDocumento";
                comboBox1.ValueMember = "iDDocumento";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto frm = new FrmBuscarProducto();
            frm.Show();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Total, Precio, Cantidad;

                Precio = Convert.ToDouble(txtPrecio.Text);
                Cantidad = Convert.ToDouble(txtCantidad.Text);
                Total = Cantidad * Precio;
                txtTotal.Text = Total.ToString();
            }
            catch
            {
                if (txtCantidad.Text == "")
                {
                    txtCantidad.Text = "0";
                    txtCantidad.SelectAll();
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DtgVenta.Rows.Add(txtId.Text,txtNombre.Text,txtPrecio.Text,txtCantidad.Text,txtTotal.Text);

            double suma = 0;
            for(int i = 0; i<DtgVenta.Rows.Count;i++)
            {
                string datosaoperar = DtgVenta.Rows[i].Cells[4].Value.ToString();

                suma = suma + Convert.ToDouble(datosaoperar);

                txtTotalVenta.Text = suma.ToString();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.Text = "0";
            txtCantidad.SelectAll();
            txtTotal.Text = "0";
        }
    }
}
