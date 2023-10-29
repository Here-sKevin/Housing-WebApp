using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWEB_2324.Models
{
    public class ClientModel
    {
        [Key]
        public int Client_Id { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Inserir nome do Cliente")]
        [Display(Name = "Nome")]
        public string? Client_Name { get; set; }
        [ForeignKey("ImovelModel")]
        public int Imovel_Id { get; set; }

    }
}
