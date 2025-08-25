using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.Pratica1.SemInjecaoDeDependencia
{
    public class EmailService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Enviando email: {message}");
        }
    }
}
