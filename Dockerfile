

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SouthAfricanIDValidation.csproj", "."]
RUN dotnet restore "./SouthAfricanIDValidation.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "SouthAfricanIDValidation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SouthAfricanIDValidation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SouthAfricanIDValidation.dll"]