using MediatR;

namespace Discount.Application.Commands
{
    public class DeleteDicountCommand : IRequest<bool>
    {
        public string ProductName { get; set; }

        public DeleteDicountCommand(string productName)
        {
            ProductName = productName;
        }
    }
}
