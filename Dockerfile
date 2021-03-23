FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Main/Tech.Cluee.HisWeb/Tech.Cluee.HisWeb.csproj", "Main/Tech.Cluee.HisWeb/"]
COPY ["App/Tech.Cluee.HisData/Tech.Cluee.HisData.csproj", "App/Tech.Cluee.HisData/"]
COPY ["App/Tech.Cluee.SchoolData/Tech.Cluee.SchoolData.csproj", "App/Tech.Cluee.SchoolData/"]
RUN dotnet restore "Main/Tech.Cluee.HisWeb/Tech.Cluee.HisWeb.csproj"
COPY . .
WORKDIR "/src/Main/Tech.Cluee.HisWeb"
RUN dotnet build "Tech.Cluee.HisWeb.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "Tech.Cluee.HisWeb.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tech.Cluee.HisWeb.dll"]