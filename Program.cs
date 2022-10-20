using System;

namespace AppTransporte
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aplicativo App = new Aplicativo();
            Viagem Viagem = new Viagem();
            Avaliacao Avaliação = new Avaliacao();

            Console.WriteLine(App.MostrarNomeApp());

                   
            Console.WriteLine(App.ConfirmarNomeUsuario());

            Console.WriteLine(Viagem.ConfirmarEndereçoAtual());
            
            Console.WriteLine(Viagem.ConfirmarDestino());

            Console.WriteLine(Viagem.EscolherCarro());

            Console.WriteLine(Viagem.AceitarCorrida());

            Console.WriteLine(Viagem.CancelarCorrida());

            Console.WriteLine(Avaliação.AvaliarViagem());
            

        }
    }
}
