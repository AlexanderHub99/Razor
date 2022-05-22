FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Raxor/Raxor.csproj", "Raxor/"]
RUN dotnet restore "Raxor/Raxor.csproj"
COPY . .
WORKDIR "/src/Raxor"
RUN dotnet build "Raxor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Raxor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Raxor.dll"]
