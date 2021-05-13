using appVenta.DAO;
using appVenta.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click_1(object sender, EventArgs e)
        {
            ClsAcceso acces = new ClsAcceso();
            int valor = acces.acceso(txtUser.Text, txtPass.Text);

            if (valor == 1)
            {
                MessageBox.Show("Welcome");
                FrmPadre frm = new FrmPadre();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Denegado");
            }
        }
    }
}
