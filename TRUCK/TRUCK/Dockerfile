#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TRUCK/TRUCK.csproj", "TRUCK/"]
COPY ["TRUCK.Model/TRUCK.Model.csproj", "TRUCK.Model/"]
COPY ["TRUCK.Core/TRUCK.Core.csproj", "TRUCK.Core/"]
COPY ["TRUCK.Service/TRUCK.Service.csproj", "TRUCK.Service/"]
RUN dotnet restore "./TRUCK/./TRUCK.csproj"
COPY . .
WORKDIR "/src/TRUCK"
RUN dotnet build "./TRUCK.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./TRUCK.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TRUCK.dll"]