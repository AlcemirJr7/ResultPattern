using FluentValidation;

namespace ResultPattern
{
    public class PedidoValidator : AbstractValidator<Pedido>
    {
        public PedidoValidator()
        {
            RuleFor(pedido => pedido.NomeCliente)
            .NotEmpty()
            .NotNull()
            .MaximumLength(200);

            RuleFor(pedido => pedido.Valor)
            .NotEmpty()
            .NotNull()
            .GreaterThan(0);

            RuleFor(pedido => pedido.Quantidade)
            .NotEmpty()
            .NotNull()
            .GreaterThan(0);
        }
        
    }
}
