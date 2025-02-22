FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

COPY *.sln ./
COPY GymHelper ./GymHelper/
COPY GymHelper.Application ./GymHelper.Application/
COPY GymHelper.Domain ./GymHelper.Domain/
COPY GymHelper.Exceptions ./GymHelper.Exceptions/
COPY GymHelper.Infrastructure ./GymHelper.Infrastructure/
COPY GymHelper.Tests ./GymHelper.Tests/

RUN dotnet restore

COPY . ./  

FROM mcr.microsoft.com/dotnet/sdk:9.0
WORKDIR /app
EXPOSE 5000
ENTRYPOINT ["dotnet", "watch", "run", "--urls", "http://*:5000"]
