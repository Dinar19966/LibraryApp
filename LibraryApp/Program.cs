using LibraryApp.Entity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// ???????? ?????? ??????????? ?? ????? ????????????
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ????????? ???????? ApplicationContext ? ???????? ??????? ? ??????????
builder.Services.AddDbContext<LibraryAppContext>(options => options.UseSqlServer(connection));

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
