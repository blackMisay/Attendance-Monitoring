using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prototype.Class;

namespace Prototype
{
    public partial class frmPrototype : Form
    {     
        public frmPrototype()
        {
            InitializeComponent();
            GetAttendanceList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetSearchList();
        }


        private void GetAttendanceList()
        {
            try
            {
                dgvAttendance.DataSource = Attendance.GetRecordList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GetSearchList()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    dgvAttendance.DataSource = Attendance.GetRecordListByTag(txtSearch.Text.Trim());
                }
                else 
                {
                    MessageBox.Show("Please specify a search value to proceed.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSearch.Focus();
                }
            }
            catch (Exception e)
            {
                 MessageBox.Show(e.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        Attendance Attendance = new Attendance();

        private void btnImport_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void Import()
        {
            OpenFileDialog ofdImport = new OpenFileDialog();

            if (ofdImport.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = ofdImport.FileName;

                if (MessageBox.Show("Are you sure that you wanted to import the selected file? \n \n" + ofdImport.FileName, "Confirm to import", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }

            }
        }

    }
}
