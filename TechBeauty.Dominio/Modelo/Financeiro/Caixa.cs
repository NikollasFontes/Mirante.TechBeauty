using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class Caixa
    {
        public int Id { get; private set; }
        public decimal SaldoInicial { get; private set; }
        public decimal SaldoFinalCaixa  { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public DateTime DataHoraFechamento { get; private set; }
        public Beneficio Beneficio { get; private set; }
        public List<Pagamento> Pagamentos { get; private set; }
        public decimal LucroDiario { get; private set; }
        

        public static Caixa AbrirCaixa(decimal saldoInicial, DateTime dataHoraCriacao)
        {
            Caixa caixa = new Caixa();
            caixa.SaldoInicial = saldoInicial;
            caixa.DataHoraCriacao = dataHoraCriacao;
            return caixa;



        }
        public void  FecharCaixa(DateTime dataHoraFechamento, decimal saldoFinal, 
            List<Pagamento> pagamentos)
        {
            DataHoraFechamento = dataHoraFechamento;
            
            Pagamentos = pagamentos;
            decimal valor = 0;
            foreach (var item in pagamentos)
            {
                valor += item.OrdemServico.PrecoTotal;
            }
            LucroDiario = valor - SaldoInicial;
            SaldoFinalCaixa = valor + SaldoInicial;

        }
        public decimal ComissaoDiariaColaborador(int id)
        {
            return 0;
        }
    }
}
