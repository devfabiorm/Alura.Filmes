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

                foreach (var item in contexto.Elenco)
                {
                    var entidade = contexto.Entry(item);
                    var filmeId = entidade.Property("film_id").CurrentValue;
                    var atorId = entidade.Property("actor_id").CurrentValue;
                    var Udt = entidade.Property("last_update").CurrentValue;

                    Console.WriteLine($"AtorId: {atorId} - FilmeId: {filmeId} - Atualizado: {Udt}");
                }
            }
        }
    }
}