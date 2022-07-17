using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Frontend.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public Proxy Backend { get; }

        public HomeController(Proxy backend)
        {
            Backend = backend;
        }

        [HttpGet("")]
        public async Task<dynamic> Index()
        {
            return new
            {
                name = "Frontend",
                timestamp = DateTime.Now.ToString(),
                health = await Backend.GetStatus(),
                host = Environment.MachineName,
                platform = Environment.OSVersion.VersionString
            };
        }

        [HttpGet("/config/{key}")]
        public async Task<string> GetConfiguration(string key, [FromQuery] bool secret)
        {
            var result = string.Empty;

            if (secret)
            {
                // TODO: read from Hashicorp Vault
            }
            else
            {
                // TODO: read from Hashicorp Consul
            }

            return result;
        }

        [HttpPost("/config/{key}")]
        public Task<bool> SetConfiguration(string key, [FromBody] string value, [FromQuery] bool secret)
        {
            var result = false;

            if (secret)
            {
                // TODO: save to Hashicorp Vault
            }
            else
            {
                // TODO: save to Hashicorp Consul
            }

            return Task.FromResult(result);
        }

        [HttpGet("/fibonacci")]
        public async Task<dynamic> GetFibonacci([FromQuery] int count = 10)
        {
            dynamic result = new { count = 0, sum = 0, mean = 0, variance = 0, deviation = 0 };

            async Task Fibonacci(int firstNumber, int secondNumber, int counter, int length)
            {
                if (counter < length)
                {
                    if (await Backend.Save(secondNumber))
                    {
                        await Fibonacci(secondNumber, firstNumber + secondNumber, counter + 1, length);
                    }
                }
            }

            if (await Backend.Reset())
            {
                if (await Backend.Save(0))
                {
                    await Fibonacci(0, 1, 1, count);

                    result = new
                    {
                        numbers = await Backend.GetNumbers(),
                        count = await Backend.GetCount(),
                        sum = await Backend.GetSum(),
                        mean = await Backend.GetMean(),
                        variance = await Backend.GetVariance(),
                        deviation = await Backend.GetStandardDeviation()
                    };
                }
            }

            return result;
        }
    }
}