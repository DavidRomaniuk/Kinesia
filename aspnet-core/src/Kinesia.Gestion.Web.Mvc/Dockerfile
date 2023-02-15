#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Kinesia.Gestion.Web.Mvc/Kinesia.Gestion.Web.Mvc.csproj", "src/Kinesia.Gestion.Web.Mvc/"]
COPY ["src/Kinesia.Gestion.Web.Core/Kinesia.Gestion.Web.Core.csproj", "src/Kinesia.Gestion.Web.Core/"]
COPY ["src/Kinesia.Gestion.Application/Kinesia.Gestion.Application.csproj", "src/Kinesia.Gestion.Application/"]
COPY ["src/Kinesia.Gestion.Application.Shared/Kinesia.Gestion.Application.Shared.csproj", "src/Kinesia.Gestion.Application.Shared/"]
COPY ["src/Kinesia.Gestion.Core.Shared/Kinesia.Gestion.Core.Shared.csproj", "src/Kinesia.Gestion.Core.Shared/"]
COPY ["src/Kinesia.Gestion.Core/Kinesia.Gestion.Core.csproj", "src/Kinesia.Gestion.Core/"]
COPY ["src/Kinesia.Gestion.EntityFrameworkCore/Kinesia.Gestion.EntityFrameworkCore.csproj", "src/Kinesia.Gestion.EntityFrameworkCore/"]
COPY ["src/Kinesia.Gestion.GraphQL/Kinesia.Gestion.GraphQL.csproj", "src/Kinesia.Gestion.GraphQL/"]
RUN dotnet restore "src/Kinesia.Gestion.Web.Mvc/Kinesia.Gestion.Web.Mvc.csproj"
COPY . .
WORKDIR "/src/src/Kinesia.Gestion.Web.Mvc"
RUN dotnet build "Kinesia.Gestion.Web.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kinesia.Gestion.Web.Mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kinesia.Gestion.Web.Mvc.dll"]
