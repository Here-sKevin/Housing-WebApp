using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWEB_2324.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Func_Id { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Inserir nome do Funcionario")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }
        [ForeignKey("ManagerModel")]
        public int Manager_Id { get; set; }
    }
}
