var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/get-data", () =>
{
    return "Data from Downstream-Api-1";
});

app.Run();
