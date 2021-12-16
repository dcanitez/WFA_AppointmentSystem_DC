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
    public partial class frmDoctorInfo : Form
    {        
        public bool IsEdit=false;
        public Doctor selectedDoctor;
        public frmDoctorInfo()
        {
            InitializeComponent();
        }
        private void frmDoctorInfo_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                txtDoctorId.Text = selectedDoctor.ID;
                txtNameSurname.Text = selectedDoctor.FullName;
                txtField.Text = selectedDoctor.Field;
                txtPhoneNumber.Text = selectedDoctor.PhoneNumber;
                txtEmail.Text = selectedDoctor.Email;
            }
        }        

        

    }
}
