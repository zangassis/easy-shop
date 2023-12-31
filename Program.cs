using System.Reflection;
using EasyShop.Data;
using EasyShop.Models.Dtos;
using EasyShop.Services;
using EasyShop.Validators;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProductDbContext>(x => x.UseSqlite(connectionString));
builder.Services.AddTransient<ProductService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IValidator<CreateUpdateProduct>, ProductValidator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "EasyShop", Description = "EasyShop", Version = "v1" });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);

});
builder.Services.AddControllers();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "EasyShop V1");
});
app.MapControllers();

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

app.MapPost("/v1/products", async (ProductService service, CreateUpdateProduct product, IValidator<CreateUpdateProduct> validator) =>
{
    var validationResult = validator.Validate(product);

    if (!validationResult.IsValid)
        return Results.BadRequest(validationResult.Errors);

    var resultId = await service.Create(product);
    return Results.Created($"/v1/product/{resultId}", product);
});

app.MapPut("/v1/products/{id}", async (ProductService service, CreateUpdateProduct product, Guid id) =>
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
