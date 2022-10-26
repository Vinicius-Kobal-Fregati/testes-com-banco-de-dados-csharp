using Alura.ByteBank.Infraestrutura.Testes.Servico.DTO;
using System;

namespace Alura.ByteBank.Infraestrutura.Testes.Servico
{
    public interface IPixRepositorio
    {
        public PixDTO consultaPix(Guid pix);
    }
}
