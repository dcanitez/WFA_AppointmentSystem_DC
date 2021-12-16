namespace AppointmentSystem_DC.Classes
{
    public class Appointment
    {
        public Guid AppointmentID { get; set; } = Guid.NewGuid();
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public string Details { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
