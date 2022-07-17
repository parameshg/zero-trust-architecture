using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Frontend
{
    public class Proxy
    {
        private RestClient Api;

        public Proxy(IConfiguration configuration)
        {
            if (!string.IsNullOrEmpty(configuration["Backend"]))
            {
                Api = new RestClient(configuration["Backend"]);
            }
        }

        public async Task<bool> GetStatus()
        {
            var result = false;

            try
            {
                if (Api != null)
                {
                    result = await Api.GetAsync<object>(new RestRequest("/")) != null;
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public async Task<string> GetNumbers()
        {
            var result = string.Empty;

            try
            {
                if (Api != null)
                {
                    var numbers = await Api.GetAsync<List<int>>(new RestRequest("/numbers"));

                    foreach (var number in numbers)
                    {
                        result += number + ",";
                    }

                    result = result.Substring(0, result.Length - 1);
                }
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        public async Task<int> GetSum()
        {
            var result = 0;

            try
            {
                if (Api != null)
                {
                    result = await Api.GetAsync<int>(new RestRequest("/sum"));
                }
            }
            catch
            {
                result = 0;
            }

            return result;
        }

        public async Task<int> GetCount()
        {
            var result = 0;

            try
            {
                if (Api != null)
                {
                    result = await Api.GetAsync<int>(new RestRequest("/count"));
                }
            }
            catch
            {
                result = 0;
            }

            return result;
        }

        public async Task<double> GetMean()
        {
            double result = 0;

            try
            {
                if (Api != null)
                {
                    result = await Api.GetAsync<double>(new RestRequest("/mean"));
                }
            }
            catch
            {
                result = 0;
            }

            return result;
        }

        public async Task<double> GetVariance()
        {
            double result = 0;

            try
            {
                if (Api != null)
                {
                    result = await Api.GetAsync<double>(new RestRequest("/variance"));
                }
            }
            catch
            {
                result = 0;
            }

            return result;
        }

        public async Task<double> GetStandardDeviation()
        {
            double result = 0;

            try
            {
                if (Api != null)
                {
                    result = await Api.GetAsync<double>(new RestRequest("/sd"));
                }
            }
            catch
            {
                result = 0;
            }

            return result;
        }

        public async Task<bool> Save(int number)
        {
            var result = false;

            try
            {
                if (Api != null)
                {
                    var request = new RestRequest("/input");

                    request.AddBody(number);

                    result = await Api.PostAsync<bool>(request);
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public async Task<bool> Reset()
        {
            var result = false;

            try
            {
                if (Api != null)
                {
                    result = await Api.GetAsync<bool>(new RestRequest("/reset"));
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}