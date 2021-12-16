using AppointmentSystem_DC.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentSystem_DC.Forms
{
    public partial class frmMainScreen : Form
    {
        #region Global Variables

        List<Doctor> doctors = new List<Doctor>();
        List<Patient> patients = new List<Patient>();
        List<Appointment> appointments = new List<Appointment>();

        string doctorFilePath = Application.StartupPath + "\\doctorList.txt";
        string patientFilePath = Application.StartupPath + "\\patientList.txt";
        string appointmentFilePath = Application.StartupPath + "\\appointmentList.txt"; 

        #endregion
        public frmMainScreen()
        {
            InitializeComponent();
        }

        #region Event Management

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            txtNotes.Enabled = false;

            if (File.Exists(doctorFilePath) && File.Exists(patientFilePath))
            {
                RetrieveDataFromFile();
                FillTreeViewList();
            }
            if (File.Exists(appointmentFilePath))
            {
                RetrieveDataForAppointments();
                LoadAppointmentsToListView(appointments);
            }
        }
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            frmDoctorInfo frm = new frmDoctorInfo();
            frm.btnDelete.Visible = false;
            frm.btnSave.Text = "Add";
            frm.Text = "Add New Doctor";

            if (frm.ShowDialog() == DialogResult.OK)
            {
                doctors.Add(new Doctor
                {
                    ID = frm.txtDoctorId.Text,
                    FullName = frm.txtNameSurname.Text.ToUpper(),
                    PhoneNumber = frm.txtPhoneNumber.Text,
                    Email = frm.txtEmail.Text,
                    Field = frm.txtField.Text
                });
            }
            FillTreeViewList();
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmPatientInfo frm = new frmPatientInfo();
            frm.btnDelete.Visible = false;
            frm.doctorList = doctors;
            frm.btnSave.Text = "Add";
            frm.Text = "Add New Patient";

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string doctorId = frm.cmbDoctorList.Text.Split('-')[0];
                patients.Add(new Patient
                {
                    ID = frm.txtPatientId.Text,
                    FullName = frm.txtNameSurname.Text,
                    BirthDate = frm.dtpBirthDate.Value,
                    PhoneNumber = frm.txtPhoneNumber.Text,
                    Email = frm.txtEmail.Text,
                    DoctorId = doctorId,
                    Notes = frm.txtNotes.Text
                });
            }
            FillTreeViewList();
        }
        private void trvList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            List<Appointment> listChanged = new List<Appointment>();
            TreeNode selectedNode = trvList.SelectedNode;
            object obj=selectedNode.Tag;            

            if (obj.GetType() == typeof(Patient))
            {
                Patient pat = (Patient)obj;

                foreach (Appointment item in appointments)
                {
                    if (item.Patient==pat)
                    {
                        listChanged.Add(item);
                    }
                }
                LoadAppointmentsToListView(listChanged);
            }
            if (obj.GetType() == typeof(Doctor))
            {
                Doctor doc = (Doctor)obj;

                foreach (Appointment item in appointments)
                {
                    if (item.Doctor == doc)
                    {
                        listChanged.Add(item);
                    }
                }

                LoadAppointmentsToListView(listChanged);
            }
        }
        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            frmDoctorInfo frm = new frmDoctorInfo();
            frm.Text = "Doctor Details";
            frm.btnSave.Text = "Save";
            frm.IsEdit = true;

            TreeNode tnSelectedDoctor = trvList.SelectedNode;

            if (trvList.SelectedNode == null || tnSelectedDoctor.Tag.GetType() != typeof(Doctor))
            {
                MessageBox.Show("Please select a doctor from below list to edit details.", "Request");
                return;
            }

            Doctor doctor = tnSelectedDoctor.Tag as Doctor;
            frm.selectedDoctor = doctor;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                doctor.FullName = frm.txtNameSurname.Text;
                doctor.Field = frm.txtField.Text;
                doctor.PhoneNumber = frm.txtPhoneNumber.Text;
                doctor.Email = frm.txtEmail.Text;

                if (doctor.ID != frm.txtDoctorId.Text)
                {
                    foreach (TreeNode item in tnSelectedDoctor.Nodes)
                    {
                        Patient patient = item.Tag as Patient;
                        patient.DoctorId = frm.txtDoctorId.Text;
                    }
                }
                doctor.ID = frm.txtDoctorId.Text;

                FillTreeViewList();
            }


        }
        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            TreeNode tnSelectedPatient = trvList.SelectedNode;

            if (tnSelectedPatient == null || tnSelectedPatient.Tag.GetType() != typeof(Patient))
            {
                MessageBox.Show("Please select a Patient from the below list to see details", "Request");
                return;
            }

            Patient patient = tnSelectedPatient.Tag as Patient;

            frmPatientInfo frm = new frmPatientInfo();
            frm.isEdit = true;
            frm.Text = "Patient Details";
            frm.patientSelected = patient;
            frm.doctorList = doctors;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string doctorId = frm.cmbDoctorList.Text.Split('-')[0];

                patient.ID = frm.txtPatientId.Text;
                patient.FullName = frm.txtNameSurname.Text.ToUpper();
                patient.BirthDate = frm.dtpBirthDate.Value;
                patient.PhoneNumber = frm.txtPhoneNumber.Text;
                patient.Email = frm.txtEmail.Text;
                patient.DoctorId = doctorId;
                patient.Notes = frm.txtNotes.Text;
            }

            FillTreeViewList();




        }
        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            TreeNode tnSelectedDoctor = trvList.SelectedNode;

            if (trvList.SelectedNode == null || tnSelectedDoctor.Tag.GetType() != typeof(Doctor))
            {
                MessageBox.Show("Please select a doctor from below list to edit details.", "Request");
                return;
            }
            Doctor doctor = tnSelectedDoctor.Tag as Doctor;
            DialogResult result = MessageBox.Show($"{doctor.FullName} will be deleted permanently.\n Are you sure to delete him/her?", "Delete Doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (TreeNode item in tnSelectedDoctor.Nodes)
                {
                    patients.Remove(item.Tag as Patient);
                }

                doctors.Remove(doctor);
            }

            FillTreeViewList();


        }
        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (trvList.SelectedNode == null || trvList.SelectedNode.Tag.GetType() != typeof(Patient))
            {
                MessageBox.Show("Please select a Patient from the below list to see details", "Request");
                return;
            }

            Patient patient = trvList.SelectedNode.Tag as Patient;

            DialogResult result = MessageBox.Show($"{patient.FullName} will be deleted permanently.\n Are you sure to delete him/her?", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                patients.Remove(patient);
            }

            FillTreeViewList();
        }
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            frmAppointmentInfo frm = new frmAppointmentInfo();
            frm.doctorList = doctors;
            frm.patientList = patients;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                appointments.Add(new Appointment
                {
                    Patient = (Patient)(frm.cmbPatientList.SelectedItem),
                    Doctor = (Doctor)(frm.cmbDoctorList.SelectedItem),
                    AppointmentDate = frm.dtpAppointmentDate.Value,
                    Details = frm.txtDetails.Text
                });

                LoadAppointmentsToListView(appointments);
            }
        }
        private void lvAppointments_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Appointment app = (Appointment)lvAppointments.SelectedItems[0].Tag;

            if (app != null)
            {
                frmAppointmentInfo frm = new frmAppointmentInfo();
                frm.doctorList = doctors;
                frm.patientList = patients;
                frm.selectedAppointment = app;
                frm.isEdit = true;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    app.Patient = (Patient)(frm.cmbPatientList.SelectedItem);
                    app.Doctor = (Doctor)(frm.cmbDoctorList.SelectedItem);
                    app.AppointmentDate = frm.dtpAppointmentDate.Value;
                    app.Details = frm.txtDetails.Text;
                }

                LoadAppointmentsToListView(appointments);

            }
        }
        private void lvAppointments_MouseClick(object sender, MouseEventArgs e)
        {
            Appointment appSelected = (Appointment)lvAppointments.SelectedItems[0].Tag;
            if (lvAppointments.SelectedItems != null)
            {
                txtNotes.Text = appSelected.Details;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAppointmentsToListView(appointments);
        }
        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (lvAppointments.SelectedItems != null)
            {
                Appointment appSelected = (Appointment)lvAppointments.SelectedItems[0].Tag;
                DialogResult result = MessageBox.Show($"Appointment record for {appSelected.Patient.FullName} will be deleted permanently.\n Are you sure to delete?", "Cancel Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    appointments.Remove(appSelected);
                }

                LoadAppointmentsToListView(appointments);
            }
            else
            {
                MessageBox.Show("Please select an appointment from list below");
                return;
            }
        } 
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            List<string> appLines = new List<string>();
            foreach (Appointment item in appointments)
            {
                appLines.Add($"{item.AppointmentID}|{item.Patient}|{item.Doctor}|{item.AppointmentDate.ToShortTimeString()}|{item.Details}");
            }
            File.WriteAllLines(appointmentFilePath, appLines);

        }

        #endregion


        #region Methods
        private void LoadAppointmentsToListView(List<Appointment> list)
        {
            lvAppointments.Items.Clear();
            ListViewItem lvi;
            foreach (Appointment item in list)
            {
                lvi = new ListViewItem(item.AppointmentID.ToString());
                lvi.SubItems.Add(item.Patient.FullName);
                lvi.SubItems.Add(item.Doctor.FullName);
                lvi.SubItems.Add(item.AppointmentDate.ToShortDateString());
                lvi.Tag = item;

                lvAppointments.Items.Add(lvi);
            }
        }
        private void FillTreeViewList()
        {
            trvList.Nodes.Clear();
            foreach (Doctor item in doctors)
            {
                TreeNode tnDoctor = new TreeNode(item.FullName);
                tnDoctor.Tag = item;

                foreach (Patient patient in patients)
                {
                    if (patient.DoctorId == item.ID)
                    {
                        TreeNode tnPatient = new TreeNode(patient.FullName);
                        tnPatient.Tag = patient;
                        tnDoctor.Nodes.Add(tnPatient);
                    }
                }
                trvList.Nodes.Add(tnDoctor);
            }
            trvList.ExpandAll();
        }
        private void Save()
        {
            List<string> doctorLines = new List<string>();
            List<string> patientLines = new List<string>();

            foreach (Doctor item in doctors)
            {
                doctorLines.Add($"{item.ID}|{item.FullName}|{item.Field}|{item.PhoneNumber}|{item.Email}");
            }

            foreach (Patient item in patients)
            {
                patientLines.Add($"{item.ID}|{item.FullName}|{item.BirthDate.ToShortDateString()}|{item.PhoneNumber}|{item.Email}|{item.Notes}|{item.DoctorId}");
            }

            File.WriteAllLines(doctorFilePath, doctorLines);
            File.WriteAllLines(patientFilePath, patientLines);
        }
        private void RetrieveDataFromFile()
        {
            List<string> doctorLines = File.ReadAllLines(doctorFilePath).ToList();
            List<string> patientLines = File.ReadAllLines(patientFilePath).ToList();


            foreach (string item in doctorLines)
            {
                string[] lineParts = item.Split('|');

                doctors.Add(new Doctor
                {
                    ID = lineParts[0],
                    FullName = lineParts[1],
                    Field = lineParts[2],
                    PhoneNumber = lineParts[3],
                    Email = lineParts[4]
                });
            }

            foreach (string item in patientLines)
            {
                string[] lineParts = item.Split('|');
                patients.Add(new Patient
                {
                    ID = lineParts[0],
                    FullName = lineParts[1],
                    BirthDate = DateTime.Parse(lineParts[2]),
                    PhoneNumber = lineParts[3],
                    Email = lineParts[4],
                    Notes = lineParts[5],
                    DoctorId = lineParts[6]
                });
            }            

        }

        private void RetrieveDataForAppointments()
        {
            List<string> appLines = File.ReadAllLines(appointmentFilePath).ToList();
            foreach (string item in appLines)
            {
                string[] lineParts = item.Split('|');
                appointments.Add(new Appointment
                {
                    AppointmentID = Guid.Parse(lineParts[0]),
                    Patient = patients.Where(a => a.ID == lineParts[1].Split('-')[0]).FirstOrDefault(),
                    Doctor = doctors.Where(a => a.ID == lineParts[2].Split('-')[0]).FirstOrDefault(),
                    AppointmentDate = DateTime.Parse(lineParts[3]),
                    Details = lineParts[4]
                });
            }
        }

        #endregion

    }
}
