using System.Collections.Generic;
using System.Threading.Tasks;
using Voltron.Hackathon.Models;

namespace Voltron.Hackathon.Repositories
{
    public interface IServiceRepository
    {
        Task<List<ServiceEntity>> GetServicesAsync(string keywords);
        Task<ServiceEntity> GetServiceDetailsAsync(int id);
    }
}