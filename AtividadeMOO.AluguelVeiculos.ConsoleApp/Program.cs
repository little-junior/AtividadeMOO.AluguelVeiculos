using AtividadeMOO.AluguelVeiculos.ConsoleApp.Repositorios;
using AtividadeMOO.AluguelVeiculos.ConsoleApp.Pessoas.Clientes;
using AtividadeMOO.AluguelVeiculos.ConsoleApp.Pessoas.Funcionarios;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new("Carlo Alberto", "119232323", "carlosalberto@gmail.com", "111.111.111-11", new(1950, 10, 02), "Avenida Ada, 200");

            Funcionario funcionario1 = new("Pedro Almeira", "11923254", "pedroalmeira@gmail.com", "222.222.222-22", new(1990, 05, 15), "Rua dos Carmos, 823", 3200, "Pleno");

            funcionario1.CadastrarVeiculo("Toro", "Fiat", "LSN4149", "Preta", 2015, 28.3);

            funcionario1.ConsultarVeiculo("LSN4149");

            cliente1.FazerReserva(VeiculosRepositorio.VeiculosCadastrados.ElementAt(0), 2000, new(2024, 01, 01), new(2024, 02, 01));

            cliente1.FazerPagamento(cliente1.Reservas.ElementAt(0).Id, 1000);

            funcionario1.ExcluirVeiculo("LSN4149");

            funcionario1.ConsultarVeiculo("LSN4149");

            Console.WriteLine("Fim");
        }
    }
}
