FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY ./FrontendDotnet.sln ./
COPY Category.UI/*.csproj ./Category.UI/
RUN dotnet restore ./FrontendDotnet.sln

COPY . .
WORKDIR /app/Category.UI
RUN dotnet publish -c Release -o /app/publish

FROM nginx:alpine AS runtime
COPY ./Category.UI/nginx.conf /etc/nginx/nginx.conf
COPY --from=build /app/publish/wwwroot /usr/share/nginx/html

EXPOSE 80
