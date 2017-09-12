using CSA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Common.Interfaces
{
    public interface ICSAService
    {
        Task< List<ClientDto>> GetAllClients();
        Task<List<ProjectDto>> GetAllProjects();
    }
}
