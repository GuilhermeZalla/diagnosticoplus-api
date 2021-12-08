namespace APITCC2021.Models
{
    public class AssociacaoDoencaSintoma
    {
        public AssociacaoDoencaSintoma(int doencaId, int sintomaId)
        {
            DoencaId = doencaId;
            SintomaId = sintomaId;
        }

        public int Id { get; set; }

        public Doenca Doenca { get; set; }
        public int DoencaId { get; set; }

        public Sintoma Sintoma { get; set; }
        public int SintomaId { get; set; }
    }
}
