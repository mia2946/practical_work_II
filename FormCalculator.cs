using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticalWorkII.Calculator;
using PracticalWorkII.Users;

namespace PracticalWorkII
{
    public partial class FormCalculator : Form
    {
        private User currentUser;
        private Calculator.Calculator calculator;

        public FormCalculator(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.calculator = new Calculator.Calculator();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button buttonNumber = (Button) sender;
            textBoxScreen.Text = textBoxScreen.Text + buttonNumber.Text;
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            Button buttonComma = (Button)sender;
            string screenName = textBoxScreen.Text;
            
            string[] parts = screenName.Split(' ');
            if (parts.Length == 1)
            {
                if (parts[0].Length>0 && !parts[0].Contains(','))
                {
                    textBoxScreen.Text = textBoxScreen.Text + ',';
                }
            }
            if (parts.Length == 3)
            {
                if (parts[2].Length>0 && !parts[2].Contains(','))
                {
                    textBoxScreen.Text = textBoxScreen.Text + ',';
                }
            }
        }


        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo= new FormInfo(currentUser);
            formInfo.ShowDialog();
        }

        private void closeSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager.WriteUsersToFile(UserManager.getInstance().users);

            Thread t_newForm = new Thread(new ThreadStart(FormLogin.ThreadRunFormLogin));
            t_newForm.Start();

            this.Close();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string operation;
            operation = textBoxScreen.Text;
         
            if(operation != "")
            {
                int n;
                double n2;
                string result = calculator.PerformOperation(operation);
                textBoxScreen.Text = result;
                if(int.TryParse(result, out n) || double.TryParse(result, out n2))
                {
                    currentUser.totalOperations++;
                }
            }
        }


        private void buttonOperation_Click(object sender, EventArgs e)
        {
            Button buttonOperation = (Button)sender;
            textBoxScreen.Text = textBoxScreen.Text + " " + buttonOperation.Text + " ";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = "";
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            string screenName = textBoxScreen.Text;
            if(screenName.Contains(" + ") || screenName.Contains(" - ") || screenName.Contains(" * ") ||
               screenName.Contains(" / ") || screenName.Contains(" ^ ") || screenName.Contains(" mod ")
               )
            {
                string[] parts = screenName.Split(' ');
                if(parts.Length == 3)
                {
                    if (parts[2].Length > 0)
                    {
                        if (parts[2][0] == '-')
                        {
                            parts[2] = parts[2].Substring(1);
                        }
                        else
                        {
                            parts[2] = "-" + parts[2];
                        }
                        screenName = parts[0] + " " + parts[1] + " " + parts[2];
                    }
                }
            }
            else if(screenName.Length>0)
            {
                if (screenName[0] == '-')
                {
                    screenName = screenName.Substring(1);
                }
                else
                {
                    screenName = "-" + screenName;
                }
            }
            textBoxScreen.Text = screenName;
        }
    }
}
