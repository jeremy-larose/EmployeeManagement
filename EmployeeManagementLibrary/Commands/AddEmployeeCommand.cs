﻿using EmployeeManagementLibrary.Data;
using MediatR;

namespace EmployeeManagementLibrary.Commands
{
    public record AddEmployeeCommand(string FirstName, string LastName) : IRequest<EmployeeModel>;
}