using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.Pratica1.SemInjecaoDeDependencia
{
    public class Notificacao
    {
        private EmailService _emailService = new EmailService();

        public void SendNotification(string message)
        {
            _emailService.Send(message);
        }
    }
}
