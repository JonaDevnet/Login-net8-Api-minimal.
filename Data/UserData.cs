using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using acceso;
using Models;

namespace Data
{
    public class UserData
    {
        Acces acces;

        public UserData()
        {
            acces = new Acces(); // nueva instancia de la acceso
        }

        public bool login(Usuario usuario)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM Usuario WHERE Nombre = {usuario.Nombre} AND Pass = {usuario.Pass}";
                if (usuario != null)
                {
                    bool flag = acces.Escribir(query);
                    if (flag != false)
                    {
                        return true;
                    }                   
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
