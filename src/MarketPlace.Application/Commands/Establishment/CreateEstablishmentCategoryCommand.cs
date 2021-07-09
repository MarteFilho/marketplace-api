using Flunt.Notifications;
using MediatR;

namespace MarketPlace.Application.Commands
{
    public class CreateEstablishmentCategoryCommand : Notifiable, IRequest<GenericCommandResult>, ICommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public void Validate()
        {
        }
    }
}