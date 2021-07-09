using System;
using Flunt.Notifications;
using MediatR;

namespace MarketPlace.Application.Commands
{
    public class CreateEstablishmentCommand : Notifiable, IRequest<GenericCommandResult>, ICommand
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string FU { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Guid EstablishementCategoryId { get; set; }
        public void Validate()
        {
        }
    }
}