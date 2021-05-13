using appVenta.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVenta.DAO
{
    class ClsAcceso
    {
        public int acceso(string user,string pass)
        {
            int variabledeacceso = 0;
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var consulta = from usuario in db.tb_usuario
                               where usuario.email == user &&
                               usuario.contrasena == pass
                               select usuario;
                if (consulta.Count() > 0)
                {
                    variabledeacceso = 1;
                }
            }


            return variabledeacceso;

        }
    }
}
