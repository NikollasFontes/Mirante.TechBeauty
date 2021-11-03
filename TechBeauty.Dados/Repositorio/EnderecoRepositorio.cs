using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class EnderecoRepositorio
    {
        private readonly Context context;

        public EnderecoRepositorio()
        {
            context = new();
        }

        public void Incluir(Endereco endereco)
        {
            context.Endereco.Add(endereco);
            context.SaveChanges();
        }

        public void Alterar(int id, Endereco endereco)
        {
            context.Endereco.FirstOrDefault(x => x.Id == id).AlterarEndereco(endereco);
            context.SaveChanges();
        }

        public Endereco PegarEndereco(int id)
        {
            return context.Endereco.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Endereco.Remove(context.Endereco.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public List<Endereco> Tabela()
        {
            return context.Endereco.ToList();
        }
    }
}
