FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

COPY *.sln ./
COPY GymHelper/*.csproj GymHelper/
COPY GymHelper.BusinessLogic/*.csproj GymHelper.BusinessLogic/
COPY GymHelper.BusinessLogic.Library/*.csproj GymHelper.BusinessLogic.Library/
COPY GymHelper.Model/*.csproj GymHelper.Model/
COPY GymHelper.Persistence/*.csproj GymHelper.Persistence/
COPY GymHelper.Services/*.csproj GymHelper.Services/
COPY GymHelper.Test/*.csproj GymHelper.Test/
RUN dotnet restore

COPY . ./  

FROM mcr.microsoft.com/dotnet/sdk:9.0
WORKDIR /app
EXPOSE 5000
ENTRYPOINT ["dotnet", "watch", "run", "--urls", "http://*:5000"]
