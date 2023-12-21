namespace DesafioFundamentos.Models
{
      public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora; 
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa para remover o veículo: ");
            string placa = Console.ReadLine();

            //verifica se existe a placa ignorando as letras minúsculas e maiúsculas da lista veiculos.    
            if (veiculos.Any(x => x.Equals(placa, StringComparison.CurrentCultureIgnoreCase))) 
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado:");
                //int.parse é usado para converter uma string em um valor inteiro.
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. confira se digitou a placa corretamente!");
            }
        }   

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach(var placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }
    }
}