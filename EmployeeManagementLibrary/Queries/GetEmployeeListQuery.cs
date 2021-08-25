using System.Collections.Generic;
using EmployeeManagementLibrary.Data;
using MediatR;

namespace EmployeeManagementLibrary.Queries
{
    public record GetEmployeeListQuery : IRequest<List<EmployeeModel>>;
}