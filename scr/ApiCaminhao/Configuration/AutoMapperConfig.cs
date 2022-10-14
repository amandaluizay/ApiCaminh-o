using ApiCaminhao.ViewModels;
using AutoMapper;
using Business.Models;

namespace ApiCaminhao.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Veiculo, VeiculoViewModel>().ReverseMap();
        }
    }
}
