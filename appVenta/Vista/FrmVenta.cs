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
        void total()
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
                    txtCantidad.Text = "1";
                    txtCantidad.SelectAll();
                }
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            total();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            total();
            DtgVenta.Rows.Add(txtId.Text,txtNombre.Text,txtPrecio.Text,txtCantidad.Text,txtTotal.Text);

            calcularsuma();

           
            txtId.Text = "";
            txtNombre.Clear();
            txtPrecio.Text = "";
            txtCantidad.Clear();
            txtTotal.Clear();

            DtgVenta.Refresh();
            DtgVenta.ClearSelection();
            int ultimafila = DtgVenta.Rows.Count - 1;
            DtgVenta.FirstDisplayedScrollingRowIndex = ultimafila;
            DtgVenta.Rows[ultimafila].Selected = true;
        }

        void calcularsuma()
        {
            double suma = 0;
            for (int i = 0; i < DtgVenta.Rows.Count; i++)
            {
                string datosaoperar = DtgVenta.Rows[i].Cells[4].Value.ToString();

                suma = suma + Convert.ToDouble(datosaoperar);

                txtTotalVenta.Text = suma.ToString();

            }
        } 

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.Text = "1";
            txtCantidad.SelectAll();
            
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            
                if (txtBuscarProducto.Text.Equals(""))
                {

                    txtCantidad.Focus();
                    btnBuscar.PerformClick();
                    e.Handled = true;

                }
                else
                {
                    ClsCRUDProducto cls = new ClsCRUDProducto();

                    if (cls.buscarproductoid(Convert.ToInt32(txtBuscarProducto.Text)).Count < 1)
                    {
                        MessageBox.Show("El codigo no existe");
                        txtBuscarProducto.Text = "";
                    }
                    foreach (var datos in cls.buscarproductoid(Convert.ToInt32(txtBuscarProducto.Text)))
                    {
                        txtId.Text = datos.idProducto.ToString();
                        txtNombre.Text = datos.nombreProducto;
                        txtPrecio.Text = datos.precioProducto;
                        txtCantidad.Text = "1";
                        txtCantidad.Focus();
                        total();
                        e.Handled = true;


                    }
                }
            
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto frm = new FrmBuscarProducto();
            frm.Show();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                BtnAgregar.PerformClick();
                txtBuscarProducto.Focus();
                
            }
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDVenta ventas = new ClsDVenta();
                tb_venta venta = new tb_venta();
                venta.iDDocumento = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                venta.iDCliente = Convert.ToInt32(comboBox2.SelectedValue.ToString());
                venta.iDUsuario = 1;
                venta.totalVenta = Convert.ToDecimal(txtTotalVenta.Text);
                venta.fecha = Convert.ToDateTime(dateTimePicker1.Text);
                ventas.save(venta);

                ClsDDetalle detalles = new ClsDDetalle();
                tb_detalleVenta detalle = new tb_detalleVenta();
                foreach (DataGridViewRow dtg in DtgVenta.Rows)
                {
                    detalle.idVenta = Convert.ToInt32(txtNumeroDoc.Text);
                    detalle.idProducto = Convert.ToInt32(dtg.Cells[0].Value.ToString());
                    detalle.precio = Convert.ToDecimal(dtg.Cells[2].Value.ToString());
                    detalle.cantidad = Convert.ToInt32(dtg.Cells[3].Value.ToString());
                    detalle.total = Convert.ToDecimal(dtg.Cells[4].Value.ToString());
                    detalles.guardardetalleventa(detalle);
                }
                ultimocorrelativoventa();
                DtgVenta.Rows.Clear();
                txtTotalVenta.Text = "";
                txtCantidad.Text = "";
                MessageBox.Show("save");
            }
            catch (Exception error)
            {
                MessageBox.Show("error : " + error);
            }
        }

        private void DtgVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcularsuma();
            
        }
    }
}

