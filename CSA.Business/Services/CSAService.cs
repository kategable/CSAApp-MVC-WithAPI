using System.Collections.Generic;
using System.Threading.Tasks;
using CSA.Common;
using CSA.Common.Interfaces;

namespace CSA.Business
{
    public class CSAService : ICSAService
    {
        private readonly IRepository _repository;
        public CSAService(IRepository repository)
        {
            _repository = repository;
        }

        public Task<List<ClientDto>> GetAllClients()
        {
            return Task.Run(() => _repository.GetAllClients());
        }

        public Task<List<ProjectDto>> GetAllProjects()
        {
            return Task.Run(() => _repository.GetAllProjects());
        }
    }
}
