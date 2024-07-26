using System;

namespace Entities {
    public class Cidadao {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Vacinado { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Cidadao(string cpf, string nome, int idade, bool vacinado) {
            CPF = cpf;
            Nome = nome;
            Idade = idade;
            Vacinado = vacinado;
        }

        public Cidadao(string cpf, string nome, int idade, bool vacinado, string telefone, string email) {
            CPF = cpf;
            Nome = nome;
            Idade = idade;
            Vacinado = vacinado;
            Telefone = telefone;
            Email = email;
        }
    }
}