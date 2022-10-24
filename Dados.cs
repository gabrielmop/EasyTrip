using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransporte
{
    public class Dados
    {
        public string EnderecoAtual;
        public string destino;

       
        public string ConfirmarEndereçoAtual()
        {
            string Resposta;

            {
                do
                {
                    Console.WriteLine($"Por favor digite seu endereço atual: ");
                    EnderecoAtual = Console.ReadLine();
                    Console.WriteLine("Está Correto?(s/n)");
                    Resposta = Console.ReadLine();
                } while (Resposta != "s");
            }
            return ("");
        }
        public string ConfirmarDestino()
        {
            string Resposta;

            {
                do
                {
                    Console.WriteLine($"Por favor confirme seu endereço de destino: ");
                    destino = Console.ReadLine();
                    Console.WriteLine("Está Correto?(s/n)");
                    Resposta = Console.ReadLine();
                } while (Resposta != "s");
            }
            return ("");
        }
    }
}
