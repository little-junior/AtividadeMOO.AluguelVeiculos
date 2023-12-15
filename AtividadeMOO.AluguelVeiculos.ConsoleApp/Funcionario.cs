using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp
{
    public class Funcionario : Pessoas, IReserva
    {

        public decimal Salario { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string? nome, string? numTel, string? email, string? cPF, DateOnly dataNasc, string? endereco, decimal salario, string cargo) : base(nome, numTel, email, cPF, dataNasc, endereco)
        {
            Salario = salario;
            Cargo = cargo;
        }


        public void AtualizarReserva(Cliente cliente, Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public void FazerReserva(Cliente cliente, Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public void CancelarReserva(Cliente cliente, Reserva reserva)
        {
            throw new NotImplementedException();
        }
    }
}
