using Microsoft.Extensions.Hosting;

namespace Barrel.Worker
{
    public class Worker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("Worker escutando fila arquivo.criado...");
            while (!stoppingToken.IsCancellationRequested)
            {
                // mock consumo
                await Task.Delay(5000, stoppingToken);
                Console.WriteLine("[Worker] Processou mensagem da fila 'arquivo.criado'");
            }
        }
    }
}
