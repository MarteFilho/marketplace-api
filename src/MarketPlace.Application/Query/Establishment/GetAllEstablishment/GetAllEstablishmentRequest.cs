using MediatR;

namespace MarketPlace.Application.Query
{
    public class GetAllEstablishmentRequest : IRequest<GenericQueryResult>
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}