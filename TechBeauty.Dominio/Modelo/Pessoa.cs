using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public abstract class Pessoa
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string CPF { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public List<Contato> Contatos { get; set; }
    }
}
