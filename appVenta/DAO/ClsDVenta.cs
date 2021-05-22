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
    }
}
