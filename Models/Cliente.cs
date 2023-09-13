using System.ComponentModel.DataAnnotations;

namespace ThomasGregDesafio.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Email { get; set; }
        public byte[] Logotipo { get; set; }


        public ICollection<Logradouro> Logradouros { get; set; }


    }
}
