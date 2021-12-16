namespace AppointmentSystem_DC.Forms
{
    partial class frmMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvList = new System.Windows.Forms.TreeView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddDoctor = new System.Windows.Forms.ToolStripButton();
            this.btnEditDoctor = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDoctor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddPatient = new System.Windows.Forms.ToolStripButton();
            this.btnEditPatient = new System.Windows.Forms.ToolStripButton();
            this.btnDeletePatient = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveInfo = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvAppointments = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddAppointment = new System.Windows.Forms.ToolStripButton();
            this.btnCancelAppointment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveToFile = new System.Windows.Forms.ToolStripButton();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvList);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 544);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // trvList
            // 
            this.trvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvList.Location = new System.Drawing.Point(0, 27);
            this.trvList.Name = "trvList";
            this.trvList.Size = new System.Drawing.Size(297, 517);
            this.trvList.TabIndex = 1;
            this.trvList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvList_NodeMouseDoubleClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnAddDoctor,
            this.btnEditDoctor,
            this.btnDeleteDoctor,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.btnAddPatient,
            this.btnEditPatient,
            this.btnDeletePatient,
            this.toolStripSeparator4,
            this.btnSaveInfo});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(297, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = global::AppointmentSystem_DC.Properties.Resources.doctor_png;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(20, 24);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddDoctor.Image = global::AppointmentSystem_DC.Properties.Resources._1891032_add_append_circle_create_green_icon;
            this.btnAddDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(29, 24);
            this.btnAddDoctor.Text = "toolStripButton1";
            this.btnAddDoctor.ToolTipText = "Add New Doctor";
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnEditDoctor
            // 
            this.btnEditDoctor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditDoctor.Image = global::AppointmentSystem_DC.Properties.Resources._1891025_circle_compose_draw_edit_write_icon;
            this.btnEditDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditDoctor.Name = "btnEditDoctor";
            this.btnEditDoctor.Size = new System.Drawing.Size(29, 24);
            this.btnEditDoctor.Text = "toolStripButton2";
            this.btnEditDoctor.ToolTipText = "Edit Doctor Info";
            this.btnEditDoctor.Click += new System.EventHandler(this.btnEditDoctor_Click);
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteDoctor.Image = global::AppointmentSystem_DC.Properties.Resources.trash_can_115312;
            this.btnDeleteDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(29, 24);
            this.btnDeleteDoctor.Text = "toolStripButton3";
            this.btnDeleteDoctor.ToolTipText = "Delete Doctor";
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Image = global::AppointmentSystem_DC.Properties.Resources.patient_png;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(20, 24);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddPatient.Image = global::AppointmentSystem_DC.Properties.Resources._1891032_add_append_circle_create_green_icon;
            this.btnAddPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(29, 24);
            this.btnAddPatient.Text = "toolStripButton4";
            this.btnAddPatient.ToolTipText = "Add New Patient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditPatient.Image = global::AppointmentSystem_DC.Properties.Resources._1891025_circle_compose_draw_edit_write_icon;
            this.btnEditPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(29, 24);
            this.btnEditPatient.Text = "toolStripButton5";
            this.btnEditPatient.ToolTipText = "Edit Patient Info";
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeletePatient.Image = global::AppointmentSystem_DC.Properties.Resources.trash_can_115312;
            this.btnDeletePatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(29, 24);
            this.btnDeletePatient.Text = "toolStripButton6";
            this.btnDeletePatient.ToolTipText = "Delete Patient";
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveInfo.Image = global::AppointmentSystem_DC.Properties.Resources.save_png;
            this.btnSaveInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(29, 24);
            this.btnSaveInfo.Text = "toolStripButton7";
            this.btnSaveInfo.ToolTipText = "Save To File";
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvAppointments);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtNotes);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer2.Size = new System.Drawing.Size(760, 544);
            this.splitContainer2.SplitterDistance = 481;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvAppointments
            // 
            this.lvAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAppointments.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAppointments.FullRowSelect = true;
            this.lvAppointments.GridLines = true;
            this.lvAppointments.Location = new System.Drawing.Point(0, 27);
            this.lvAppointments.MultiSelect = false;
            this.lvAppointments.Name = "lvAppointments";
            this.lvAppointments.Size = new System.Drawing.Size(481, 517);
            this.lvAppointments.TabIndex = 1;
            this.lvAppointments.UseCompatibleStateImageBehavior = false;
            this.lvAppointments.View = System.Windows.Forms.View.Details;
            this.lvAppointments.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvAppointments_MouseClick);
            this.lvAppointments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAppointments_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Patient Name";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Doctor Name";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 110;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.btnAddAppointment,
            this.btnCancelAppointment,
            this.toolStripSeparator2,
            this.btnSaveToFile,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(481, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(103, 24);
            this.toolStripLabel2.Text = "Appointments";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddAppointment.Image = global::AppointmentSystem_DC.Properties.Resources.add_png;
            this.btnAddAppointment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(29, 24);
            this.btnAddAppointment.Text = "toolStripButton1";
            this.btnAddAppointment.ToolTipText = "Add A New Appointment";
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelAppointment.Image = global::AppointmentSystem_DC.Properties.Resources.delete_png;
            this.btnCancelAppointment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(29, 24);
            this.btnCancelAppointment.ToolTipText = "Cancel Appointment";
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveToFile.Image = global::AppointmentSystem_DC.Properties.Resources.save_png;
            this.btnSaveToFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(29, 24);
            this.btnSaveToFile.Text = "toolStripButton3";
            this.btnSaveToFile.ToolTipText = "Save To File";
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsTab = true;
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(0, 25);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(275, 519);
            this.txtNotes.TabIndex = 1;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(275, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "Notes";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::AppointmentSystem_DC.Properties.Resources._211882_refresh_icon;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 24);
            this.btnRefresh.Text = "toolStripButton1";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 544);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Control System";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnAddAppointment;
        private ToolStripButton btnCancelAppointment;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnSaveToFile;
        private TextBox txtNotes;
        private ToolStrip toolStrip3;
        private ToolStripLabel toolStripLabel1;
        private ToolTip toolTip1;
        private ListView lvAppointments;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripButton btnAddDoctor;
        private ToolStripButton btnEditDoctor;
        private ToolStripButton btnDeleteDoctor;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toolStripLabel4;
        private ToolStripButton btnAddPatient;
        private ToolStripButton btnEditPatient;
        private ToolStripButton btnDeletePatient;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnSaveInfo;
        private TreeView trvList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ToolStripButton btnRefresh;
    }
}