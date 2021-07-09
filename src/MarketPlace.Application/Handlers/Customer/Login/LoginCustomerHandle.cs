using System;
using System.Threading;
using System.Threading.Tasks;
using Flunt.Notifications;
using MarketPlace.Application.Commands;
using MarketPlace.Infraestructure.UnitOfWork;
using MediatR;

namespace MarketPlace.Application.Handlers
{
    public class LoginCustomerHandle : Notifiable, IRequestHandler<LoginCustomerCommand, GenericCommandResult>
    {
        private readonly IUnitOfWork _uow;
        public LoginCustomerHandle(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<GenericCommandResult> Handle(LoginCustomerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var customer = await _uow.CustomerRepository.Find(x => x.Document == request.Cpf);
                if (customer == null)
                    return await Task.FromResult(new GenericCommandResult(404, false, "Customer não encontrado!", null));

                if (customer.Login(request.Password))
                    return new GenericCommandResult(200, true, "Usuário autenticado com sucesso!", customer);

                return new GenericCommandResult(401, false, "Usuário ou senha inválidos!", null);

            }
            catch (Exception ex)
            {
                return new GenericCommandResult(500, false, "Erro ao realizar login! - " + ex.Message, null);
            }
        }
    }
}