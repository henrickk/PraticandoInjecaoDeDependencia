using PraticandoInjecaoDeDependencia.Pratica2.SemInjecaoDeDependencia2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.Pratica2.SemInjecaoDeDependencia2.Services
{
    public class BoletoService
    {
        public void ProcessarPagamento(Pagamento pagamento)
        {
            Console.WriteLine($"📄 Pagamento de {pagamento.Valor} processado por boleto!");
        }
    }
}
