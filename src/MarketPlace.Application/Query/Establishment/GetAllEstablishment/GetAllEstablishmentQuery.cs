// using System.Threading;
// using System.Threading.Tasks;
// using MarketPlace.Domain.Repository;
// using MediatR;

// namespace MarketPlace.Application.Query
// {
//     public class GetAllEstablishmentQuery : IRequestHandler<GetAllEstablishmentRequest, GenericQueryResult>
//     {
//         private readonly IEstablishmentRepository _establishmentRepository;
//         public GetAllEstablishmentQuery(IEstablishmentRepository establishmentRepository)
//         {
//             _establishmentRepository = establishmentRepository;
//         }
//         public async Task<GenericQueryResult> Handle(GetAllEstablishmentRequest request, CancellationToken cancellationToken)
//         {
//             try
//             {
//                 var establishments = _establishmentRepository.GetAll();
//                 var establishmentsDto = GetAllEstablishmentAdpter.Adapt(establishments, request.Latitude, request.Longitude);
//                 return await Task.FromResult(new GenericQueryResult(200, true, "Estabelecimentos encontrados com sucesso!", establishmentsDto));
//             }
//             catch
//             {

//                 throw;
//             }
//         }
//     }
// }