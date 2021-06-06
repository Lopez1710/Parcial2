using appVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVenta.DAO
{
    class ClsDDetalle
    {
        public void guardardetalleventa(tb_detalleVenta detalles)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_detalleVenta detalle = new tb_detalleVenta();
                detalle.idVenta = detalles.idVenta;
                detalle.idProducto = detalles.idProducto;
                detalle.cantidad = detalles.cantidad;
                detalle.precio = detalles.precio;
                detalle.total = detalles.total;
                db.tb_detalleVenta.Add(detalle);
                db.SaveChanges();
            }

        }
    }
}
