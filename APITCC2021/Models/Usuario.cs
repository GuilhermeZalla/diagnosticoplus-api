using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APITCC2021.Models
{
    public class Usuario
    {
        public Usuario(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public ICollection<Diagnostico> Diagnosticos { get; set; } = new List<Diagnostico>();
    }
}