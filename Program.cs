using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>
(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") 
?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));
// Thêm dịch vụ MVC vào container
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();

// Thêm Middleware để xử lý Controller
app.UseAuthorization();
app.MapControllers();


app.Run();
