using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticalWorkII.Users;

namespace PracticalWorkII
{
    public partial class FormInfo : Form
    {
        private User currentUser;

        public FormInfo(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            FillFormInfo();
        }

        private void FillFormInfo()
        {
            textBoxName.Text = currentUser.name;
            textBoxUsername.Text = currentUser.username;
            textBoxPassword.Text = currentUser.password;
            textBoxEmail.Text = currentUser.email;
            textBoxNOperations.Text = currentUser.totalOperations.ToString();
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        
        private void ActivateEditing(bool active)
        {
            textBoxName.Enabled = active;
            textBoxUsername.Enabled = active;
            textBoxPassword.Enabled = active;
            textBoxEmail.Enabled = active;
            buttonSave.Visible = active;
            buttonCancel.Visible = active;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ActivateEditing(true);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FillFormInfo();
            ActivateEditing(false);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string errorMesssage;

            errorMesssage = User.validateFormMessages( textBoxName.Text,
                                                       textBoxUsername.Text,
                                                       textBoxPassword.Text,
                                                       textBoxEmail.Text);

            if (errorMesssage == "")
            {
                currentUser.name = textBoxName.Text;
                currentUser.username= textBoxUsername.Text;
                currentUser.password= textBoxPassword.Text;
                currentUser.email= textBoxEmail.Text;
                ActivateEditing(false);
                labelValidationMessage.Visible = false;
            }
            else
            {
                labelValidationMessage.Text= errorMesssage;
                labelValidationMessage.Visible = true;
            }
        }
    }
}
