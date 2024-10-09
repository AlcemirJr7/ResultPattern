using FluentValidation;
using FluentValidation.Results;

namespace ResultPattern
{
    public class PedidoService
    {
        public Result<Pedido> CriaPedido(string nomeCliente, decimal valor, decimal quantidade)
        {
            Pedido newPedido = new(nomeCliente, valor, quantidade);

            IValidator<Pedido>? validator = new PedidoValidator();

            ValidationResult? validationResult = validator.Validate(newPedido);

            if (!validationResult.IsValid)
            {
                return Result<Pedido>.Failure(validationResult.ToString());
            }
                        
            return Result<Pedido>.Success(newPedido);
        }
    }
}
