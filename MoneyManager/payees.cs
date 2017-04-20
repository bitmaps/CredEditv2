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
    public partial class payees : Form
    {

        public string formType;

        public payees()
        {
            InitializeComponent();

            bOk.DialogResult = DialogResult.OK;
            bCancel.DialogResult = DialogResult.Cancel;            

        }

        public void savedetails()
        {
            
            //save details to database
            /* try
             {
                 this.Validate();
                 this.PayeesBS.EndEdit();
                 this.PayeesTA.Update(this.creddataDataSetPayees.Payees);
                 MessageBox.Show("Update successful");
             }
             catch (System.Exception ex)
             {
                 MessageBox.Show("Update failed");
             }*/

        }

        private void payees_Shown(object sender, EventArgs e)
        {
            if (formType == "New")
            {
                this.Text = "New Payee";
            }
            else
            {
                this.Text = "Amending a Payee";
            }
        }

        private void payees_Load(object sender, EventArgs e)
        {
        }
    }

}
