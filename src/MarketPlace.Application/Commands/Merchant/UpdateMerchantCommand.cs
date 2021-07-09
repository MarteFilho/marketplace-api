using Flunt.Notifications;
using MediatR;

namespace MarketPlace.Application.Commands.Merchant
{
    public class UppdateMerchantCommand : Notifiable, IRequest<GenericCommandResult>, ICommand
    {
        public string Phone { get; private set; }
        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}