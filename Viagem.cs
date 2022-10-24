using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransporte
{
    public class Viagem
    {
        public string EnderecoAtual;
        public string destino;
        public string TipoDeCarro;
        
        public string MostrarDestino()
        {
            Console.WriteLine("Por Favor, Digite Seu Endereço de Destino: ");
            return destino;
        }
        
        public string EscolherCarro()
        {
            string Resposta;
            Console.WriteLine("Escolha o tipo de carro: 1 para EasyTrip e 2 para EasyConfort. Digite /help saber mais");
            Resposta = Console.ReadLine();
            {
                if (TipoDeCarro  == "1")
                {
                    TipoDeCarro = "Seu Carro escolhido Foi EasyCar";
                }
                else
                {
                    TipoDeCarro = "Seu Carro escolhido foi EasyConfort";
                }
                return TipoDeCarro;
            }
        }
        public string CancelarCorrida()
        {
            string Resposta;
            Console.WriteLine("Você quer cancelar essa corrida? digite s ou n");
            Resposta = Console.ReadLine();
            if (Resposta == "s")
            {
                return "Que pena! Esperamos que a EasyTrip possa te ajudar numa próxima vez!";
            }
            else
                return "Obrigado por confiar na EasyTrip! Esperamos que faça uma Boa Viagem!";
        }
        public string AceitarCorrida()
        {
            string Resposta;
            Console.WriteLine("Você aceita essa corrida? digite s ou n");
            Resposta = Console.ReadLine();
            if (Resposta == "s")
            {
                return "Obrigado por confiar na EasyTrip! Esperamos que faça uma Boa Viagem!";
            }
            else
            {
                return "Que pena! Esperamos que a EasyTrip possa te ajudar numa próxima vez!";
            }
        }
    }
    
}

   


       
