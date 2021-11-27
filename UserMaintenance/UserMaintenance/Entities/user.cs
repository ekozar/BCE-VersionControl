using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenance.Entities
{
    class user
    {
        public Guid guid { get; set; } = Guid.NewGuid();

        public string firstName { get; set; }
        public string lastName { get; set; }


        public string FullName
        {
            get { return lastName + " " + firstName; }
        }

    }
}
