namespace ResultPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe nome cliente:");
            var nomeCliente = Console.ReadLine();
            Console.WriteLine("Informe valor:");
            var valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe quantidade:");
            var quantidade = Convert.ToDecimal(Console.ReadLine());
            
            var service = new PedidoService();

            var result = service.CriaPedido(nomeCliente, valor, quantidade);
            
            if (result.IsSuccess)
            {
                Console.WriteLine($"");
                Console.WriteLine($"Pedido criado com sucesso!! \n");
                Console.WriteLine($"Id: {result.Value.Id} \nNomeCliente: {result.Value.NomeCliente} \n" +
                                  $"Valor: {result.Value.Valor} \nQuantidade: {result.Value.Quantidade} \n");
            }else
            {
                Console.WriteLine($"Erro ao criar pedido: \n{result.Error}");
            }

            Console.ReadLine();
            
        }
    }
}
