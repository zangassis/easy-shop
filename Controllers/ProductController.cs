using EasyShop.Models.Dtos;
using EasyShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyShop.Endpoints;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductService _service;

    public ProductController(ProductService service)
    {
        _service = service;
    }

    /// <summary>
    /// Complete list of products
    /// </summary>
    /// <returns>List of products</returns>
    /// <response code="200">Returns the complete list of products</response>
    [HttpGet(Name = "GetProducts")]
    public async Task<ActionResult<List<ProductDto>>> Get()
    {
        var products = await _service.FindAll();
        return Ok(products);
    }
}