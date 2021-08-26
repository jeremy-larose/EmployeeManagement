using System.Threading;
using System.Threading.Tasks;
using EmployeeManagementLibrary.Data;
using EmployeeManagementLibrary.Models;
using MediatR;

namespace EmployeeManagementLibrary.Commands
{
    public record UpdateEmployeeCommand(int Id, string FirstName, string LastName ) : IRequest;

    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        private readonly IDataAccess _dataAccess;

        public UpdateEmployeeCommandHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            _dataAccess.UpdateEmployee(request.Id, request.FirstName, request.LastName);
            return Unit.Value;
        }
    }
}