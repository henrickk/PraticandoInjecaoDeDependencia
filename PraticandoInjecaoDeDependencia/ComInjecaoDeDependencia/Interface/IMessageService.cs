using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoInjecaoDeDependencia.ComInjecaoDeDependencia.Interface
{
    // Definimos uma interface para abstrair o serviço
    public interface IMessageService
    {
        void Send(string message);
    }
}
