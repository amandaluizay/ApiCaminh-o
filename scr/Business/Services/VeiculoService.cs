using Business.Interfaces;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class VeiculoService : BaseService, IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository, INotificador notificador) : base(notificador)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task Adicionar(Veiculo veiculo)
        {
            //if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _veiculoRepository.Adicionar(veiculo);
        }

        public async Task Atualizar(Veiculo veiculo)
        {
            //if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _veiculoRepository.Atualizar(veiculo);
        }

        public async Task Remover(Guid id)
        {

            await _veiculoRepository.Remover(id);
        }

        public void Dispose()
        {
            _veiculoRepository?.Dispose();
        }
    }
}
