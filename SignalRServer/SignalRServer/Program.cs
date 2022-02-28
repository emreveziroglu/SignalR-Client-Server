using SignalRServer.Hubs;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options=>options.AddDefaultPolicy(policy=>
policy.AllowAnyMethod()
.AllowAnyHeader()
.AllowCredentials()
.SetIsOriginAllowed(orgiýn=>true)
));
builder.Services.AddSignalR();
var app = builder.Build();


//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapHub<MyHub>("/myhub");
//});
app.UseCors();
app.MapHub<MyHub>("/myhub");

app.Run();
