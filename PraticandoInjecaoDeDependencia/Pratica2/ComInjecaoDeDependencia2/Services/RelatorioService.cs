using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Interfaces;
using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Models;
using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Services
{
    public class RelatorioService
    {
        private readonly IPagamentoRepository _repo;

        public RelatorioService(IPagamentoRepository repo)
        {
            _repo = repo;
        }

        public void GerarResumo()
        {
            var pagamentos = _repo.ObterTodos();
            var total = pagamentos.Sum(p => p.Valor);

            Console.WriteLine($"Foram processados {pagamentos.Count} pagamentos, totalizando R$ {total}");
        }
    }
}
