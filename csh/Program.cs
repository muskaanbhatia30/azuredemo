var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! my name is muskaan bhatia ...........version-1");

app.Run();
