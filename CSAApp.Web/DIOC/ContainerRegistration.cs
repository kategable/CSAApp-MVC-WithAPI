using Autofac;
using AutoMapper;
using CSA.Business;
using CSA.Common.Config;
using CSA.Common.Interfaces;
using CSA.Data;
using CSA.Data.Repositories;

namespace CSA.Web
{
    public static class ContainerRegistration
    {
        public static void Setup(ContainerBuilder builder, string _connStr)
        {
       
            builder.Register(c => {
                var db = new CSAContext(_connStr);
                var config = AutoMapperConfig.SetUp();
                IMapper mapper = config.CreateMapper();
                var rep = new Repository(db, mapper);
                return rep;
            }).As<IRepository>().InstancePerLifetimeScope();

            builder.Register(c => new CSAService(c.Resolve<IRepository>())).As<ICSAService>().InstancePerLifetimeScope();

        }
    }
}
