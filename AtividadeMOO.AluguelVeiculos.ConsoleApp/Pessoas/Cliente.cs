using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AtividadeMOO.AluguelVeiculos.ConsoleApp.Reservas;
using AtividadeMOO.AluguelVeiculos.ConsoleApp.Veiculos;
using AtividadeMOO.AluguelVeiculos.ConsoleApp.Pagamentos;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp.Pessoas.Clientes
{
    public class Cliente : Pessoa
    {
        public List<Reserva> Reservas { get; set; }

        public Cliente(string? nome, string? numTel, string? email, string? cPF, DateOnly dataNasc, string? endereco) : base(nome, numTel, email, cPF, dataNasc, endereco)
        {
            Reservas = new List<Reserva>();
        }

        public void FazerReserva(Veiculo veiculo, decimal valorTotal, DateOnly dataInicio, DateOnly dataFim)
        {
            Reservas.Add(new Reserva(veiculo, valorTotal, dataInicio, dataFim));
        }

        public void FazerPagamento(Guid id, decimal valor)
        {
            Reservas.Find(reserva => reserva.Id == id).Pagamentos.Add(new Pagamento(valor, DateTime.Now));
        }


    }
}
