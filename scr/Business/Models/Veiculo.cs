using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Veiculo : Entity
    {
        Modelo Modelo { get; set; }
        public int AnoFabricaco { get; set; }
        public int AnoModelo { get; set; }
    }
}
