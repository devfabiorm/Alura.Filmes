using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
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
                var categ = "Action";
                var paramCateg = new SqlParameter("category_name", categ);

                var paramTotal = new SqlParameter
                {
                    ParameterName = "@total_actors",
                    Size = 4,
                    Direction = System.Data.ParameterDirection.Output
                };

                contexto.Database.ExecuteSqlCommand("total_actors_from_given_category @category_name, @total_actors OUT", paramCateg, paramTotal);

                Console.WriteLine($"O número total de atores que atuaram na categoria {categ} é de {paramTotal.Value} atores.");
            }
        }
    }
}