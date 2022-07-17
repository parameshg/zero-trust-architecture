using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private static Store Store = new Store();

        [HttpGet("")]
        public dynamic Index()
        {
            return new
            {
                name = "Backend",
                timestamp = DateTime.Now.ToString(),
                health = true,
                host = Environment.MachineName,
                platform = Environment.OSVersion.VersionString
            };
        }

        [HttpGet("/numbers")]
        public Task<List<int>> GetNumbers()
        {
            var result = new List<int>();

            foreach (var item in Store.Items)
            {
                result.Add(item);
            }

            return Task.FromResult(result);
        }

        [HttpGet("/count")]
        public Task<int> GetCount()
        {
            var result = -1;

            result = Store.Count;

            return Task.FromResult(result);
        }

        [HttpGet("/sum")]
        public Task<int> GetSum()
        {
            var result = -1;

            result = Store.Sum;

            return Task.FromResult(result);
        }

        [HttpGet("/mean")]
        public Task<double> GetMean()
        {
            double result = -1;

            result = Store.Mean;

            return Task.FromResult(result);
        }

        [HttpGet("/variance")]
        public Task<double> GetVariance()
        {
            double result = -1;

            result = Store.Variance;

            return Task.FromResult(result);
        }

        [HttpGet("/sd")]
        public Task<double> GetDeviation()
        {
            double result = -1;

            result = Store.StandardDeviation;

            return Task.FromResult(result);
        }

        [HttpGet("/reset")]
        public Task<bool> Reset()
        {
            var result = false;

            Store.Clear();

            Publish();

            result = true;

            return Task.FromResult(result);
        }

        [HttpGet("/publish")]
        public Task Publish()
        {
            //await PublishEventAsync(new
            //{
            //    Mean = Store.Mean,
            //    Variance = Store.Variance,
            //    StandardDeviation = Store.StandardDeviation
            //});

            return Task.CompletedTask;
        }

        [HttpPost("/subscribe")]
        public void Subscribe([FromBody] object @event)
        {
            Console.WriteLine(JsonConvert.SerializeObject(@event));
        }

        [HttpPost("/input")]
        public Task<bool> Save([FromBody] int number)
        {
            var result = false;

            Store.Add(number);

            result = true;

            return Task.FromResult(result);
        }
    }
}