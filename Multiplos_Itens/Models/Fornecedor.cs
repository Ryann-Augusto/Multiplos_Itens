using System.ComponentModel.DataAnnotations;

namespace Multiplos_Itens.Models
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Produtos>? Produtos { get; set; }
    }
}
