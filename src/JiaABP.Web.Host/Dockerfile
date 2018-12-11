FROM microsoft/dotnet AS base

WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet AS build

WORKDIR /src
COPY ["src/JiaABP.Web.Host/JiaABP.Web.Host.csproj", "src/JiaABP.Web.Host/"]
COPY ["src/JiaABP.Migrator/JiaABP.Migrator.csproj", "src/JiaABP.Migrator/"]
COPY ["src/JiaABP.Web.Core/JiaABP.Web.Core.csproj", "src/JiaABP.Web.Core/"]
COPY ["src/JiaABP.Application/JiaABP.Application.csproj", "src/JiaABP.Application/"]
COPY ["src/JiaABP.Core/JiaABP.Core.csproj", "src/JiaABP.Core/"]
COPY ["src/JiaABP.EntityFrameworkCore/JiaABP.EntityFrameworkCore.csproj", "src/JiaABP.EntityFrameworkCore/"]

RUN dotnet restore "JiaABP.Web.Host/JiaABP.Web.Host.csproj"

COPY . .

RUN dotnet build "JiaABP.Web.Host/JiaABP.Web.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "JiaABP.Web.Host/JiaABP.Web.Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "JiaABP.Web.Host.dll"]