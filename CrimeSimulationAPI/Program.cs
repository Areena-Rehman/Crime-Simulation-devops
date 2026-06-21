var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new {
    status = "Crime Simulation API is running ✅",
    version = "1.0.0",
    timestamp = DateTime.UtcNow
});

app.MapGet("/health", () => new {
    healthy = true,
    service = "Crime Simulation API",
    uptime = "Server is operational"
});

app.Run();