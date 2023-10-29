using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWEB_2324.Models
{
    public class ManagerModel
    {
        [Key]
        public int Manager_Id { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Inserir nome do Locator")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }
        [ForeignKey("AdminModel")]
        public int Admin_Id { get; set; }
    }
}
