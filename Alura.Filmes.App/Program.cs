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
           using(var contexto = new AluraFilmesContext())
            {
                contexto.LogSQLToConsole();

                var filme = new Filme();
                filme.Titulo = "Senhor dos Anéis";
                filme.Duracao = 120;
                filme.AnoLancamento = "2000";
                filme.Classificacao = "Qualquer";
                filme.IdiomaFalado = contexto.Idiomas.FirstOrDefault();

                contexto.Filmes.Add(filme);
                contexto.SaveChanges();
            }
        }
    }
}