namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal PrecoInicial {get; set;}
        public decimal PrecoPorHora {get; set;}
  
        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.PrecoInicial = precoInicial;
            this.PrecoPorHora = precoPorHora;
        }
        
    }
}
