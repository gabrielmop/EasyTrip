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
            int resposta1;


            


            do
            {
                Console.Clear();
                Console.WriteLine(App.MostrarNomeApp());

                Console.WriteLine(App.ConfirmarNomeUsuario());


                Console.WriteLine(Dados.ConfirmarEndereçoAtual());

                Console.WriteLine(Dados.ConfirmarDestino());

                Console.WriteLine(Viagem.EscolherCarro());

                Console.Clear();


                Console.WriteLine($"Nome: {App.MostrarNomeUsuario()}");
                Console.WriteLine($"Endereço: {Dados.EnderecoAtual}");
                Console.WriteLine($"Destino: {Dados.destino}");
                Console.WriteLine(Viagem.TipoDeCarro);

                Console.WriteLine();
                Console.WriteLine("Esses dados estão corretos? digite 1 para sim e 2 para não");
                resposta1 = Convert.ToInt32(Console.ReadLine());



            } while (resposta1 == 2);

            int resposta;

            Console.WriteLine("Você deseja confirmar essa corrida? digite 1 para sim e 2 para não");
            resposta = Convert.ToInt32(Console.ReadLine());
            if (resposta == 1)
            {
                Console.WriteLine(Viagem.AceitarCorrida());
                Console.WriteLine(Avaliação.AvaliarViagem());
            }
            if (resposta == 2)
            {
                Console.WriteLine(Viagem.CancelarCorrida());
            }
            
            
        

            


        }
    }
}
