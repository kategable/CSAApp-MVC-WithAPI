using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Common.Config
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration SetUp()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Client, ClientDto>();
                    cfg.CreateMap<Project, ProjectDto>();
                }
                );
            return config;

            //IMapper mapper = config.CreateMapper();
            //Mapper.Initialize(cfg => cfg.CreateMap<Client, ClientDto>());
            //Mapper.Initialize(cfg => cfg.CreateMap<Project, ProjectDto>());

            //IMapper mapper = config.CreateMapper();
            //var source = new Source();
            //var dest = mapper.Map<Source, Dest>(source);
        }

    }
}
