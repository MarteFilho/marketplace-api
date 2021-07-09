// using System.Threading;
// using System.Threading.Tasks;
// using Flunt.Notifications;
// using MarketPlace.Application.Commands;
// using MarketPlace.Domain.Entities;
// using MarketPlace.Domain.Repository;
// using MediatR;

// namespace MarketPlace.Application.Handlers
// {
//     public class CreateEstablishmentHandle : Notifiable, IRequestHandler<CreateEstablishmentCommand, GenericCommandResult>
//     {
//         private readonly IEstablishmentRepository _establishmentRepository;
//         public CreateEstablishmentHandle(IEstablishmentRepository establishmentRepository)
//         {
//             _establishmentRepository = establishmentRepository;
//         }
//         public async Task<GenericCommandResult> Handle(CreateEstablishmentCommand request, CancellationToken cancellationToken)
//         {
//             request.Validate();

//             if (request.Invalid)
//                 return new GenericCommandResult(400, false, "Favor revisar os dados para criar o estabelecimento!", request.Notifications);

//             try
//             {
//                 Establishment establishment = Establishment.Create(request.Name, request.Address, request.Neighborhood, request.City, request.FU, request.Latitude, request.Longitude);
//                 establishment.AddCategory(request.EstablishementCategoryId);
//                 await _establishmentRepository.AddAsync(establishment, cancellationToken);
//                 _establishmentRepository.SaveChanges();

//                 return await Task.FromResult(new GenericCommandResult(200, true, "Estabelecimento criado com sucesso!", establishment));
//             }
//             catch
//             {
//                 return await Task.FromResult(new GenericCommandResult(500, false, "Erro ao criar estabelecimento!", null));
//             }
//         }
//     }
// }