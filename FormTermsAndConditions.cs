using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalWorkII
{
    public partial class FormTermsAndConditions : Form
    {
        public FormTermsAndConditions()
        {
            InitializeComponent();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength= 0;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
