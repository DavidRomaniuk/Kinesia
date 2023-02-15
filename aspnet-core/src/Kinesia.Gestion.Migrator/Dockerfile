#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Kinesia.Gestion.Migrator/Kinesia.Gestion.Migrator.csproj", "src/Kinesia.Gestion.Migrator/"]
COPY ["src/Kinesia.Gestion.EntityFrameworkCore/Kinesia.Gestion.EntityFrameworkCore.csproj", "src/Kinesia.Gestion.EntityFrameworkCore/"]
COPY ["src/Kinesia.Gestion.Core/Kinesia.Gestion.Core.csproj", "src/Kinesia.Gestion.Core/"]
COPY ["src/Kinesia.Gestion.Core.Shared/Kinesia.Gestion.Core.Shared.csproj", "src/Kinesia.Gestion.Core.Shared/"]
RUN dotnet restore "src/Kinesia.Gestion.Migrator/Kinesia.Gestion.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Kinesia.Gestion.Migrator"
RUN dotnet build "Kinesia.Gestion.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kinesia.Gestion.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kinesia.Gestion.Migrator.dll", "-s"]
