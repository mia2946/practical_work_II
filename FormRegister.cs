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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string msg;
            string name = textBoxName.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string email = textBoxEmail.Text;

            if (textBoxPassword.Text.Equals(textBoxRepeatPassword.Text))
            {
                msg = User.validateFormMessages(name, username, password, email);
                if ( msg == "")
                {
                    if (checkBox1.Checked)
                    {
                        labelRegisterMsgs.Visible = false;

                        // Actualizar el usuario correspondiente
                        User newUser = new User(name, username, password, email);
                        string error = UserManager.getInstance().AddUser(newUser);
                        FileManager.WriteUsersToFile(UserManager.getInstance().users);

                        if (error == "")
                        {
                            MessageBox.Show(this, "New user has been added successfully!", "Information",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);


                            Thread t_newForm = new Thread(new ThreadStart(FormLogin.ThreadRunFormLogin));
                            t_newForm.Start();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show(this, error, "Warning",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        labelRegisterMsgs.Text = "You must accept Terms and Conditions";
                        labelRegisterMsgs.Visible = true;
                    }
                }
                else
                {
                    labelRegisterMsgs.Text = msg;
                    labelRegisterMsgs.Visible = true;
                }
            }
            else
            {
                labelRegisterMsgs.Text = "Both passwords must be the same";
                labelRegisterMsgs.Visible = true;
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string passwordMsg = User.validatePasswordMessage(textBoxPassword.Text);
            if (passwordMsg != "")
            {
                labelRegisterMsgs.Text = passwordMsg;
                labelRegisterMsgs.Visible = true;
            }
            else
            {
                labelRegisterMsgs.Visible = false;
            }

        }

        private void textBoxRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals(textBoxRepeatPassword.Text))
            {
                    labelRegisterMsgs.Visible = false;
            }
            else
            {
                labelRegisterMsgs.Text = "Both passwords must be the same";
                labelRegisterMsgs.Visible = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = checkBox1.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTermsAndConditions formTermsAndConditions = new FormTermsAndConditions();
            formTermsAndConditions.ShowDialog();
        }
    }
}
