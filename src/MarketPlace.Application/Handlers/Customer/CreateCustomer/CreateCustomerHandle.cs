using System.Threading;
using System.Threading.Tasks;
using Flunt.Notifications;
using MarketPlace.Application.Commands;
using MarketPlace.Domain.Entities;
using MarketPlace.Domain.Repository;
using MarketPlace.Infraestructure.UnitOfWork;
using MediatR;

namespace MarketPlace.Application.Handlers
{
    public class CreateCustomerHandle : Notifiable, IRequestHandler<CreateCustomerCommand, GenericCommandResult>
    {
        private readonly IUnitOfWork _uow;
        public CreateCustomerHandle(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<GenericCommandResult> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            request.Validate();

            if (request.Invalid)
                return new GenericCommandResult(400, false, "Favor revisar os dados para criar o cliente!", request.Notifications);

            try
            {
                Customer customer = Customer.Create(request.Name, request.Document, request.Email, request.Phone, request.Password);
                await _uow.CustomerRepository.AddAsync(customer);
                _uow.SaveChanges();

                return await Task.FromResult(new GenericCommandResult(200, true, "Cliente criado com sucesso!", customer));
            }
            catch
            {
                return await Task.FromResult(new GenericCommandResult(500, false, "Erro ao criar cliente!", null));
            }
        }
    }
}