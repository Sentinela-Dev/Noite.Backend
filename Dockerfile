# Use the official image as a parent image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Set the working directory
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

COPY . ./

RUN dotnet publish -c Release -o out ./Noite.Backend.UI/Noite.Backend.UI.csproj

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY --from=build /out ./

ENTRYPOINT ["dotnet", "Noite.Backend.UI.dll"]
