using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSA.Common
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ClientDto Client { get; set; }

    }
}
