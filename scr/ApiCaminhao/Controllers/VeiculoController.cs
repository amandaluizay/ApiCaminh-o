using ApiCaminhao.ViewModels;
using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiCaminhao.Controllers
{
    [Route("api/categoria")]
    public class VeiculoController : MainController
    {
        private readonly IVeiculoRepository _repository;
        private readonly IVeiculoService _service;
        private IMapper _mapper;

        public VeiculoController(IVeiculoRepository veiculoRepository, IVeiculoService veiculoService,
            IMapper mapper, INotificador notificador) : base(notificador)
        {
            _repository = veiculoRepository;
            _service = veiculoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<VeiculoViewModel>> ObterTodos()
        {
            var veiculo = _mapper.Map<IEnumerable<VeiculoViewModel>>(await _repository.ObterTodos());
            return veiculo;
        }


        [HttpGet("{id:guid}")]
        // [Authorize]
        public async Task<ActionResult<VeiculoViewModel>> ObterpPorId(Guid id)
        {
            var categoria = _mapper.Map<VeiculoViewModel>(await _repository.ObterPorId(id));

            if (categoria == null) return NotFound();

            return categoria;
        }


        [HttpPost]
        public async Task<ActionResult<VeiculoViewModel>> Adicionar(VeiculoViewModel veiculo)
        {
            if (!ModelState.IsValid) return CostumResponse(ModelState);


            return CostumResponse(veiculo);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<VeiculoViewModel>> Atualizar(Guid id, VeiculoViewModel veiculo)
        {
            if (id != veiculo.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CostumResponse(veiculo);
            }

            if (!ModelState.IsValid) return CostumResponse(ModelState);

            await _service.Atualizar(_mapper.Map<Veiculo>(veiculo));

            return CostumResponse(veiculo);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<VeiculoViewModel>> Excluir(Guid id)
        {
            var categoriaViewModel = _mapper.Map<VeiculoViewModel>(await _repository.ObterPorId(id));

            if (categoriaViewModel == null) return NotFound();

            await _repository.Remover(id);

            return CostumResponse(categoriaViewModel);
        }






    }
}
