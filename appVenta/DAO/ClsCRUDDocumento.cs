using appVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVenta.DAO
{
    class ClsCRUDDocumento
    {
        public void Guardar(string Documento)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_documento doc = new tb_documento();
                try
                {
                    doc.nombreDocumento = Documento;
                    
                    db.tb_documento.Add(doc);
                    db.SaveChanges();

                    MessageBox.Show("Se ah Ingresado Un Nuevo Documento");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e);
                }
            }
        }

        public void Modificar(tb_documento documento)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_documento doc = db.tb_documento.Where(x => x.iDDocumento == documento.iDDocumento).Select(x => x).FirstOrDefault();
                doc.nombreDocumento = documento.nombreDocumento;
                
                db.SaveChanges();

                MessageBox.Show("Se han realizado los cambios");
            }
        }

        public void Eliminar(int Id)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_documento doc = db.tb_documento.Where(x => x.iDDocumento == Id).Select(x => x).FirstOrDefault();

                db.tb_documento.Remove(doc);
                db.SaveChanges();
            }
        }

        public List<tb_documento> Mostrar()
        {
            List<tb_documento> lista;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                lista = db.tb_documento.ToList();
            }

            return lista;
        }

    }
}
