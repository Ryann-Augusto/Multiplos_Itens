using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Multiplos_Itens.Models
{
    public class Produtos
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Esse campo é obrigatorio")]
        public string Nome { get; set; }

    }
}
