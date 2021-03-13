using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //select * from actor

            using (var contexto = new AluraFilmesContext())
            {
                contexto.LogSQLToConsole();
                foreach (var ator in contexto.Atores)
                {
                    System.Console.WriteLine(ator);
                }
            }
        }
    }
}