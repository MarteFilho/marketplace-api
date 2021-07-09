using Flunt.Notifications;
using MediatR;

namespace MarketPlace.Application.Commands
{
    public class CreateCustomerCommand : Notifiable, IRequest<GenericCommandResult>, ICommand
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public void Validate()
        {
        }
    }
}