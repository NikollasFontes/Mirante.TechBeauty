using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class EspacoCliente
    {
        public int Id { get; private set; }
        public Beneficio Beneficio { get; private set; }
        public List<OrdemServico> OrdemServicos { get; private set; }

        public static EspacoCliente Criar(
            List<OrdemServico> ordemServicos)
        {
            EspacoCliente espacoCliente = new EspacoCliente();
            espacoCliente.OrdemServicos = ordemServicos;
            return espacoCliente;


        }
        public void ValidarBeneficio(Beneficio beneficio)
        {
            Beneficio = beneficio;
        }
    }
}
