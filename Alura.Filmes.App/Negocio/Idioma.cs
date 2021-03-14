using System.Collections.Generic;

namespace Alura.Filmes.App.Negocio
{
    public class Idioma
    {
        public byte Id { get; set; }
        public string Nome { get; set; }
        public IList<Filme> FilmesFalados { get; set; }
        public IList<Filme> FilmesOriginais { get; set; }

        public override string ToString()
        {
            return $"Idioma ({Id}): {Nome}";
        }
    }
}
