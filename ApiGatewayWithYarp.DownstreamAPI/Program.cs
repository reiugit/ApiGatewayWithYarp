var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/downstream-api", () =>
{
    return "Data - from Downstream-Api";
});

app.Run();
