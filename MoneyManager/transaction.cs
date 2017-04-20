using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class fTransaction : Form
    {
        public string formType;

        public fTransaction()
        {
            InitializeComponent();

            bOk.DialogResult = DialogResult.OK;
            bCancel.DialogResult = DialogResult.Cancel;

        }

        public void savedetails()
        {
            //save details to database
        }

        private void fTransaction_Shown(object sender, EventArgs e)
        {
            if (formType == "New")
            {
                this.Text = "New Transaction";
            }
            else
            {
                this.Text = "Amending a Transaction";
            }
        }
    }
}
