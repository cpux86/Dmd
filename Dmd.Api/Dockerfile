#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["Dmd.Api/Dmd.Api.csproj", "Dmd.Api/"]
COPY ["Dmd.Infrastructure.Data/Dmd.Infrastructure.Data.csproj", "Dmd.Infrastructure.Data/"]
COPY ["Dmd.Domain.Interfaces/Dmd.Domain.Interfaces.csproj", "Dmd.Domain.Interfaces/"]
COPY ["Dmd.Domain/Dmd.Domain.Core.csproj", "Dmd.Domain/"]
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