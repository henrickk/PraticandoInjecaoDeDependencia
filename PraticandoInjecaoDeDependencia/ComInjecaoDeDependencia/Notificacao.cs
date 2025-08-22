using PraticandoInjecaoDeDependencia.ComInjecaoDeDependencia.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.ComInjecaoDeDependencia
{
    // Classe que depende da abstração (interface) e não da implementação
    public class Notification
    {
        private readonly IMessageService _messageService;

        // Injeção de dependência via construtor
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void SendNotification(string message)
        {
            _messageService.Send(message);
        }
    }
}
