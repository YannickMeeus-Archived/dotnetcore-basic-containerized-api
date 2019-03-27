FROM mcr.microsoft.com/dotnet/core/sdk:2.2 as build-image
 
WORKDIR /home/app
 
COPY ./*.sln ./
COPY ./*/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p ./${file%.*}/ && mv $file ./${file%.*}/; done
 
RUN dotnet restore
 
COPY . .

RUN dotnet publish ./Basic.Containerized.App.Web.Api/Basic.Containerized.App.Web.Api.csproj -o /publish/ --no-restore

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2

WORKDIR /publish

COPY --from=build-image /publish .

ENTRYPOINT ["dotnet", "Basic.Containerized.App.Web.Api.dll"]