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
    }
}
