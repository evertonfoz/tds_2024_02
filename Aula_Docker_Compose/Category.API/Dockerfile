# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copie os arquivos da solução e restaure as dependências
COPY ./BackendDotnet.sln ./
COPY Category.API/*.csproj ./Category.API/
COPY Models/*.csproj ./Models/
COPY Persistence/*.csproj ./Persistence/
RUN dotnet restore ./BackendDotnet.sln

# Copie o restante do código e publique a aplicação
COPY . .
WORKDIR /app/Category.API
RUN dotnet publish -c Release -o out

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/Category.API/out ./

# Escute na porta 80
ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT ["dotnet", "Category.API.dll"]