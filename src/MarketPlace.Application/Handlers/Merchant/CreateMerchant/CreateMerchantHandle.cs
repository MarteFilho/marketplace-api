// using System.Threading;
// using System.Threading.Tasks;
// using Flunt.Notifications;
// using MarketPlace.Application.Commands;
// using MarketPlace.Domain.Entities;
// using MarketPlace.Domain.Repository;
// using MediatR;

// namespace MarketPlace.Application.Handlers
// {
//     public class CreateMerchantHandle : Notifiable, IRequestHandler<CreateMerchantCommand, GenericCommandResult>
//     {
//         private readonly IMerchantRepository _merchantRepository;
//         public CreateMerchantHandle(IMerchantRepository merchantRepository)
//         {
//             _merchantRepository = merchantRepository;
//         }

//         public async Task<GenericCommandResult> Handle(CreateMerchantCommand request, CancellationToken cancellationToken)
//         {
//             request.Validate();

//             if (request.Invalid)
//                 return new GenericCommandResult(400, false, "Favor revisar os dados para criar o comerciante!", request.Notifications);

//             try
//             {
//                 var alreadyExistsMerchant = _merchantRepository.Exists(x => x.Document == request.Document);
//                 if (alreadyExistsMerchant)
//                     return await Task.FromResult(new GenericCommandResult(400, false, "Comerciante já cadastrado com esse documento!", null));

//                 Merchant merchant = Merchant.Create(request.Name, request.Document, request.Email, request.Phone, request.Password);
//                 await _merchantRepository.AddAsync(merchant, cancellationToken);
//                 _merchantRepository.SaveChanges();

//                 return await Task.FromResult(new GenericCommandResult(200, true, "Comerciante criado com sucesso!", merchant));
//             }
//             catch
//             {
//                 return await Task.FromResult(new GenericCommandResult(500, false, "Erro ao criar comerciante!", null));
//             }
//         }
//     }
// }