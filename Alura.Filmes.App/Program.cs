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
                    .Include(f => f.Categorias)
                    .ThenInclude(fc => fc.Categoria)
                    .First();

                Console.WriteLine("Exibindo categorias: \n");
                foreach (var categoria in filme.Categorias)
                {
                    Console.WriteLine(categoria.Categoria);
                }
            }
        }
    }
}