﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmploNexus.AppData;
using System.Text.RegularExpressions;
using static System.Windows.Forms.LinkLabel;


namespace EmploNexus.Forms
{
    public partial class Frm_Registration : Form
    {
        public string username = String.Empty;
        EmploNexusO_oEntities db;

        public Frm_Registration()
        {
            InitializeComponent();
            //
            db = new EmploNexusO_oEntities();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            loadCbBoxRole();
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
        }

        public void loadCbBoxRole()
        {
            // SELECT * FROM ROLE
            var roles = db.Roles.ToList();

            cmbBoxRole.ValueMember = "roleId";
            cmbBoxRole.DisplayMember = "roleName";
            cmbBoxRole.DataSource = roles;
        }

        private void ClearInputFields()
        {
            txtEmployeeID.Clear();
            txtpass_word.Clear();
            txtConfirmPassword.Clear();
            txtuser_name.Clear();
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = Regex.IsMatch(email, emailPattern);
            return isValid;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //String cbResultSelected = cbBoxRole.SelectedValue.ToString();
            if (String.IsNullOrEmpty(txtEmployeeID.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmployeeID, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtuser_name.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuser_name, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtpass_word.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtpass_word, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Empty field");
                return;
            }

            if (!txtpass_word.Text.Equals(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Password not match");
                return;
            }
            
            UserAccount nUserAccount = new UserAccount();

            nUserAccount.user_empID = Convert.ToInt32(txtEmployeeID.Text);
            nUserAccount.username = txtuser_name.Text;
            nUserAccount.password = txtpass_word.Text;
            nUserAccount.roleId = (Int32)cmbBoxRole.SelectedValue;

            username = txtuser_name.Text;

            db.UserAccounts.Add(nUserAccount);
            db.SaveChanges();

            ClearInputFields();
            MessageBox.Show("Registered Successfully!", "EmploNexus: Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpBox_useraccIfno_Enter(object sender, EventArgs e)
        {

        }

        private void txtuser_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_word_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
