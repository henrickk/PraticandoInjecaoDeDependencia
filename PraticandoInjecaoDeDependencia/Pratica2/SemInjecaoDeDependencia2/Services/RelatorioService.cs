using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraticandoInjecaoDeDependencia.Pratica2.SemInjecaoDeDependencia2.Repositories;

namespace PraticandoInjecaoDeDependencia.Pratica2.SemInjecaoDeDependencia2.Services
{
    public class RelatorioService
    {
        private readonly PagamentoRepository _repo = new PagamentoRepository();

        public void GerarResumo()
        {
            var pagamentos = _repo.ObterTodos();
            var total = pagamentos.Sum(p => p.Valor);

            Console.WriteLine($"📊 Foram processados {pagamentos.Count} pagamentos, totalizando R$ {total}");
        }
    }

}
