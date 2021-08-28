using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.Aula02.Exemplo01.Models
{
    /**
     * Criar uma página para cadastro -> Utilizando tag-Helpers
     * Controller -> private static IList<Planeta> _banco;
     * Criar uma página listar os planetas!
     */
    public class Planeta
    {
        public string Nome { get; set; }
        public string DataDescoberta { get; set; }
        public bool Habitavel { get; set; }
        public int TempoRotacao { get; set; }

        public override string ToString()
        {
            return $"{Nome}\r\n Data de descoberta: {DataDescoberta}\r\n Habitavel: {Habitavel}";
        }
    }
}
