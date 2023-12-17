using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp.Pagamentos
{
    public class Pagamento
    {
        public Guid Id { get; }

        public decimal Valor { get; }

        public DateTime Data { get; }

        public Pagamento(decimal valor, DateTime data)
        {
            Id = Guid.NewGuid();
            Valor = valor;
            Data = data;
        }
    }
}
