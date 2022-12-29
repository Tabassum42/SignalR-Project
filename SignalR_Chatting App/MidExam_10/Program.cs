using MidExam_10.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.MapHub<MessageAndFileShareHub>("/messageAndFileShareHub");
app.Run();