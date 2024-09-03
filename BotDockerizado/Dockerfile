# Use the official .NET SDK image to build the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the solution and project files
COPY BotDockerizado.sln ./
COPY BotDockerizado.Service/*.csproj ./BotDockerizado.Service/
COPY BotDockerizado.ConsoleApp/*.csproj ./BotDockerizado.ConsoleApp/
COPY SeleniumConfig/*.csproj ./SeleniumConfig/

# Restore the dependencies
RUN dotnet restore "BotDockerizado.ConsoleApp/BotDockerizado.ConsoleApp.csproj"

# Copy the rest of the application files
COPY . ./

# Build the project
RUN dotnet publish BotDockerizado.ConsoleApp/BotDockerizado.ConsoleApp.csproj -c Release -o out

# Use the official .NET runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory inside the container
WORKDIR /app

# Install Chrome
RUN apt-get update && apt-get install -y wget gnupg2 && \
    wget -q -O - https://dl.google.com/linux/linux_signing_key.pub | apt-key add - && \
    sh -c 'echo "deb [arch=amd64] http://dl.google.com/linux/chrome/deb/ stable main" >> /etc/apt/sources.list.d/google-chrome.list' && \
    apt-get update && apt-get install -y google-chrome-stable && \
    rm -rf /var/lib/apt/lists/*

# Copy the build output from the previous stage
COPY --from=build /app/out .

# Set environment variables for Chrome to run in headless mode
ENV DISPLAY=:99

# Entry point for the console application
ENTRYPOINT ["dotnet", "BotDockerizado.ConsoleApp.dll"]
