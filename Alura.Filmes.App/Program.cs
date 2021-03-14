using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
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

                var filme = contexto
                    .Filmes
                    .Include(f => f.Atores)
                    .ThenInclude(fa => fa.Ator)
                    .First();

                Console.WriteLine("Exibindo elenco: \n");
                foreach (var ator in filme.Atores)
                {
                    Console.WriteLine(ator.Ator);
                }
            }
        }
    }
}