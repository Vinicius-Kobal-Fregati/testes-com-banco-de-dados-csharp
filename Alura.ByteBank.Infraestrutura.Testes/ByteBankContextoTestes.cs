using Alura.ByteBank.Dados.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Alura.ByteBank.Infraestrutura.Testes
{
    public class ByteBankContextoTestes
    {
        [Fact]
        public void TestaConexaoContextoComDBMySQL()
        {
            //Arrange
            var contexto = new ByteBankContexto();
            bool conectado;

            //Act
            try
            {
                conectado = contexto.Database.CanConnect(); // Retorna um booleano se consegue se conectar
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar a base de dados");
            }

            //Assert
            Assert.True(conectado);
        }
    }
}
