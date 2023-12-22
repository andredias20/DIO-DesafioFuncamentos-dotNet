using DesafioFundamentos.Models;

namespace DesafioFundamentos.Services;
public class EstacionamentoService
{
      private List<string> Veiculos = new List<string>();
      Estacionamento estacionamento;

        public EstacionamentoService(Estacionamento estacionamento)
        {
            this.estacionamento = estacionamento;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            
            string placa = Console.ReadLine();
            Veiculos.Add(placa.ToUpper());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");            
            string placa = Console.ReadLine();


            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                Console.Beep();
                
                decimal valorTotal = CalcularValorServico(estacionamento.PrecoInicial, estacionamento.PrecoPorHora, horas);
                Veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in Veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public decimal CalcularValorServico(decimal valorInicial, decimal valorPorHora, int horasEstacionado)
        {
            return valorInicial + valorPorHora * horasEstacionado;
        }
}
