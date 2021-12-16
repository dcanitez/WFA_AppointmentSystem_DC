using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentSystem_DC.Classes
{
    public class Patient:PersonInfo
    {
        public string DoctorId { get; set; }
        public string Notes { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
