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

            //var test = ClassificacaoIndicativa.MaioresQue10;

            //foreach(ClassificacaoIndicativa item in Enum.GetValues(typeof(ClassificacaoIndicativa)))
            //{
            //    Console.WriteLine(item.ParaString());
            //}


            using (var contexto = new AluraFilmesContext())
            {
                contexto.LogSQLToConsole();

                var filme = new Filme();
                filme.Titulo = "Cassino Royale";
                filme.Duracao = 120;
                filme.AnoLancamento = "2000";
                filme.Classificacao = ClassificacaoIndicativa.Livre;
                filme.IdiomaFalado = contexto.Idiomas.FirstOrDefault();

                contexto.Filmes.Add(filme);
                contexto.SaveChanges();

                var filmeEncontrado = contexto.Filmes.First(f => f.Titulo == "Cassino Royale");
                Console.WriteLine(filmeEncontrado.Classificacao);
            }
        }
    }
}