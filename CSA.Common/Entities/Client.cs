using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Common
{
    public class Client
    {
        public Client()
        {
            Projects = new List<Project>();
        }
        public int Id { get; set; } 
        public string Description { get; set; }
        public ICollection<Project> Projects { get; set; }
        public string WebSiteAddress { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public Guid UpdatedByUserId { get; set; }
        public Guid CreatedByUserId { get; set; }
    }
}
