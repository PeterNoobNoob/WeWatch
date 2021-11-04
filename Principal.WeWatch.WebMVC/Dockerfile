#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Principal.WeWatch.WebMVC/Principal.WeWatch.WebMVC.csproj", "Principal.WeWatch.WebMVC/"]
RUN dotnet restore "Principal.WeWatch.WebMVC/Principal.WeWatch.WebMVC.csproj"
COPY . .
WORKDIR "/src/Principal.WeWatch.WebMVC"
RUN dotnet build "Principal.WeWatch.WebMVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Principal.WeWatch.WebMVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Principal.WeWatch.WebMVC.dll"]