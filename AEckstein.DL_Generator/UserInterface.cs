using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DL_Converter
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Initializes the form.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Menu strip that holds about page and could be used for added features.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutInterface form = new AboutInterface();
            form.Show();
        }

        /// <summary>
        /// Eventhandler for Generate button. Checks to see if Tx Code was entered properly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateButton_Click(object sender, EventArgs e)
        {
            if(txTextBox.Text.Length != 8)
            {
                MessageBox.Show("TX ID must be 8 characters", "Error");
            }
            else
            {
                createDL();
            }
        }

        /// <summary>
        /// Generates DL Codes.
        /// </summary>
        private void createDL()
        {
            StringBuilder sb = new StringBuilder(6);
            string text = txTextBox.Text;
            sb.Append(text[6]);
            sb.Append(text[7]);
            sb.Append(text[4]);
            sb.Append(text[5]);
            sb.Append(text[2]);
            sb.Append(text[3]);
            dlTextBox.Text = sb.ToString();
        }
    }
}
