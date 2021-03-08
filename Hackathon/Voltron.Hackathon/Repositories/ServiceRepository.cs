using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voltron.Hackathon.Context;
using Voltron.Hackathon.Models;

namespace Voltron.Hackathon.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ServiceDirectoryContext _context;

        public ServiceRepository(
            ServiceDirectoryContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceEntity>> GetServicesAsync(string keywords)
        {
            return await _context.Services.ToListAsync();
        }

        public async Task<ServiceEntity> GetServiceDetailsAsync(int id)
        {
            return await _context.Services.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

    }
}
