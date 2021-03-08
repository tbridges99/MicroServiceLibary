using Hackathon.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hackathon.ServiceClients
{
    public interface IHackathonServiceClient
    {
        Task<List<ServiceDTO>> GetServicesAsync(string keywords);
    }
}