using Consul;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class Agent
    {
        public async Task Register(string name, string address, int port)
        {
            using (var consul = new ConsulClient())
            {
                await consul.Agent.ServiceRegister(new AgentServiceRegistration
                {
                    Name = name,
                    Port = port,
                    Address = address
                });
            }
        }
    }
}