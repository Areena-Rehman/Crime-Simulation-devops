var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new {
    status = "Crime Simulation API is running ✅ - Fleetlery DevOps Pipeline Working!",
    version = "1.0.0",
    timestamp = DateTime.UtcNow
});

app.MapGet("/health", () => new {
    healthy = true,
    service = "Crime Simulation API",
    uptime = "Server is operational"
});

app.MapGet("/orders", () => new {
    total_orders = 247,
    active = 183,
    completed = 64,
    message = "Live order data from Crime Simulation"
});

app.Run();