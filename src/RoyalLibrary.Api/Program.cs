using Microsoft.EntityFrameworkCore;
using RoyalLibrary.Core.Repositories;
using RoyalLibrary.Data;
using RoyalLibrary.Data.Repositories;
using RoyalLibrary.Domain;
using RoyalLibrary.Services;
using RoyalLibrary.Services.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("BookContext") ?? "Data Source=Books.db";

builder.Services.AddScoped<IRepository<Book>, BooksRepository>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddDbContext<BookContext>(
        options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/books/{field}/{value}", (string field, string value, IBookService service) =>
{
    return service.SearchBooks(field, value);
})
.WithName("GetBooks")
.WithOpenApi();

app.Run();