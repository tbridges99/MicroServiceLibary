using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class ServiceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DevURL { get; set; }
        public string QAURL { get; set; }
        public bool IsLegacy { get; set; }
        public DateTime? DevLastActiveDTS { get; set; }
        public DateTime? QALastActiveDTS { get; set; }
        public bool IsGenerated { get; set; }
        public string Team { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string CurrentVersion { get; set; }
        public string LoggingApplicationName { get; set; }
        public bool IsJwt { get; set; }
    }
}
