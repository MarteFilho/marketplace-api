using Flunt.Notifications;
using MediatR;

namespace MarketPlace.Application.Commands
{
    public class LoginCustomerCommand : Notifiable, IRequest<GenericCommandResult>, ICommand
    {
        public string Cpf { get; set; }
        public string Password { get; set; }
        public void Validate()
        {
        }
    }
}