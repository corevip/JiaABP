FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["src/JiaABP.Web.Host/JiaABP.Web.Host.csproj", "src/JiaABP.Web.Host/"]
COPY ["src/JiaABP.Web.Core/JiaABP.Web.Core.csproj", "src/JiaABP.Web.Core/"]
COPY ["src/JiaABP.EntityFrameworkCore/JiaABP.EntityFrameworkCore.csproj", "src/JiaABP.EntityFrameworkCore/"]
COPY ["src/JiaABP.Core/JiaABP.Core.csproj", "src/JiaABP.Core/"]
COPY ["src/JiaABP.Application/JiaABP.Application.csproj", "src/JiaABP.Application/"]
RUN dotnet restore "src/JiaABP.Web.Host/JiaABP.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/JiaABP.Web.Host"
RUN dotnet build "JiaABP.Web.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "JiaABP.Web.Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "JiaABP.Web.Host.dll"]