using Alura.ByteBank.Dados.Repositorio;
using Alura.ByteBank.Dominio.Entidades;
using Alura.ByteBank.Dominio.Interfaces.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using Xunit;

namespace Alura.ByteBank.Infraestrutura.Testes
{
    public class ClienteRepositorioTestes
    {
        private readonly IClienteRepositorio _repositorio;
        public ClienteRepositorioTestes() // Inversão de dependência
        {
            var servico = new ServiceCollection();
            servico.AddTransient<IClienteRepositorio, ClienteRepositorio>();
            var provedor = servico.BuildServiceProvider();
            _repositorio = provedor.GetService<IClienteRepositorio>();
        }
        
        [Fact]
        public void TestaObterTodosClientes()
        {
            //Arrange
            //Act
            List<Cliente> lista = _repositorio.ObterTodos();

            //Assert
            Assert.NotNull(lista);
            Assert.Equal(6, lista.Count);
        }

        [Fact]
        public void TestaObterClientePorId()
        {
            //Arrange
            //Act
            var cliente = _repositorio.ObterPorId(1);

            //Assert
            Assert.NotNull(cliente);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void TestaObterClientesPorVariosId(int id)
        {
            //Arrange
            //Act
            var cliente = _repositorio.ObterPorId(id);

            //Assert
            Assert.NotNull(cliente);
        }
    }
}
