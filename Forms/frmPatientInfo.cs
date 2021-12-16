using AppointmentSystem_DC.Classes;

namespace AppointmentSystem_DC.Forms
{
    public partial class frmPatientInfo : Form
    {
        public List<Doctor> doctorList;
        public Patient patientSelected;
        public bool isEdit = false;

        public frmPatientInfo()
        {
            InitializeComponent();
        }

        private void frmPatientInfo_Load(object sender, EventArgs e)
        {
            FillDoctorListComboBox();

            if (isEdit)
            {
                txtPatientId.Text = patientSelected.ID;
                txtNameSurname.Text = patientSelected.FullName;
                dtpBirthDate.Value = patientSelected.BirthDate;
                txtPhoneNumber.Text = patientSelected.PhoneNumber;
                txtEmail.Text = patientSelected.Email;
                txtNotes.Text = patientSelected.Notes;
            }

        }
        private void FillDoctorListComboBox()
        {
            cmbDoctorList.Items.Clear();

            foreach (Doctor item in doctorList)
            {
                cmbDoctorList.Items.Add($"{item.ID}-{item.FullName}");

                if (isEdit)
                {
                    if (item.ID == patientSelected.DoctorId)
                    {
                        cmbDoctorList.SelectedIndex = doctorList.IndexOf(item);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: Validations will be completed!

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
