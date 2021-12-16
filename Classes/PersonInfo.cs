using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentSystem_DC.Classes
{
    public abstract class PersonInfo
    {
        public string ID { get; set; }
        public string FullName { get; set; }        
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{this.ID}-{this.FullName}";
        }
    }
}
