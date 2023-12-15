using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp
{
    public class Pagamento
    {
        public Guid Id { get; }

        public Reserva Reserva { get; }

        public decimal Valor { get; }

        public DateTime Data { get; }

        public Pagamento(Reserva reserva, decimal valor, DateTime data)
        {
            Id = Guid.NewGuid();
            Reserva = reserva;
            Valor = valor;
            Data = data;
        }
    }
}
