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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            cargar();
            LimpiarTextBox();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "")
            {
                ClsCRUDUsuario ClsUser = new ClsCRUDUsuario();
                ClsUser.Guardar(TxtEmail.Text, TxtPass.Text);
            }
            else
            {
                ClsCRUDUsuario ClsUser = new ClsCRUDUsuario();
                tb_usuario user = new tb_usuario();
                user.iDUsuario = Convert.ToInt32(TxtId.Text);
                user.email = TxtEmail.Text;
                user.contrasena = TxtPass.Text;
                ClsUser.Modificar(user);
            }
            cargar();
            LimpiarTextBox();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ClsCRUDUsuario ClsUser = new ClsCRUDUsuario();
            ClsUser.Eliminar(Convert.ToInt32(TxtId.Text));
            cargar();
            LimpiarTextBox();
        }

        public void cargar()
        {
            dataGridView1.Rows.Clear();
            ClsCRUDUsuario ClsUser = new ClsCRUDUsuario();
            List<tb_usuario> lista = ClsUser.Mostrar();
            foreach (var ver in lista)
            {
                dataGridView1.Rows.Add(ver.iDUsuario, ver.email, ver.contrasena);
            }
        }

        public void LimpiarTextBox()
        {
            TxtId.Clear();
            TxtEmail.Clear();
            TxtPass.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Email = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Pass = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            TxtId.Text = id;
            TxtEmail.Text = Email;
            TxtPass.Text = Pass;

        }
    }
}
