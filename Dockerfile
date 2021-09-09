FROM mcr.microsoft.com/dotnet/sdk:5.0 AS dotnet-builder

# Optional
WORKDIR /workdir
COPY ./ .

EXPOSE 80
RUN dotnet restore "./yrjournal.csproj"
RUN dotnet publish ./ -c Release -o ./out
RUN cp appsettings.json ./out/

FROM mcr.microsoft.com/dotnet/aspnet:5.0
ENV TZ=Asia/Tehran
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone
WORKDIR /workdir
COPY --from=dotnet-builder /workdir/out .
ENTRYPOINT ["dotnet", "yrjournal.dll"]
