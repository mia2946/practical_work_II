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
    public partial class FormRecovery : Form
    {
        private User userFound = null;

        public FormRecovery()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            userFound = UserManager.getInstance().FindUserByUsernameOrEmail(textBoxUsernameOrEmail.Text);

            if (userFound != null)
            {
                labelErrorUserNotFound.Visible = false;

                textBoxPassword.Enabled = true;
                textBoxPassword.Focus();
                textBoxRepeatPassword.Enabled = true;
                buttonChangePassword.Enabled = true;
                textBoxUsernameOrEmail.Enabled = false;
            }
            else
            {
                labelErrorUserNotFound.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals(textBoxRepeatPassword.Text))
            {
                if(User.validatePasswordMessage(textBoxPassword.Text) == "")
                {
                    labelErrorPasswords.Visible = false;

                    // Actualizar el usuario correspondiente
                    userFound.password = textBoxPassword.Text;
                    FileManager.WriteUsersToFile(UserManager.getInstance().users);

                    MessageBox.Show(this, "User password has been changed successfully!", "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                    Thread t_newForm = new Thread(new ThreadStart(FormLogin.ThreadRunFormLogin));
                    t_newForm.Start();

                    this.Close();
                }
            }
            else
            {
                labelErrorPasswords.Text = "Both passwords must be the same";
                labelErrorPasswords.Visible = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string passwordMsg = User.validatePasswordMessage(textBoxPassword.Text);
            if (passwordMsg != "")
            {
                labelErrorPasswords.Text = passwordMsg;
                labelErrorPasswords.Visible = true;
            }
            else
            {
                labelErrorPasswords.Visible = false;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Thread t_newForm = new Thread(new ThreadStart(FormLogin.ThreadRunFormLogin));
            t_newForm.Start();

            this.Close();
        }
    }
}
