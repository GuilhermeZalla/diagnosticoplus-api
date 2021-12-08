using System.Collections.Generic;

namespace APITCC2021.Models
{
    public class Doenca
    {
        public Doenca(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public ICollection<AssociacaoDoencaSintoma> AssociacaoDoencasSintomas { get; set; } = new List<AssociacaoDoencaSintoma>();
    }
}
