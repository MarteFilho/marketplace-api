// using System.Threading;
// using System.Threading.Tasks;
// using Flunt.Notifications;
// using MarketPlace.Application.Commands;
// using MarketPlace.Domain.Entities;
// using MarketPlace.Domain.Repository;
// using MediatR;

// namespace MarketPlace.Application.Handlers
// {
//     public class CreateEstablishmentCategoryHandle : Notifiable, IRequestHandler<CreateEstablishmentCategoryCommand, GenericCommandResult>
//     {
//         private readonly IEstablishmentCategoryRepository _establishmentCategoryRepository;
//         public CreateEstablishmentCategoryHandle(IEstablishmentCategoryRepository establishmentCategoryRepository)
//         {
//             _establishmentCategoryRepository = establishmentCategoryRepository;
//         }
//         public async Task<GenericCommandResult> Handle(CreateEstablishmentCategoryCommand request, CancellationToken cancellationToken)
//         {
//             request.Validate();

//             if (request.Invalid)
//                 return new GenericCommandResult(400, false, "Favor revisar os dados para criar categoria do estabelecimento!", request.Notifications);

//             try
//             {
//                 EstablishmentCategory establishmentCategory = EstablishmentCategory.Create(request.Name, request.Description);
//                 await _establishmentCategoryRepository.AddAsync(establishmentCategory, cancellationToken);
//                 _establishmentCategoryRepository.SaveChanges();

//                 return await Task.FromResult(new GenericCommandResult(200, true, "Categoria de estabelecimento criada com sucesso!", establishmentCategory));
//             }
//             catch
//             {
//                 return await Task.FromResult(new GenericCommandResult(500, false, "Erro ao criar categoria de estabelecimento!", null));
//             }
//         }
//     }
// }