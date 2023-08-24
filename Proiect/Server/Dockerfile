#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Proiect/Server/Proiect.Server.csproj", "Proiect/Server/"]
COPY ["Proiect/Client/Proiect.Client.csproj", "Proiect/Client/"]
COPY ["Proiect/Shared/Proiect.Shared.csproj", "Proiect/Shared/"]
RUN dotnet restore "Proiect/Server/Proiect.Server.csproj"
COPY . .
WORKDIR "/src/Proiect/Server"
RUN dotnet build "Proiect.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Proiect.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Proiect.Server.dll"]