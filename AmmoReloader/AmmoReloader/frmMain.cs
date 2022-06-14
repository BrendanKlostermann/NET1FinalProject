using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataObjects;

namespace AmmoReloader
{
    public partial class frmMain : Form
    {
        AmmoLogic _ammoManager = new AmmoLogic();
        List<Ammo> _ammoList = null;

        public frmMain()
        {
            InitializeComponent();
        }

        public void PopulateList()
        {
            
            lstAmmoList.Items.Clear();

            for(int i = 0; i < _ammoList.Count(); i++)
            {
                lstAmmoList.Items.Add(_ammoList[i].ammoType);
                lstAmmoList.Items[lstAmmoList.Items.Count - 1].SubItems.Add(_ammoList[i].ammoWeight);
            }
        }// end of PopulateList

        public void RefreshAmmoList()
        {
            try
            {
                _ammoList = _ammoManager.FetchAmmoList();
                PopulateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message, "The data was not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end of RefreshAmmoList

        private void frmMain_Load(object sender, EventArgs e)
        {
            RefreshAmmoList();
            //RefreshInventoryList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(lstAmmoList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select an ammo type to view.", "Nothing is selected",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            int ammoSelected = lstAmmoList.SelectedItems[0].Index;

            frmReloadScreen ammoForm = new frmReloadScreen(ammoSelected);
            ammoForm.ShowDialog();
            
        }

        private void lstAmmoList_DoubleClick(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(lstAmmoList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select an ammo type to view.", "Nothing is selected",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int ammoSelected = lstAmmoList.SelectedItems[0].Index;

            frmModifyMenu modifyForm = new frmModifyMenu(ammoSelected);

            DialogResult result = modifyForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                RefreshAmmoList();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddMenu addAmmo = new frmAddMenu();

            DialogResult result = addAmmo.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshAmmoList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstAmmoList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select an ammo type to view.", "Nothing is selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete that?", "Delete an item", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                int ammoSelected = lstAmmoList.SelectedItems[0].Index;
                _ammoList = _ammoManager.FetchAmmoList();
                _ammoList.RemoveAt(ammoSelected);
                AmmoLogic.UpdateAmmoList(_ammoList);
                RefreshAmmoList();
            }
        }

        private void lstAmmoList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int column = e.Column;
            switch (column)
            {
                case 0:
                    _ammoList = _ammoList.OrderBy(c => c.ammoType).ToList();
                    PopulateList();
                    break;
                case 1:
                    _ammoList = _ammoList.OrderBy(c => c.ammoWeight).ToList();
                    PopulateList();
                    break;
            }
        }
    }
}
