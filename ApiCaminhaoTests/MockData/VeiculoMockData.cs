using ApiCaminhao.ViewModels;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCaminhaoTests.MockData
{
    public class VeiculoMockData
    {
        public static List<Veiculo> GetVeiculos()
        {
            return new List<Veiculo>{
             new Veiculo{
                 Id = new Guid(),
                 AnoFabricaco = 2010,
                 AnoModelo = 2011
             },
             new Veiculo{
                 Id = new Guid(),
                 AnoFabricaco = 2013,
                 AnoModelo = 2014
             },
             new Veiculo{
                 Id = new Guid(),
                AnoFabricaco = 2016,
                AnoModelo = 2015
             }
         };

        }

        public static List<VeiculoViewModel> GetEmptyVeiculos()
        {
            return new List<VeiculoViewModel>();
        }

        public static Veiculo NewVeiculo()
        {
            return new Veiculo
            {
                Id = new Guid(),
                AnoFabricaco = 2013,
                AnoModelo = 2014
            };
        }

    }
}
