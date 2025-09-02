using PraticandoInjecaoDeDependencia.Pratica1.ComInjecaoDeDependencia.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.Pratica1.ComInjecaoDeDependencia
{
    public class Notification
    {
        private readonly IMessageService _messageService;

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
