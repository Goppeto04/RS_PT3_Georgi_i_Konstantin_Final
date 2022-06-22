using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AlcoholicButton_Click(object sender, EventArgs e)
        {
            AlcoholicForm alcoholicForm = new AlcoholicForm();
            alcoholicForm.ShowDialog();
        }

        private void AlcoholButton_Click(object sender, EventArgs e)
        {
            AlcoholForm alcoholForm = new AlcoholForm();
            alcoholForm.ShowDialog();
        }

        private void PartyButton_Click(object sender, EventArgs e)
        {
            PartyForm partyForm = new PartyForm();
            partyForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
