# Use a imagem oficial do .NET SDK 9.0 como ambiente de build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copie os arquivos de projeto e restaure as dependências
COPY *.sln ./
COPY GymHelper/*.csproj ./GymHelper/
COPY GymHelper.BusinessLogic/*.csproj ./GymHelper.BusinessLogic/
COPY GymHelper.BusinessLogic.Library/*.csproj ./GymHelper.BusinessLogic.Library/
COPY GymHelper.Model/*.csproj ./GymHelper.Model/
COPY GymHelper.Persistence/*.csproj ./GymHelper.Persistence/
COPY GymHelper.Services/*.csproj ./GymHelper.Services/
COPY GymHelper.Test/*.csproj ./GymHelper.Test/
RUN dotnet restore

# Copie o restante dos arquivos e compile a aplicação
COPY . ./
RUN dotnet publish -c Release -o out

# Crie a imagem runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .
EXPOSE 5000
ENTRYPOINT ["dotnet", "GymHelper.dll"]

