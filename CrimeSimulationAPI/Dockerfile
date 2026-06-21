# Step 1 - Use official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

# Step 2 - Set working directory inside container
WORKDIR /app

# Step 3 - Copy project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Step 4 - Copy all code and build it
COPY . ./
RUN dotnet publish -c Release -o out

# Step 5 - Use smaller runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app/out .

# Step 6 - Start the app
ENTRYPOINT ["dotnet", "CrimeSimulationAPI.dll"]