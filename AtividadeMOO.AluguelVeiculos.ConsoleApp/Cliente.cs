using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp
{
    public class Cliente : Pessoas
    {
        public List<Reserva> Reservas { get; set; }

        public Cliente(string? nome, string? numTel, string? email, string? cPF, DateOnly dataNasc, string? endereco) : base(nome, numTel, email, cPF, dataNasc, endereco)
        {
            Reservas = new List<Reserva>(); 
        }

        public void FazerReserva()
        {

        }


    }
}
