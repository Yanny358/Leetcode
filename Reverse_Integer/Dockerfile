﻿FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Reverse_Integer/Reverse_Integer.csproj", "Reverse_Integer/"]
RUN dotnet restore "Reverse_Integer/Reverse_Integer.csproj"
COPY . .
WORKDIR "/src/Reverse_Integer"
RUN dotnet build "Reverse_Integer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Reverse_Integer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reverse_Integer.dll"]
