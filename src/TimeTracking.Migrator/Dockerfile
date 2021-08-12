#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/TimeTracking.Migrator/TimeTracking.Migrator.csproj", "src/TimeTracking.Migrator/"]
COPY ["src/TimeTracking.EntityFrameworkCore/TimeTracking.EntityFrameworkCore.csproj", "src/TimeTracking.EntityFrameworkCore/"]
COPY ["src/TimeTracking.Core/TimeTracking.Core.csproj", "src/TimeTracking.Core/"]
COPY ["src/TimeTracking.Core.Shared/TimeTracking.Core.Shared.csproj", "src/TimeTracking.Core.Shared/"]
RUN dotnet restore "src/TimeTracking.Migrator/TimeTracking.Migrator.csproj"
COPY . .
WORKDIR "/src/src/TimeTracking.Migrator"
RUN dotnet build "TimeTracking.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TimeTracking.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TimeTracking.Migrator.dll"]
