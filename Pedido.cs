namespace ResultPattern
{
    public class Pedido
    {
        public Guid Id { get; private set; }
        public string NomeCliente { get; private set; } = string.Empty;
        public decimal Valor { get; private set; }
        public decimal Quantidade { get; private set; }

        public Pedido(string nomeCliente, decimal valor, decimal quantidade)
        {
            Id = Guid.NewGuid();
            NomeCliente = nomeCliente;
            Valor = valor;
            Quantidade = quantidade;
        }
                
    }
}
