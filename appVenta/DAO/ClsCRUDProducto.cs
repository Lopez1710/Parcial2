using appVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVenta.DAO
{
    class ClsCRUDProducto
    {
        public void Guardar(string Nombre, string Precio, string EstadoProduc)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_producto producto = new tb_producto();
                try{
                    producto.nombreProducto = Nombre;
                    producto.precioProducto = Precio;
                    producto.estadoProducto = EstadoProduc;

                    db.tb_producto.Add(producto);
                    db.SaveChanges();

                    MessageBox.Show("Se ah Ingresado Un Nuevo Producto");
                }
                catch(Exception e)
                {
                    MessageBox.Show("Error: "+e);
                }
            }
        }

        public void Modificar(tb_producto producto)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_producto product = db.tb_producto.Where(x => x.idProducto == producto.idProducto).Select(x => x).FirstOrDefault();
                product.nombreProducto = producto.nombreProducto;
                product.precioProducto = producto.precioProducto;
                product.estadoProducto = producto.estadoProducto;

                db.SaveChanges();

                MessageBox.Show("Se han realizado los cambios");
            }
        }

        public void Eliminar(int Id)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_producto product = db.tb_producto.Where(x => x.idProducto == Id).Select(x => x).FirstOrDefault();

                db.tb_producto.Remove(product);
                db.SaveChanges();
            }
        }

        public List<tb_producto> Mostrar()
        {
            List<tb_producto> lista;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                lista = db.tb_producto.ToList();
            }

            return lista;
        }
    }
}
