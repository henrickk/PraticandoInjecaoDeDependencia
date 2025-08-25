using PraticandoInjecaoDeDependencia.Pratica2.SemInjecaoDeDependencia2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.Pratica2.SemInjecaoDeDependencia2.Repositories
{
    public class PagamentoRepository
    {
        private readonly List<Pagamento> _pagamentos = new();

        public void Salvar(Pagamento pagamento) => _pagamentos.Add(pagamento);

        public List<Pagamento> ObterTodos() => _pagamentos;
    }
}
