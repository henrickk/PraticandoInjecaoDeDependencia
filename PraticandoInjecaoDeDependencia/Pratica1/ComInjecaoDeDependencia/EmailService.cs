using PraticandoInjecaoDeDependencia.Pratica1.ComInjecaoDeDependencia.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.Pratica1.ComInjecaoDeDependencia
{
    public class EmailService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Enviando email: {message}");
        }
    }
}
