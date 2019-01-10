FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Artemis.QueryNode.Application/Artemis.QueryNode.Application.csproj Artemis.QueryNode.Application/
RUN dotnet restore Artemis.QueryNode.Application/Artemis.QueryNode.Application.csproj
COPY . .
WORKDIR /src/Artemis.QueryNode.Application
RUN dotnet build Artemis.QueryNode.Application.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Artemis.QueryNode.Application.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Artemis.QueryNode.Application.dll"]
