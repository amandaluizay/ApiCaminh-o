using Business.Models;
using System.ComponentModel.DataAnnotations;

namespace ApiCaminhao.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        public int Modelo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int AnoModelo { get; set; }

        
    }
}
