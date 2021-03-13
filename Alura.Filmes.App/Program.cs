using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using System;
using System.Linq;

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

                var ator = contexto.Atores.First();
                Console.WriteLine(ator);
                Console.WriteLine(contexto.Entry(ator).Property("last_update").CurrentValue);
            }
        }
    }
}