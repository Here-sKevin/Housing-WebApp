using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWEB_2324.Models
{
    [Table("Imoveis")]
    public class ImoveisModel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "O tamanho máximo é de 50 caracteres")]
        [Required(ErrorMessage = "Inserir nome do imovel")]
        [Display(Name="Nome")]
        public string? Name { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Inserir descrição do imovel")]
        [Display(Name = "Descrição")]
        public string? Description { get; set; }
        public string? Type { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsModified { get; set; }
        public string? Price {  get; set; }
        public string? ImageUrl { get; set; }
        public string? Location { get; set; }
        public string? Rooms { get; set; }
        public string? WC { get; set; }
        public string? Area { get; set; }
        public bool Parking { get; set; }
        public int Parking_Spots { get; set; }
        public int Energy_type { get; set; }
        public bool Available { get; set; }

    }
}
