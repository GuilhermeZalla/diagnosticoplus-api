using System;

namespace APITCC2021.Models
{
    public class Diagnostico
    {
        public Diagnostico(string resultados, DateTime data, int usuarioId)
        {
            Resultados = resultados;
            Data = data;
            UsuarioId = usuarioId;
        }

        public int Id { get; set; }

        public string Resultados { get; set; }

        public DateTime Data { get; set; }

        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
