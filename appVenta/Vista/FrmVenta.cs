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

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var consultacliente = db.tb_cliente.ToList();

                comboBox2.DataSource = consultacliente;
                comboBox2.DisplayMember = "nombreCliente";
                comboBox2.ValueMember = "iDCliente";

                var consultadoumento = (from documento in db.tb_documento
                                        select new
                                        {
                                            documento.iDDocumento,
                                            documento.nombreDocumento
                                        }).ToList();
                comboBox1.DataSource = consultadoumento;
                comboBox1.DisplayMember = "nombreDocumento";
                comboBox1.ValueMember = "iDDocumento";
            }
        }
    }
}
