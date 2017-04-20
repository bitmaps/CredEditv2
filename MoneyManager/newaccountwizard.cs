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
    public partial class newaccountwizard : Form
    {
        public newaccountwizard()
        {
            InitializeComponent();
        }

        private void HideAllTabsOnTabControl(TabControl theTabControl)
        {
            theTabControl.Appearance = TabAppearance.FlatButtons;
            theTabControl.ItemSize = new Size(0, 1);
            theTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void newaccountwizard_Shown(object sender, EventArgs e)
        {
            HideAllTabsOnTabControl(tcAccountWizard);
        }

        public void savedetails()
        {
            //save details to database
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            if (tcAccountWizard.SelectedIndex > 0 )
              tcAccountWizard.SelectedIndex = tcAccountWizard.SelectedIndex - 1;
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            if (tcAccountWizard.SelectedIndex < tcAccountWizard.TabCount)
                tcAccountWizard.SelectedIndex = tcAccountWizard.SelectedIndex + 1;
        }
    }
}
