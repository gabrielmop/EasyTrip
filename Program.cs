using System;

namespace AppTransporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aplicativo App = new Aplicativo();
            Viagem Viagem = new Viagem();

            Console.WriteLine(App.MostrarNomeApp());

            //Console.WriteLine(App.ConfirmarNomeUsuario());

            //Console.WriteLine(Viagem.ConfirmarEndereçoAtual());

            Console.WriteLine(Viagem.EscolherCarro());

        }
    }
}
