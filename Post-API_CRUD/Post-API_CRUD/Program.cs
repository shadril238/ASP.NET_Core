using Microsoft.EntityFrameworkCore;
using Post_API_CRUD.Context;
using Post_API_CRUD.Interfaces.Manager;
using Post_API_CRUD.Manager;

var builder = WebApplication.CreateBuilder(args);

// For database connection 
builder.Services.AddDbContext<PostDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));
// For dependency injection
builder.Services.AddTransient<IPostManager, PostManager>();
//builder.Services.AddScoped<IPostManager, PostManager>();
//builder.Services.AddSingleton<IPostManager, PostManager>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
