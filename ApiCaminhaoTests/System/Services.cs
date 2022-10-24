using System;
using System.Linq;
using System.Threading.Tasks;
using ApiCaminhaoTests.MockData;
using Business.Interfaces;
using Business.Services;
using c;
using Data.Repository;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace ApiCaminhaoTests.System
{
    public class TestVeiculoService : IDisposable
    {
        protected readonly MeuDbContext _context;
        public TestVeiculoService()
        {
            var options = new DbContextOptionsBuilder<MeuDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

            _context = new MeuDbContext(options);

            _context.Database.EnsureCreated();
        }


        [Fact]
        public async Task GetAllAsync_ReturnVeiculoCollection()
        {
            /// Arrange
            var mockRepo = new Mock<IVeiculoRepository>();
            var mock = new Mock<INotificador>();
            _context.Veiculos.AddRange(VeiculoMockData.GetVeiculos());
            _context.SaveChanges();

            var sut = new VeiculoRepository(_context);

            /// Act
            var result = await sut.ObterTodos();

            /// Assert
            result.Should().HaveCount(VeiculoMockData.GetVeiculos().Count);
        }

        [Fact]
        public async Task SaveAsync_AddNewTodo()
        {
            /// Arrange
            var newVeiculo = VeiculoMockData.NewVeiculo();
            _context.Veiculos.AddRange(MockData.VeiculoMockData.GetVeiculos());
            _context.SaveChanges();

            var sut = new VeiculoRepository(_context);

            /// Act
            await sut.Adicionar(newVeiculo);

            ///Assert
            int expectedRecordCount = (VeiculoMockData.GetVeiculos().Count() + 1);
            _context.Veiculos.Count().Should().Be(expectedRecordCount);
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}

