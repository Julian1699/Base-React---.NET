# Usa una imagen base de .NET 8.0 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia los archivos .csproj y restaura las dependencias
COPY *.csproj ./
RUN dotnet restore

# Copia el resto de los archivos y compila la aplicación
COPY . ./
RUN dotnet publish -c Release -o out

# Usa una imagen base de .NET 8.0 Runtime para la ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Copiar el script wait-for-it.sh
COPY wait-for-it.sh /wait-for-it.sh
RUN chmod +x /wait-for-it.sh

# Expone el puerto en el que la aplicación estará escuchando
EXPOSE 5001

# Comando por defecto para ejecutar la aplicación
ENTRYPOINT ["/wait-for-it.sh", "db-postgres:5432", "--", "dotnet", "backend-.Net.dll"]
