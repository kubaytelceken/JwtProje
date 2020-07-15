using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KT.JwtProje.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KT.JwtProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductControllers : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductControllers(IProductService productService)
        {
            _productService = productService;
        }
        //api/product
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }
    }
}
