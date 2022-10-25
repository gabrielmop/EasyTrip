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
            Console.WriteLine("Escolha o tipo de carro: 1 para EasyTrip e 2 para EasyConfort.");
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
           return "Que pena! Esperamos que a EasyTrip possa te ajudar numa próxima vez!";
        }
        public string AceitarCorrida()
        {
            return "Obrigado por confiar na EasyTrip! Esperamos que faça uma Boa Viagem!";
                    
           
        }
    }
    
}

   


       
