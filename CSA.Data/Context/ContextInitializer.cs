using CSA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Data
{
    public class ContextInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CSAContext>
    {

        protected override void Seed(CSAContext context)
        {
            var time = DateTime.UtcNow;
            var clients = new List<Client>
            {
            new Client{Description="Amazon",WebSiteAddress="http://www.amazon.com", UpdatedDateTime=time, CreatedDateTime=time},
            new Client{Description="Tesla",WebSiteAddress="http://www.tesla.com", UpdatedDateTime=time, CreatedDateTime=time},
            new Client{Description="Uber",WebSiteAddress="http://www.uber.com", UpdatedDateTime=time, CreatedDateTime=time} };

            clients.ForEach(s => context.Clients.Add(s));          
            context.SaveChanges();


        }
    }
}
