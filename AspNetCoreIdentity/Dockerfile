FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY AspNetCoreIdentity/AspNetCoreIdentity.csproj AspNetCoreIdentity/
RUN dotnet restore AspNetCoreIdentity/AspNetCoreIdentity.csproj
COPY . .
WORKDIR /src/AspNetCoreIdentity
RUN dotnet build AspNetCoreIdentity.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AspNetCoreIdentity.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AspNetCoreIdentity.dll"]
