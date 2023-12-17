using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeMOO.AluguelVeiculos.ConsoleApp.Repositorios;
using AtividadeMOO.AluguelVeiculos.ConsoleApp.Veiculos;
using AtividadeMOO.AluguelVeiculos.ConsoleApp.Pagamentos;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp.Pessoas.Funcionarios
{
    public class Funcionario : Pessoa
    {

        public decimal Salario { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string? nome, string? numTel, string? email, string? cPF, DateOnly dataNasc, string? endereco, decimal salario, string cargo) : base(nome, numTel, email, cPF, dataNasc, endereco)
        {
            Salario = salario;
            Cargo = cargo;
        }

        public void CadastrarVeiculo(string? modelo, string? marca, string? placa, string? cor, int anoLanc, double kmsRodados)
        {
            VeiculosRepositorio.VeiculosCadastrados?.Add(new Veiculo(modelo, marca, placa, cor, anoLanc, kmsRodados));
        }

        public void ExcluirVeiculo(string? placa)
        {
            VeiculosRepositorio.VeiculosCadastrados?.Remove(VeiculosRepositorio.VeiculosCadastrados?.Find(veiculo => veiculo.Placa == placa));
        }

        public void ConsultarVeiculo(string? placa)
        {
            Console.WriteLine(VeiculosRepositorio.VeiculosCadastrados?.Find(veiculo => veiculo.Placa == placa)?.ToString());
        }

        public void EmitirBoleto(Guid idPagamento) { }
    }
}
