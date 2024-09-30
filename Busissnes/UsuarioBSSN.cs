using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busissnes
{
    public class UsuarioBSSN
    {
        UserData _data;
        Encrypter _encrypter;
        public UsuarioBSSN()
        {
            _data = new UserData();
            _encrypter = new Encrypter();
        }

        public bool Login(Usuario usuario)
        {
            try
            {
                if(usuario!= null)
                {
                    usuario.Pass = encrypter(usuario.Pass);
                    return _data.login(usuario);
                }
                else return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            
        }
        private string encrypter(string pass)
        {
            string hassPass = _encrypter.Encrypt(pass);
            return hassPass;
        }
    }
}
