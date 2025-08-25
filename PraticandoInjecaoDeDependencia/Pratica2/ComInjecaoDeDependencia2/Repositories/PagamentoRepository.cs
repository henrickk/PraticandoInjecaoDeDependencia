using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Interfaces;
using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Models;

namespace PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly List<Pagamento> _pagamentos = new();

        public void Salvar(Pagamento pagamento)
        {
            _pagamentos.Add(pagamento);
        }

        List<Pagamento> IPagamentoRepository.ObterTodos()
        {
            return _pagamentos;
        }
    }
}
