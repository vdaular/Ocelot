﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ocelot.Samples.Eureka.DownstreamService.Controllers;

[Route("api/[controller]")]
public class CategoryController : Controller
{
    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new[] { "category1", "category2" };
    }
}
