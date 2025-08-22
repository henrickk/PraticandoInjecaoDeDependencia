using PraticandoInjecaoDeDependencia.ComInjecaoDeDependencia;
using PraticandoInjecaoDeDependencia.ComInjecaoDeDependencia.Interface;

class Program
{
    static void Main(string[] args)
    {
        // Podemos escolher qual serviço injetar
        IMessageService service = new EmailService();
        // IMessageService service = new SmsService();

        Notification notification = new Notification(service);
        notification.SendNotification("Olá, mundo!");
    }
}