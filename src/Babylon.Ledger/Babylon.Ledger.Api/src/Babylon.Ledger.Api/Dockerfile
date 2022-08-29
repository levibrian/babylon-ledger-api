FROM public.ecr.aws/lambda/dotnet:6 AS base

FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim as build
WORKDIR /src
COPY ["Babylon.Ledger.Api.csproj", "Babylon.Ledger.Api/"]
RUN dotnet restore "Babylon.Ledger.Api/Babylon.Ledger.Api.csproj"

WORKDIR "/src/Babylon.Ledger.Api"
COPY . .
RUN dotnet build "Babylon.Ledger.Api.csproj" --configuration Release --output /app/build

FROM build AS publish
RUN dotnet publish "Babylon.Ledger.Api.csproj" --configuration Release --runtime linux-x64 --self-contained false --output /app/publish -p:PublishReadyToRun=true  

FROM base AS final
WORKDIR /var/task
COPY --from=publish /app/publish .