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
    public partial class FormLogin : Form
    {
        User currentUser;
        public FormLogin()
        {
            InitializeComponent();
        }
        public FormLogin(Form source)
        {
            InitializeComponent();
            source.Close();
        }

        private void ThreadRunFormCalculator()
        {
            Application.Run(new FormCalculator(currentUser));
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            currentUser = UserManager.getInstance().FindUserByUsernameAndPassword(username, password);

            if(currentUser != null)
            {
                Thread t_newForm = new Thread(new ThreadStart(ThreadRunFormCalculator));
                t_newForm.Start();

                this.Close();
            }
            else
            {
                labelErrorCredentials.Visible = true;
                /*
                MessageBox.Show(this, "Wrong credentials!", "Information",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                 */
            }
        }

        private void ThreadRunFormRecovery()
        {
            Application.Run(new FormRecovery());
        }
        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread t_newForm = new Thread(new ThreadStart(ThreadRunFormRecovery));
            t_newForm.Start();

            this.Close();
        }

        private void ThreadRunFormRegister()
        {
            Application.Run(new FormRegister());
        }
        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread t_newForm = new Thread(new ThreadStart(ThreadRunFormRegister));
            t_newForm.Start();

            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        public static void ThreadRunFormLogin()
        {
            Application.Run(new FormLogin());
        }

    }
}
