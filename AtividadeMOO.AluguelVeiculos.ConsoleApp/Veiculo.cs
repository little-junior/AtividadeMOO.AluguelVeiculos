using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp
{
    public class Veiculo
    {
        public Guid Id { get; }

        public string? Modelo { get; set; }

        public string? Marca { get; }

        public string? Placa { get; set; }

        public string? Cor { get; set; }

        public int AnoLanc { get; }

        public double KmsRodados { get; set; }

        public bool Alugado { get; private set; }
        
        public Veiculo(string? modelo, string? marca, string? placa, string? cor, DateOnly anoLanc, double kmsRodados)
        {
            Id = Guid.NewGuid();
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
            Cor = cor;
            AnoLanc = anoLanc.Year;
            KmsRodados = kmsRodados;
        }
    }
}
