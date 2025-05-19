FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Instala dotnet-ef globalmente
#RUN dotnet tool install --global dotnet-ef \
    #&& echo 'export PATH="$PATH:/root/.dotnet/tools"' >> /root/.bashrc

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar archivos de proyecto
COPY ["src/AutoBrands.Api/AutoBrands.Api.csproj", "AutoBrands.Api/"]
COPY ["src/AutoBrands.Application/AutoBrands.Application.csproj", "AutoBrands.Application/"]
COPY ["src/AutoBrands.Domain/AutoBrands.Domain.csproj", "AutoBrands.Domain/"]
COPY ["src/AutoBrands.Infrastructure/AutoBrands.Infrastructure.csproj", "AutoBrands.Infrastructure/"]

# Restaurar paquetes
RUN dotnet restore "AutoBrands.Api/AutoBrands.Api.csproj"

# Copiar todo el código fuente
COPY src/ ./ 

# Construir la solución
WORKDIR "/src/AutoBrands.Api"
RUN dotnet build "AutoBrands.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AutoBrands.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AutoBrands.Api.dll"]
