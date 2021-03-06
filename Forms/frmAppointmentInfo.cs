using AppointmentSystem_DC.Classes;

namespace AppointmentSystem_DC.Forms
{
    public partial class frmAppointmentInfo : Form
    {
        public List<Patient> patientList;
        public List<Doctor> doctorList;
        public List<Appointment> appointmentList;
        public Appointment selectedAppointment;
        public bool isEdit = false;

        public frmAppointmentInfo()
        {
            InitializeComponent();
        }

        private void frmAppointmentInfo_Load(object sender, EventArgs e)
        {
            ComboBoxFilling<Patient>(patientList, cmbPatientList);
            ComboBoxFilling<Doctor>(doctorList, cmbDoctorList);

            if (isEdit)
            {
                cmbDoctorList.SelectedItem = selectedAppointment.Doctor;
                cmbPatientList.SelectedItem = selectedAppointment.Patient;
                dtpAppointmentDate.Value = selectedAppointment.AppointmentDate;
                txtDetails.Text = selectedAppointment.Details;
            }

        }

        private void ComboBoxFilling<T>(List<T> list, ComboBox cmb)
        {
            foreach (T item in list)
            {
                cmb.Items.Add(item);
            }
        }
    }
}
