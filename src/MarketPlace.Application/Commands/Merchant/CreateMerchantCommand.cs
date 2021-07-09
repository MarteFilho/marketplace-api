using Flunt.Notifications;
using Flunt.Validations;
using MediatR;

namespace MarketPlace.Application.Commands
{
    public class CreateMerchantCommand : Notifiable, IRequest<GenericCommandResult>, ICommand
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Name, 4, "Name", "Favor inserir um nome com no minímo quatro caracteres!")
                .IsEmail(Email, "Email", "Favor inserir um e-mail válido!")
                .HasMinLen(Phone, 5, "Phone", "Favor inserir uma telefone válido!")
                .HasMinLen(Password, 6, "Password", "Favor inserir uma senha com no minímo 6 caracteres!")
                );
        }
    }
}