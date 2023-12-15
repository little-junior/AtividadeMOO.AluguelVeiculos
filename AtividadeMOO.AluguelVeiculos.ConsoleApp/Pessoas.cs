using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeMOO.AluguelVeiculos.ConsoleApp
{
    public abstract class Pessoas
    {
        public Guid Id { get; }
        public string? Nome { get; set; }
        public string? NumTel { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; }
        public DateOnly DataNasc { get; }
        public string? Endereco { get; set; }

        public Pessoas(string? nome, string? numTel, string? email, string? cpf, DateOnly dataNasc, string? endereco)
        {
            Nome = nome;
            NumTel = numTel;
            Email = email;
            CPF = cpf;
            DataNasc = dataNasc;
            Endereco = endereco;
            Id = Guid.NewGuid();
        }
    }
}
