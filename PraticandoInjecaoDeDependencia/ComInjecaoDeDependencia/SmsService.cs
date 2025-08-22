using PraticandoInjecaoDeDependencia.ComInjecaoDeDependencia.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.ComInjecaoDeDependencia
{
    // Outra implementação - SMS
    public class SmsService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Enviando SMS: {message}");
        }
    }
}
