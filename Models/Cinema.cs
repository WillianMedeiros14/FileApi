using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome � obrigat�rio.")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Sessao> Sessoes { get; set; }

    }
}