using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Interfaces;
using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Models;
using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Repositories;
using PraticandoInjecaoDeDependencia.Pratica2.ComInjecaoDeDependencia2.Services;

class Program
{
    static void Main(string[] args)
    {
        //// Podemos escolher qual serviço injetar
        //IMessageService service = new EmailService();
        //// IMessageService service = new SmsService();

        //Notification notification = new Notification(service);
        //notification.SendNotification("Olá, mundo!");


        {
            // Aqui você escolhe a implementação concreta
            IPagamentoService pagamentoService = new PixService();
            IPagamentoRepository repo = new PagamentoRepository();

            // RelatorioService agora recebe o repo injetado
            var relatorioService = new RelatorioService(repo);

            var pagamento = new Pagamento 
            {
                Id = 1,
                Valor = 150,
                Data = DateTime.Now,
                FormaPagamento = "PIX" 
            };

            pagamentoService.ProcessarPagamento(pagamento);
            repo.Salvar(pagamento);

            relatorioService.GerarResumo();
        }
    }
}