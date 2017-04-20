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
    public partial class assets : Form
    {
        public string formType;

        public assets()
        {
            InitializeComponent();

            bOk.DialogResult = DialogResult.OK;
            bCancel.DialogResult = DialogResult.Cancel;
        }

        public void savedetails()
        {
            //save details to database
            //this.assetsTA.Update(this.creddataDSAssets.ASSETS);
            
        }

        private void Assets_Shown(object sender, EventArgs e)
        {
            if (formType == "New")
            {
                this.Text = "New Asset";
            }
            else
            {
                this.Text = "Amending an Asset";
            }
        }
    }
}
