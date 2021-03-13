using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using System;

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

                var ator = new Ator
                {
                    PrimeiroNome = "Tom",
                    UltimoNome = "Hanks"
                };

                contexto.Atores.Add(ator);

                contexto.SaveChanges();
            }
        }
    }
}