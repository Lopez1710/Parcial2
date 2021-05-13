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
    public partial class FrmDocumento : Form
    {
        public FrmDocumento()
        {
            InitializeComponent();
        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {
            cargar();
            LimpiarTextBox();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "")
            {
                ClsCRUDDocumento ClsDoc = new ClsCRUDDocumento();
                ClsDoc.Guardar(TxtDocumento.Text);
            }
            else
            {
                ClsCRUDDocumento ClsDoc = new ClsCRUDDocumento();
                tb_documento documento = new tb_documento();
                documento.iDDocumento = Convert.ToInt32(TxtId.Text);
                documento.nombreDocumento = TxtDocumento.Text;

                ClsDoc.Modificar(documento);
            }
            cargar();
            LimpiarTextBox();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ClsCRUDDocumento ClsDoc = new ClsCRUDDocumento();
            ClsDoc.Eliminar(Convert.ToInt32(TxtId.Text));
            cargar();
            LimpiarTextBox();
        }

        public void cargar()
        {
            dataGridView1.Rows.Clear();
            ClsCRUDDocumento ClsDoc = new ClsCRUDDocumento();
            List<tb_documento> lista = ClsDoc.Mostrar();
            foreach (var ver in lista)
            {
                dataGridView1.Rows.Add(ver.iDDocumento, ver.nombreDocumento);
            }
        }

        public void LimpiarTextBox()
        {
            TxtId.Clear();
            TxtDocumento.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Documento = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            TxtId.Text = id;
            TxtDocumento.Text = Documento;
        }
    }
}
