using appVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appVenta.DAO
{
    class ClsCRUDUsuario
    {
        public void Guardar(string Email, string Pass)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_usuario user = new tb_usuario();
                try
                {
                    user.email = Email;
                    user.contrasena = Pass;

                    db.tb_usuario.Add(user);
                    db.SaveChanges();

                    MessageBox.Show("Se ah Ingresado Un Nuevo Usuario");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e);
                }
            }
        }

        public void Modificar(tb_usuario usuario)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_usuario user = db.tb_usuario.Where(x => x.iDUsuario == usuario.iDUsuario).Select(x => x).FirstOrDefault();
                user.email = usuario.email;
                user.contrasena = usuario.contrasena;
                
                db.SaveChanges();

                MessageBox.Show("Se han realizado los cambios");
            }
        }

        public void Eliminar(int Id)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_usuario user = db.tb_usuario.Where(x => x.iDUsuario == Id).Select(x => x).FirstOrDefault();

                db.tb_usuario.Remove(user);
                db.SaveChanges();
            }
        }

        public List<tb_usuario> Mostrar()
        {
            List<tb_usuario> lista;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                lista = db.tb_usuario.ToList();
            }

            return lista;
        }
    }
}
