using System.Collections.Generic;

namespace APITCC2021.Models
{
    public class Sintoma
    {
        public Sintoma(string nome)
        {
            Nome = nome;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<AssociacaoDoencaSintoma> AssociacaoDoencasSintomas { get; set; } = new List<AssociacaoDoencaSintoma>();
    }
}
