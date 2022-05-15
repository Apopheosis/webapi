using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi;

[ApiController]
[Route("[controller]")]
public class RegionController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public RegionController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetRegion")]
    public IEnumerable<Region> Get()
    {
        Region[] regions = {(new Region(){Name="France", Capital = "Paris", Continent = "Europe", Population = 300000}), 
        (new Region(){Name="Kenya", Capital="Nairobi", Continent = "Africa", Population = 5000}), 
        (new Region(){Name="Japan", Capital = "Tokyo", Continent = "Asia", Population = 500000000}),
        (new Region(){Name="USA", Capital = "Washington", Continent = "North America", Population = 600000000}),
        (new Region(){Name="Brazil", Capital="Rio", Continent = "South America", Population = 40000000}),
        (new Region(){Name="Australia", Capital = "Canberra", Continent = "Australia", Population = 7000000})};
        return regions;
    }
}