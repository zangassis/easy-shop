using EasyShop.Data;
using EasyShop.Dtos;
using EasyShop.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProductDbContext>(x => x.UseSqlite(connectionString));
builder.Services.AddTransient<ProductService>();

var app = builder.Build();

app.MapGet("/v1/products", async (ProductService service) =>
{
    var products = await service.FindAll();
    return products.Any() ? Results.Ok(products) : Results.NotFound();
});

app.MapGet("/v1/products/{id}", async (ProductService service, Guid id) =>
{
    var product = await service.FindById(id);
    return product is not null ? Results.Ok(product) : Results.NotFound();
});

app.MapPost("/v1/products", async (ProductService service, CreateProduct product) =>
{
    var resultId = await service.Create(product);
    return Results.Created($"/v1/product/{resultId}", product);
});

app.MapPut("/v1/products/{id}", async (ProductService service, UpdateProduct product, Guid id) =>
{
    await service.Update(product, id);
    return Results.Ok(product);
});

app.MapDelete("/v1/products/{id}", async (ProductService service, Guid id) =>
{
    await service.Delete(id);
    return Results.NoContent();
});

app.Run();
