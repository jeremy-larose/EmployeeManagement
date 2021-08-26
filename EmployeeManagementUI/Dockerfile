FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["EmployeeManagementUI/EmployeeManagementUI.csproj", "EmployeeManagementUI/"]
RUN dotnet restore "EmployeeManagementUI/EmployeeManagementUI.csproj"
COPY . .
WORKDIR "/src/EmployeeManagementUI"
RUN dotnet build "EmployeeManagementUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EmployeeManagementUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeeManagementUI.dll"]
