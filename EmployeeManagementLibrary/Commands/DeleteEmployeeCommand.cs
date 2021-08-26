using System.Threading;
using System.Threading.Tasks;
using EmployeeManagementLibrary.Data;
using EmployeeManagementLibrary.Models;
using EmployeeManagementLibrary.Queries;
using MediatR;

namespace EmployeeManagementLibrary.Commands
{
    public record DeleteEmployeeCommand(int id) : IRequest;

    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
    {
        private readonly IDataAccess _dataAccess;

        public DeleteEmployeeCommandHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            _dataAccess.DeleteEmployee(request.id);
            return Unit.Value;
        }
    }
}