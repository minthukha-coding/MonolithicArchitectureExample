﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonolithicArchitectureExample.Interfaces;

namespace MonolithicArchitectureExample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_productService.GetAll());
    }
}
