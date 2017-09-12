using Autofac;
using CSA.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSAApp.Web
{
    public class ContainerRegistrationModule : Module
    {
        private string _connStr;
        public ContainerRegistrationModule(string connString)
        {
            _connStr = connString;
        }
        protected override void Load(ContainerBuilder builder)
        {

            ContainerRegistration.Setup(builder, _connStr);
            base.Load(builder);

        }
    }
}