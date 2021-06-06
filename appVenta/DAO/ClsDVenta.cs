using appVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVenta.DAO
{
    class ClsDVenta
    {
        public List<tb_venta> Ultimaventa()
        {
            List<tb_venta> lista;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                lista = db.tb_venta.ToList();
            }
                return lista;
        }

        public void save(tb_venta ventas)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_venta venta = new tb_venta();
                venta.iDDocumento = ventas.iDDocumento;
                venta.iDCliente = ventas.iDCliente;
                venta.iDUsuario = ventas.iDUsuario;
                venta.totalVenta = ventas.totalVenta;
                venta.fecha = ventas.fecha;
                db.tb_venta.Add(venta);
                db.SaveChanges();
            }
        }
    }
}
