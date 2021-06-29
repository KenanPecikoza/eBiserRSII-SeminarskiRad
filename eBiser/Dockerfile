FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY . .

FROM build AS publish
RUN dotnet publish "eBiser" -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ADD /TestPhoto TestPhoto/

ENTRYPOINT ["dotnet", "eBiser.dll"] 