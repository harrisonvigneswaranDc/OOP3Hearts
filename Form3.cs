using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class InfoPage : Form
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  // Closes the Info Form
            Application.OpenForms[0].Show();  // Assumes the Main Form is the first opened form and shows it
        }
    }
    }


