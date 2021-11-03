using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo.Financeiro
{
    class Gestao
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public EspacoCliente EspacoCliente { get; set; }
        public decimal Salario { get; set; }
        public List<Caixa> Caixas   { get; set; }
        public Colaborador Colaborador { get; set; }
        public decimal Receita { get; set; }


        public Gestao Criar(Usuario usuario, EspacoCliente espacoCliente, decimal salario)
        {
            Gestao gestao = new();
            gestao.Usuario = usuario;
            gestao.EspacoCliente = espacoCliente;
            gestao.Salario = salario;
            
            
            return gestao;

        }

        public decimal LucroMensal(List<Caixa> caixas)
        {
            return 0;
        }

        public decimal ComissaoTotalColaborador(Colaborador colaborador)
        {
            return 0;

        }
        //public decimal ReceitaMensal(Receita receita)
        //{
        //    return 0;
        //}
        public bool ValidarAcesso(Usuario usuario)
        {
            return true;
        }



    }
  
}
