using System.ComponentModel.DataAnnotations;

namespace ApiCaminhao.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        public int Modelo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(4, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 4)]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(4, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 4)]
        public int AnoModelo { get; set; }

    

       
    }
}
