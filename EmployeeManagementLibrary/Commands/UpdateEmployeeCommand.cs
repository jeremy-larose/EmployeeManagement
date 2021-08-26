using System.Threading;
using System.Threading.Tasks;
using EmployeeManagementLibrary.Data;
using EmployeeManagementLibrary.Models;
using MediatR;

namespace EmployeeManagementLibrary.Commands
{
    public record UpdateEmployeeCommand(int Id, string FirstName, string LastName) : IRequest<EmployeeModel>;

    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, EmployeeModel>
    {
        private readonly IDataAccess _dataAccess;

        public UpdateEmployeeCommandHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<EmployeeModel> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.UpdateEmployee(request.Id, request.FirstName, request.LastName));
        }
    }
}