using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSA.Common; 
using AutoMapper;
using CSA.Common.Interfaces;

namespace CSA.Data.Repositories
{
    public class Repository : IRepository
    {

        private readonly CSAContext _csaContext;
        private readonly IMapper _mapper;

        public Repository(CSAContext csaContext, IMapper mapper)
        {
            _csaContext = csaContext;
            _mapper = mapper;
        }
        public List<ClientDto> GetAllClients()
        {
            var clients = _csaContext.Clients.ToList();

            List<ClientDto> dtos = _mapper.Map<List<ClientDto>>(clients);
            return dtos;
        }

        public List<ProjectDto> GetAllProjects()
        {
            var projects = _csaContext.Projects.ToList();

            List<ProjectDto> dtos = _mapper.Map<List<ProjectDto>>(projects);
            return dtos;

        }
    }
}
