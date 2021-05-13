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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "")
            {
                ClsCRUDCliente ClsCli = new ClsCRUDCliente();
                ClsCli.Guardar(TxtNombre.Text, TxtDireccion.Text, TxtDui.Text);
            }
            else
            {
                ClsCRUDCliente ClsCli = new ClsCRUDCliente();
                tb_cliente Cliente = new tb_cliente();
                Cliente.iDCliente = Convert.ToInt32(TxtId.Text);
                Cliente.nombreCliente = TxtNombre.Text;
                Cliente.direccionCliente = TxtDireccion.Text;
                Cliente.duiCliente = TxtDui.Text;
                ClsCli.Modificar(Cliente);
            }
            cargar();
            LimpiarTextBox();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ClsCRUDCliente ClsCli = new ClsCRUDCliente();
            ClsCli.Eliminar(Convert.ToInt32(TxtId.Text));
            cargar();
            LimpiarTextBox();
        }

        public void cargar()
        {
            dataGridView1.Rows.Clear();
            ClsCRUDCliente ClsCli = new ClsCRUDCliente();
            List<tb_cliente> lista = ClsCli.Mostrar();
            foreach (var ver in lista)
            {
                dataGridView1.Rows.Add(ver.iDCliente, ver.nombreCliente, ver.direccionCliente, ver.duiCliente);
            }
        }

        public void LimpiarTextBox()
        {
            TxtId.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtDui.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Direccion = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string DUI = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            TxtId.Text = id;
            TxtNombre.Text = Nombre;
            TxtDireccion.Text = Direccion;
            TxtDui.Text = DUI;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            cargar();
            LimpiarTextBox();
        }
    }
}
