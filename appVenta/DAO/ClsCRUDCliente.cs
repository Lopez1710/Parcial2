using appVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVenta.DAO
{
    class ClsCRUDCliente
    {
        public void Guardar(string Nombre, string Direccion, string DUI)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_cliente cliente = new tb_cliente();
                try
                {
                    cliente.nombreCliente = Nombre;
                    cliente.direccionCliente = Direccion;
                    cliente.duiCliente = DUI;

                    db.tb_cliente.Add(cliente);
                    db.SaveChanges();

                    MessageBox.Show("Se ah Ingresado Un Nuevo Cliente");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e);
                }
            }
        }

        public void Modificar(tb_cliente cliente)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_cliente client = db.tb_cliente.Where(x => x.iDCliente == cliente.iDCliente).Select(x => x).FirstOrDefault();
                client.nombreCliente = cliente.nombreCliente;
                client.direccionCliente = cliente.direccionCliente;
                client.duiCliente = cliente.duiCliente;

                db.SaveChanges();

                MessageBox.Show("Se han realizado los cambios");
            }
        }

        public void Eliminar(int Id)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_cliente client = db.tb_cliente.Where(x => x.iDCliente == Id).Select(x => x).FirstOrDefault();

                db.tb_cliente.Remove(client);
                db.SaveChanges();
            }
        }

        public List<tb_cliente> Mostrar()
        {
            List<tb_cliente> lista;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                lista = db.tb_cliente.ToList();
            }

            return lista;
        }
    }
}
