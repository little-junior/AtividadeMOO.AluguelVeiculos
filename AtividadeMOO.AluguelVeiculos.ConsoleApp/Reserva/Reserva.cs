using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeMOO.AluguelVeiculos.ConsoleApp.Pagamentos;
using AtividadeMOO.AluguelVeiculos.ConsoleApp.Veiculos;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp.Reservas
{
    public class Reserva
    {
        public Guid Id { get; }
        public Veiculo? Veiculo { get; set; }

        public decimal ValorTotal { get; set; }

        public DateOnly DataInicio { get; set; }

        public DateOnly DataFim { get; set; }

        public List<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();

        public Reserva(Veiculo? veiculo, decimal valorTotal, DateOnly dataInicio, DateOnly dataFim)
        {
            Veiculo = veiculo;
            ValorTotal = valorTotal;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }


    }
}
