FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/SinglePageDemo.Web.Host/SinglePageDemo.Web.Host.csproj", "src/SinglePageDemo.Web.Host/"]
COPY ["src/SinglePageDemo.Web.Core/SinglePageDemo.Web.Core.csproj", "src/SinglePageDemo.Web.Core/"]
COPY ["src/SinglePageDemo.Application/SinglePageDemo.Application.csproj", "src/SinglePageDemo.Application/"]
COPY ["src/SinglePageDemo.Core/SinglePageDemo.Core.csproj", "src/SinglePageDemo.Core/"]
COPY ["src/SinglePageDemo.EntityFrameworkCore/SinglePageDemo.EntityFrameworkCore.csproj", "src/SinglePageDemo.EntityFrameworkCore/"]
WORKDIR "/src/src/SinglePageDemo.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/SinglePageDemo.Web.Host", "src/SinglePageDemo.Web.Host"]
COPY ["src/SinglePageDemo.Web.Core", "src/SinglePageDemo.Web.Core"]
COPY ["src/SinglePageDemo.Application", "src/SinglePageDemo.Application"]
COPY ["src/SinglePageDemo.Core", "src/SinglePageDemo.Core"]
COPY ["src/SinglePageDemo.EntityFrameworkCore", "src/SinglePageDemo.EntityFrameworkCore"]
WORKDIR "/src/src/SinglePageDemo.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "SinglePageDemo.Web.Host.dll"]
