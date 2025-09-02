using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Interfaces;
using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Services
{
    public class PixService : IPagamentoService
    {
        public void ProcessarPagamento(Pagamento pagamento)
        {
            Console.WriteLine($"Pagamento de {pagamento.Valor} processado via PIX!");
        }
    }
}
