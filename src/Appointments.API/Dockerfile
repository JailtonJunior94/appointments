FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Appointments.API/Appointments.API.csproj", "src/Appointments.API/"]
RUN dotnet restore "src/Appointments.API/Appointments.API.csproj"
COPY . .
WORKDIR "/src/src/Appointments.API"
RUN dotnet build "Appointments.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Appointments.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Appointments.API.dll"]