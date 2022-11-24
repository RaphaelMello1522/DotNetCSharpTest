dotnet build
start dotnet run --project TimeApi
timeout 5
start dotnet run --project Portal
start dotnet run --project Requester
start chrome "http://localhost:5000/Home/information"