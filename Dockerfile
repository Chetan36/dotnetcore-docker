FROM mcr.microsoft.com/dotnet/core/sdk:2.1

# Create app directory
WORKDIR /usr/src/app/demo

COPY . .

RUN dotnet build -c Release
WORKDIR /usr/src/app/demo/Demo.API/bin/Release/netcoreapp2.1

EXPOSE 80
CMD ["dotnet", "Demo.API.dll"]
