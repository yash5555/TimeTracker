#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/TimeTracking.Web.Host/TimeTracking.Web.Host.csproj", "src/TimeTracking.Web.Host/"]
COPY ["src/TimeTracking.Web.Core/TimeTracking.Web.Core.csproj", "src/TimeTracking.Web.Core/"]
COPY ["src/TimeTracking.Application/TimeTracking.Application.csproj", "src/TimeTracking.Application/"]
COPY ["src/TimeTracking.Application.Shared/TimeTracking.Application.Shared.csproj", "src/TimeTracking.Application.Shared/"]
COPY ["src/TimeTracking.Core.Shared/TimeTracking.Core.Shared.csproj", "src/TimeTracking.Core.Shared/"]
COPY ["src/TimeTracking.Core/TimeTracking.Core.csproj", "src/TimeTracking.Core/"]
COPY ["src/TimeTracking.EntityFrameworkCore/TimeTracking.EntityFrameworkCore.csproj", "src/TimeTracking.EntityFrameworkCore/"]
COPY ["src/TimeTracking.GraphQL/TimeTracking.GraphQL.csproj", "src/TimeTracking.GraphQL/"]
RUN dotnet restore "src/TimeTracking.Web.Host/TimeTracking.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/TimeTracking.Web.Host"
RUN dotnet build "TimeTracking.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TimeTracking.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TimeTracking.Web.Host.dll"]
