using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWEB_2324.Models
{
    [Table("Imovel")]
    public class ImovelModel
    {
        [Key]
        public int Imovel_Id { get; set; }
        [StringLength(50, ErrorMessage = "O tamanho máximo é de 50 caracteres")]
        [Required(ErrorMessage = "Inserir nome do imovel")]
        [Display(Name="Title")]
        public string? Title { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Inserir descrição do imovel")]
        [Display(Name = "Descrição")]
        public string? Description { get; set; }
        [StringLength(20, ErrorMessage = "O tamanho máximo é de 20 caracteres")]
        [Required(ErrorMessage = "Inserir tipologia do imovel")]
        [Display(Name = "Tipologia")]
        public string? Type { get; set; }
        [Required(ErrorMessage = "Inserir preço do imovel")]
        [Display(Name = "Preço")]
        public int Price { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Inserir Imagem do imovel")]
        [Display(Name = "Imagem")]
        public string? Image {  get; set; }
        [StringLength(50, ErrorMessage = "O tamanho máximo é de 50 caracteres")]
        [Required(ErrorMessage = "Inserir localização do imovel")]
        [Display(Name = "Localização")]
        public string? Location { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Inserir tipo do imovel")]
        [Display(Name = "Tipo")]
        public string? Property { get; set; }
        [Required(ErrorMessage = "Inserir quantidade de WC do imovel")]
        [Display(Name = "WC")]
        public int Wc {  get; set; }

        [Display(Name = "Eficiencia Energetica")]
        public char Energy { get; set; }
        [Required(ErrorMessage = "Inserir data inicio do contrato")]
        [Display(Name = "Inicio do Contrato")]
        public DateTime Date_init { get; set; }

        [Required(ErrorMessage = "Inserir data do fim do contrato")]
        [Display(Name = "Fim do contrato")]
        public DateTime Data_end { get; set; }
        [Required(ErrorMessage = "Inserir tempo minimo do contrato")]
        [Display(Name = "Descrição")]
        public int Min_Time { get; set; }
        [ForeignKey("EmployeeModel")]
        public int Func_Id { get; set; }
        

    }
}
