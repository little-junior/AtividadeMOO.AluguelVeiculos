using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp
{
    public class Reserva
    {
        public Guid Id { get; }
        public Cliente? Cliente { get; set; }

        public Veiculo? Veiculo { get; set; }

        public decimal ValorTotal { get; set; }

        public DateOnly DataInicio { get; set; }

        public DateOnly DataFim { get; set; }

        public Reserva (Cliente? cliente, Veiculo? veiculo, decimal valorTotal, DateOnly dataInicio, DateOnly dataFim)
        {
            Cliente = cliente;
            Veiculo = veiculo;
            ValorTotal = valorTotal;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }


    }
}
