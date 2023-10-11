using System.ComponentModel.DataAnnotations;

namespace APItodoList.Model
{
    public class ItensListaModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string NomeTarefa { get; set; }
        [Required]
        public string DescricaoTarefa { get; set; }
    }
}
