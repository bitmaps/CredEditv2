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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

            SQLiteDatabase DBConn = new SQLiteDatabase(); 
            DBConn.LoadDefaultDatabase();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdOpenDatabase.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //insert database location and load code here
            }
        }

        private void newDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdNewDatabase.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //insert database save code here
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAboutBox AboutBox = new fAboutBox();
            AboutBox.Show();
            //centre window
            if (AboutBox.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - AboutBox.Width) / 2;
                var y = Location.Y + (Height - AboutBox.Height) / 2;
                AboutBox.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var PayeesForm = new payees();
            PayeesForm.formType = "New";
            
            //PayeesForm.ShowDialog();

            //centre window
            if (PayeesForm.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - PayeesForm.Width) / 2;
                var y = Location.Y + (Height - PayeesForm.Height) / 2;
                PayeesForm.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }

            if (PayeesForm.ShowDialog(this) == DialogResult.OK)
            {
                //save data
                PayeesForm.savedetails();
            }
            else
            {
                //ignore
            }
            PayeesForm.Dispose();          
        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int selectedNodeIndex = e.Node.Index;
            switch (selectedNodeIndex)
            {
                case 1:
                    //Bank Accounts
                    tcMain.SelectedIndex = 1;
                    break;
                case 2:
                    //Assets
                    tcMain.SelectedIndex = 2;
                    break;
                case 3:
                    //Payees
                    tcMain.SelectedIndex = 3;
                    break;
                case 4:
                    //Repeating Transactions
                    tcMain.SelectedIndex = 4;
                    break;
                case 5:
                    //Budgets
                    tcMain.SelectedIndex = 5;
                    break;
                case 6:
                    //Reports
                    tcMain.SelectedIndex = 6;
                    break;
                default:
                    //homepage
                    tcMain.SelectedIndex = 0;
                    break;
            }
        }

        private void tsbPayeesEdit_Click(object sender, EventArgs e)
        {
            var PayeesForm = new payees();
            PayeesForm.formType = "Amend";
            //PayeesForm.ShowDialog();

            //centre window
            if (PayeesForm.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - PayeesForm.Width) / 2;
                var y = Location.Y + (Height - PayeesForm.Height) / 2;
                PayeesForm.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }

            if (PayeesForm.ShowDialog(this) == DialogResult.OK)
            {
                //save data
                PayeesForm.savedetails();
            }
            else
            {
                //ignore
            }
            PayeesForm.Dispose();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            var TransactionForm = new fTransaction();
            TransactionForm.formType = "New";
            //PayeesForm.ShowDialog();

            //centre window
            if (TransactionForm.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - TransactionForm.Width) / 2;
                var y = Location.Y + (Height - TransactionForm.Height) / 2;
                TransactionForm.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }

            if (TransactionForm.ShowDialog(this) == DialogResult.OK)
            {
                //save data
                TransactionForm.savedetails();
            }
            else
            {
                //ignore
            }
            TransactionForm.Dispose();
        }

        private void tsBankAccountsEdit_Click(object sender, EventArgs e)
        {
            var TransactionForm = new fTransaction();
            TransactionForm.formType = "Amend";
            //PayeesForm.ShowDialog();

            //centre window
            if (TransactionForm.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - TransactionForm.Width) / 2;
                var y = Location.Y + (Height - TransactionForm.Height) / 2;
                TransactionForm.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }

            if (TransactionForm.ShowDialog(this) == DialogResult.OK)
            {
                //save data
                TransactionForm.savedetails();
            }
            else
            {
                //ignore
            }
            TransactionForm.Dispose();
        }

        private void tsbAssetsNew_Click(object sender, EventArgs e)
        {
            var AssetsForm = new assets();
            AssetsForm.formType = "New";
            //PayeesForm.ShowDialog();



            /*
            // Create a new row.
            creddataDataSetAssets.ASSETSRow newAssetRow;
            newAssetRow = creddataDSAssets.ASSETS.NewASSETSRow();
            //newAssetRow.ASSETID = 
            newAssetRow.ASSETNAME = 
            
            // Add the row to the ASSETS table
            this.creddataDSAssets.ASSETS.Rows.Add(newAssetRow);

            // Save the new row to the database
            this.assetsTA.Update(this.creddataDSAssets.ASSETS);
            */

            //centre window
            if (AssetsForm.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - AssetsForm.Width) / 2;
                var y = Location.Y + (Height - AssetsForm.Height) / 2;
                AssetsForm.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }

            if (AssetsForm.ShowDialog(this) == DialogResult.OK)
            {
                //save data
                AssetsForm.savedetails();

                //https://msdn.microsoft.com/en-us/library/ms171933.aspx
                try
                {
                    this.Validate();
                    this.creddataDSAssetsBS.EndEdit();
                    this.assetsTA.Update(this.creddataDSAssets.ASSETS);                        
                    MessageBox.Show("Update successful");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update failed");
                }
               
            }
            else
            {
                //ignore
            }
            AssetsForm.Dispose();
        }

        private void tsbAssetsEdit_Click(object sender, EventArgs e)
        {
            var AssetsForm = new assets();
            AssetsForm.formType = "Amend";
            //PayeesForm.ShowDialog();

            //centre window
            if (AssetsForm.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - AssetsForm.Width) / 2;
                var y = Location.Y + (Height - AssetsForm.Height) / 2;
                AssetsForm.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }

            if (AssetsForm.ShowDialog(this) == DialogResult.OK)
            {
                //save data
                AssetsForm.savedetails();
                //this.assetsTA.Update(this.creddataDSAssets.ASSETS);
            }
            else
            {
                //ignore
            }
            AssetsForm.Dispose();
        }

        private void tsbNewAccount_Click(object sender, EventArgs e)
        {
            var AccountWizardForm = new newaccountwizard();

            if (AccountWizardForm.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - AccountWizardForm.Width) / 2;
                var y = Location.Y + (Height - AccountWizardForm.Height) / 2;
                AccountWizardForm.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            }

            if (AccountWizardForm.ShowDialog(this) == DialogResult.OK)
            {
                //save data
                AccountWizardForm.savedetails();
            }
            else
            {
                //ignore
            }
            AccountWizardForm.Dispose();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'creddataDataSetPayees.PAYEES' table. You can move, or remove it, as needed.
            this.payeesTA.Fill(this.creddataDSPayees.PAYEES);
            this.assetsTA.Fill(this.creddataDSAssets.ASSETS);
        }

        private void creddataDSPayeesBS_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
