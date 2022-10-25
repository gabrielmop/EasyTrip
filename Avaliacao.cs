using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransporte
{
    internal class Avaliacao
    {
        public int AvaliacaoViagem;

        public string AvaliarViagem()
        {
            Console.WriteLine("Por favor Avalie essa viagem com uma nota de 1 a 10");
            AvaliacaoViagem = Convert.ToInt32(Console.ReadLine());

            return $"Sua nota foi {AvaliacaoViagem}, Muito obrigado por usar o Easytrip";
        }

    }
}
