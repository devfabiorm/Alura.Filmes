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

                Console.WriteLine("Clientes:");
                foreach (var cliente in contexto.Clientes)
                {
                    Console.WriteLine(cliente);
                }

                Console.WriteLine("\nFuncionários");
                foreach (var func in contexto.Funcionarios)
                {
                    Console.WriteLine(func);
                }
            }
        }
    }
}