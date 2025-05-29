var builder = WebApplication.CreateBuilder(args);

//Instructing kestrel web server to listen on port 80
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(80);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
