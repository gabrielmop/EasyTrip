using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransporte
{
    public class Aplicativo
    {
        public string NomeAPP;
        public string NomeUsuario;

        public string MostrarNomeApp()
        {
            NomeAPP = "EasyTrip";
            return $"Seja Bem Vindo Ao {NomeAPP}!";
        }

            public string ConfirmarNomeUsuario()
        {
            string Resposta;
                      
                Console.WriteLine("Digite seu Nome de Usuário: "); 
                NomeUsuario = Console.ReadLine();
                          
            return $"Seja Bem vindo ao EasyTrip {NomeUsuario}";
           
           
        }

        public string MostrarNomeUsuario()
        {
            return NomeUsuario;
        }


    }
}
