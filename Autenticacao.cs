using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Autenticacao
    {
        static string usuario;
        static string senha;
        static string nivel;

        public static void login(string usuario1, string senha1, string nivel1)
        {
            usuario = usuario1;
            senha = senha1;
            nivel = nivel1;
        }

        public static void logout()
        {
            usuario = null;
            senha = null;
        }

        public static String getUsuario()
        {
            return usuario; 
            //return "Nome: " + usuario + "\nSenha: " + senha;
        }

        public static String getNivel()
        {
            return nivel;
        }
    }
}
