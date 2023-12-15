using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp
{
    public interface IReserva
    {
        void FazerReserva(Cliente cliente, Reserva reserva);
        void CancelarReserva(Cliente cliente, Reserva reserva);
        void AtualizarReserva(Cliente cliente, Reserva reserva);
    }
}
