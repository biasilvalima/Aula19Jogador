using System;

namespace Aula18Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador Messi = new Jogador();
            Messi.Nome = "Lionel Messi";
            Messi.Posicao = "Atacante";

            //O Parse ja converte e a conta ja é feita automaticamente.
            Messi.DatadeNascimento = DateTime.Parse("24/06/1987");

            Messi.Dados();
            System.Console.WriteLine(Messi.CalcularIdade());

            System.Console.WriteLine();

            System.Console.WriteLine(Messi.CalcularAposentadoria());
        }
    }
}
