using System;

namespace AppTransporte
{
    public class Program
    {
        private static object resposta;

        static void Main(string[] args)
        {
            Aplicativo App = new Aplicativo();
            Viagem Viagem = new Viagem();
            Avaliacao Avaliação = new Avaliacao();
            Dados Dados = new Dados();

            Console.WriteLine(App.MostrarNomeApp());

            Console.WriteLine(App.ConfirmarNomeUsuario());

            Console.WriteLine(Dados.ConfirmarEndereçoAtual());

            Console.WriteLine(Dados.ConfirmarDestino());

            Console.WriteLine(Viagem.EscolherCarro());

            Console.WriteLine(Viagem.AceitarCorrida());

            Console.WriteLine(Viagem.CancelarCorrida());

            Console.WriteLine(Avaliação.AvaliarViagem());


        }
    }
}
