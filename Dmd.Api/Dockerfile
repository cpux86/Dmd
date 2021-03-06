#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Dmd.Api/Dmd.Api.csproj", "Dmd.Api/"]
COPY ["Dmd.Infrastructure.Data/Dmd.Infrastructure.Data.csproj", "Dmd.Infrastructure.Data/"]
COPY ["Dmd.Domain.Interfaces/Dmd.Domain.Interfaces.csproj", "Dmd.Domain.Interfaces/"]
COPY ["Dmd.Domain/Dmd.Domain.csproj", "Dmd.Domain/"]
COPY ["Dmd.Services.Interfaces/Dmd.Services.Interfaces.csproj", "Dmd.Services.Interfaces/"]
COPY ["Dmd.Infrastructure.Business/Dmd.Infrastructure.Business.csproj", "Dmd.Infrastructure.Business/"]
RUN dotnet restore "Dmd.Api/Dmd.Api.csproj"
COPY . .
WORKDIR "/src/Dmd.Api"
RUN dotnet build "Dmd.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dmd.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dmd.Api.dll"]