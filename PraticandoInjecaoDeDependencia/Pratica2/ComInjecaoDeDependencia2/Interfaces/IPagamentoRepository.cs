using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2;
using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Interfaces
{
    public interface IPagamentoRepository
    {
        void Salvar(Pagamento pagamento);
        List<Pagamento> ObterTodos();
    }
}
