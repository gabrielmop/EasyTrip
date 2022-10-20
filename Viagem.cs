using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransporte
{
    internal class Viagem
    {
        public string EnderecoAtual;
        public string destino;
        public string TipoDeCarro;

        public string ConfirmarEndereçoAtual()
        {
            string Resposta;
            do
            {
                Console.WriteLine("Por Favor, Digite Seu endereço Atual");
                EnderecoAtual = Console.ReadLine();
                Console.WriteLine($"Seu endereço Atual é {EnderecoAtual}, isso está certo? Digite s ou n");
                Resposta = Console.ReadLine();
            } while (Resposta == "n");
            return $"Endereço Confirmado como:  {EnderecoAtual}";
        }

        public string MostrarEnderecoAtual()
        {
            return EnderecoAtual;
        }

        public string ConfirmarDestino()
        {
            string Resposta;
            do
            {
                Console.WriteLine("Por Favor, Digite Seu Endereço de Destino: ");
                destino = Console.ReadLine();
                Console.WriteLine($"Seu Endereço de Destino é {destino}, isso está certo? Digite s ou n");
                Resposta = Console.ReadLine();
            } while (Resposta == "n");
            return $"Endereço de Destino Confirmado como:  {destino}";
        }

        public string EscolherCarro()
        {
           string Resposta;
            Console.WriteLine("Escolha o tipo de carro: 1 para EasyTrip e 2 para EasyConfort. Digite /help saber mais");
            Resposta = Console.ReadLine();
            if (Resposta == "1")
            {
                return "Seu Carro escolhido Foi EasyCar";
            }else
           
            {
                return "Seu Carro escolhido foi EasyConfort";
            }


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
                return "Que pena! Esperamos que a EasyTrip possa te ajudar numa próxima vez!";
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
    }
}
