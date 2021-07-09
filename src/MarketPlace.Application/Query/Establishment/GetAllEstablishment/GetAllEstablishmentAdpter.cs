using System.Collections.Generic;
using System.Linq;
using MarketPlace.Domain.Entities;

namespace MarketPlace.Application.Query
{
    public static class GetAllEstablishmentAdpter
    {
        public static IList<EstablishmentDto> Adapt(IList<Establishment> establishments, double latitude, double longitude)
        {
            return establishments.Select(establishment => EstablishmentDto.Build(establishment, latitude, longitude)).OrderBy(x => x.Distance).ToList();
        }
    }
}