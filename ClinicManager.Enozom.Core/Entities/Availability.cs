using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClinicManager.Enozom.Core.Entities
{
    public class Availability : BaseEntity
    {
        public string DayOfWeek { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int DoctorId { get; set; } // Foreign Key Column
        //public Doctor Doctor { get; set; } // Navigational Property (One) 

    }
}
