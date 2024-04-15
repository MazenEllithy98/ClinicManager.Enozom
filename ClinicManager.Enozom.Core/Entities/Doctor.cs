using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Enozom.Core.Entities
{
    public class Doctor : BaseEntity
    {
        public Doctor()
        {
            Availabilities = new List<Availability>();
        }
        public string Name { get; set; }
        public List<Availability> Availabilities { get; set; }
    }
}
